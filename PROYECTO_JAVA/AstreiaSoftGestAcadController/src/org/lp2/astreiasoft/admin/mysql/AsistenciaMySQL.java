package org.lp2.astreiasoft.admin.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.function.Function;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.lp2.astreiasoft.admin.dao.AsistenciaDAO;
import org.lp2.astreiasoft.admin.model.Asistencia;
import org.lp2.astreiasoft.admin.model.EstadoAsistencia;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.malla.model.Curso;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.malla.model.DiaSemana;
import org.lp2.astreiasoft.malla.model.Horario;
import org.lp2.astreiasoft.users.model.Docente;
import org.lp2.astreiasoft.users.model.Estudiante;

public class AsistenciaMySQL implements AsistenciaDAO {

    private Connection obtenerConexion() throws SQLException {
        return DBManager.getInstance().getConnection();
    }

    private <T> T ejecutarEnConexion(Function<Connection, T> function) {
        Connection con = null;
        try {
            con = obtenerConexion();
            return function.apply(con);
        } catch (SQLException e) {
            System.out.println(e.getMessage());
            return null;
        } finally {
            if (con != null) {
                try {
                    con.close();
                } catch (SQLException ex) {
                    Logger.getLogger(AsistenciaMySQL.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }

    @Override
    public int insertar(Asistencia asistencia) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call INSERTAR_ASISTENCIA(?,?,?,?,?,?)}");
                cs.setInt(1, asistencia.getEstudiante().getIdUsuario());
                cs.setInt(2, asistencia.getHorario().getIdHorario());
                cs.setDate(3, new java.sql.Date(asistencia.getFecha().getTime()));
                cs.setString(4, asistencia.getEstado().toString());
                cs.setString(5, asistencia.getObservaciones());
                cs.registerOutParameter(6, Types.INTEGER);
                cs.execute();
                return cs.getInt(6);
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
    public int modificar(Asistencia asistencia) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call MODIFICAR_ASISTENCIA(?,?,?,?,?)}");
                cs.setInt(1, asistencia.getIdAsistencia()); // Suponiendo que tu clase Asistencia tiene un método getIdAsistencia
                cs.setInt(2, asistencia.getEstudiante().getIdUsuario());
                cs.setDate(3, new java.sql.Date(asistencia.getFecha().getTime()));
                cs.setString(4, asistencia.getEstado().toString());
                cs.setString(5, asistencia.getObservaciones());
                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
    public int eliminar(int idAsistencia) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call ELIMINAR_ASISTENCIA(?)}");
                cs.setInt(1, idAsistencia);
                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
public ArrayList<Asistencia> listarTodas() {
    return ejecutarEnConexion(con -> {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        try {
                CallableStatement cs = con.prepareCall("{call LISTAR_TODAS_ASISTENCIAS()}");
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("fid_estudiante"));
                    estudiante.setNombre(rs.getString("primer_nombre"));
                    // Toma en cuenta que puedes necesitar más campos para completar los datos de 'Estudiante', pero no los agregué aquí para no complicar el código.

                    LocalTime inicio = rs.getTime("hora_inicio").toLocalTime();
                    LocalTime fin = rs.getTime("hora_fin").toLocalTime();

                    Curso curso = new Curso(); // Asumiendo que hay una clase Curso.
                    // Deberías agregar más detalles a 'Curso' si es necesario.

                    CursoProgramado cursoProgramado = new CursoProgramado(rs.getString("descripcion"), rs.getInt("anho"), curso);

                    Docente docente = new Docente(); // Asumiendo que hay una clase Docente.
                    // Deberías agregar más detalles a 'Docente' si es necesario.

                    Seccion seccion = new Seccion(); // Asumiendo que hay una clase Seccion.
                    // Deberías agregar más detalles a 'Seccion' si es necesario.

                    Horario horario = new Horario(cursoProgramado, docente, rs.getString("DiaSemana"), inicio, fin, seccion);
                    horario.setIdHorario(rs.getInt("id_horario"));

                    Asistencia asistencia = new Asistencia(
                        estudiante,
                        rs.getDate("fecha"),
                        horario,
                        EstadoAsistencia.valueOf(rs.getString("estado")),
                        rs.getString("observaciones")
                    );
                    asistencias.add(asistencia);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return asistencias;
        });
    }



}
