package org.lp2.astreiasoft.admin.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;
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
import org.lp2.astreiasoft.users.model.Usuario;

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
                CallableStatement cs = con.prepareCall("{call RegistrarAsistencia(?,?,?,?,?,?)}");
                cs.setInt(2, asistencia.getEstudiante().getIdUsuario());
                cs.setInt(1, asistencia.getHorario().getIdHorario());
                cs.setDate(3, new java.sql.Date(asistencia.getFecha().getTime()));
                System.out.println("asistencia: " + asistencia.getEstado() + asistencia.getEstado().toString());
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
    
    @Override
    public ArrayList<Horario> listarHorariosDelCurso(int idCursoProg, int idDocente, String dia) {
        return ejecutarEnConexion(con -> {
            ArrayList<Horario> horarios = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call ListarHorariosDelCurso(?,?,?)}");
                cs.setInt(1, idCursoProg); // Configura el parámetro idCursoProg para el procedimiento almacenado
                cs.setInt(2, idDocente);
                cs.setString(3, dia);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    int idHorario = rs.getInt("id_horario");
                    LocalTime horaInicio = rs.getTime("hora_inicio").toLocalTime();
                    LocalTime horaFin = rs.getTime("hora_fin").toLocalTime();
                    int idSeccion = rs.getInt("id_seccion");
                    String nombreSeccion = rs.getString("nombre_seccion");
                    
                    Horario horario = new Horario();
                    Seccion seccion = new Seccion();
                    
                    horario.setIdHorario(idHorario);
                    horario.setHoraIni(horaInicio);
                    horario.setHoraFin(horaFin);
                    horario.setSeccion(seccion);
                    seccion.setIdSeccion(idSeccion);
                    seccion.setNombre(nombreSeccion);

                    // Agregar el objeto 'horario' a la lista de horarios
                    horarios.add(horario);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return horarios;
        });
    }
    
    @Override
    public ArrayList<Estudiante> listarEstudiantesDelCursoProgramado(int idCursoProgramado, int idHorario) {
        return ejecutarEnConexion(con -> {
            ArrayList<Estudiante> estudiantes = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call ListarEstudiantesDelCursoProgramado(?,?)}");
                cs.setInt(1, idCursoProgramado); // Configura el parámetro idCursoProgramado para el procedimiento almacenado
                cs.setInt(2, idHorario);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    int idUsuario = rs.getInt("id_usuario");
                    String nombre = rs.getString("nombre");
                    String apellidoPaterno = rs.getString("apellido_paterno");
                    String apellidoMaterno = rs.getString("apellido_materno");
                    String correo = rs.getString("correo");
                    String telefono = rs.getString("telefono");

                    // Como Estudiante hereda de Usuario, simplemente podemos asignar los valores directamente
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(idUsuario);
                    estudiante.setNombre(nombre);
                    estudiante.setApellidoPaterno(apellidoPaterno);
                    estudiante.setApellidoMaterno(apellidoMaterno);
                    estudiante.setCorreo(correo);
                    estudiante.setTelefono(telefono);

                    // Agregar el objeto 'estudiante' a la lista de estudiantes
                    estudiantes.add(estudiante);
                }

                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return estudiantes;
        });
    }
    
    @Override
    public ArrayList<Asistencia> obtenerOListarAsistencias(int idHorario, Date fecha) {
        return ejecutarEnConexion(con -> {
            ArrayList<Asistencia> listaAsistencias = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call ObtenerOListarAsistencias(?,?)}");
                cs.setInt(1, idHorario);
                java.sql.Date date = new java.sql.Date(fecha.getTime());
                cs.setDate(2, date);
                System.out.println("fecha: " + date.toString());
                
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Asistencia asistencia = new Asistencia();
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("id_usuario"));
                    estudiante.setNombre(rs.getString("nombre"));
                    estudiante.setApellidoPaterno(rs.getString("apellido_paterno"));
                    estudiante.setApellidoMaterno(rs.getString("apellido_materno"));

                    asistencia.setEstudiante(estudiante);
                    
                    // Comprobar si el ID de asistencia es nulo o no está presente
                    int idAsistencia = rs.getInt("id_asistencia");
                    if (!rs.wasNull()) {
                        asistencia.setIdAsistencia(idAsistencia);
                    }

                    // Comprobar si el estado es nulo o no está presente
                    String estado = rs.getString("estado");
                    if (estado != null && !estado.isEmpty()) {
                        asistencia.setEstado(EstadoAsistencia.valueOf(estado));
                    }

                    // Comprobar si las observaciones son nulas
                    String observaciones = rs.getString("observaciones");
                    asistencia.setObservaciones(observaciones != null ? observaciones : "");

                    listaAsistencias.add(asistencia);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }

            return listaAsistencias;
        });
    }
}
