package org.lp2.astreiasoft.eval.mysql;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.EvaluacionDAO;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.Types;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Bimestre;
import org.lp2.astreiasoft.eval.model.TipoEvaluacion;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.users.model.Docente;

public class EvaluacionMySQL implements EvaluacionDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Evaluacion evaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_EVALUACION(?,?,?,?,?,?,?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_evaluacion", Types.INTEGER);
            cs.setString("_descripcion", evaluacion.getDescripcion());
            cs.setInt("_fid_docente", evaluacion.getDocente().getIdUsuario());
            cs.setDate("_fechaInicio", new java.sql.Date(evaluacion.getFechaSubido().getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(evaluacion.getFechaLimite().getTime()));
            cs.setDouble("_puntos_maximos", evaluacion.getNota());
            cs.setString("_TipoEvaluacion", evaluacion.getTipo().toString());
            cs.setInt("_fid_bimestre", evaluacion.getBimestre().getIdBimestre());
            cs.setInt("_fid_curso_programado", evaluacion.getCursoProgramado().getIdCursoProgramado());
            cs.setBoolean("_activo", evaluacion.getActivo());
            cs.setDate("_fecha_creacion", new java.sql.Date(evaluacion.getFechaCreacion().getTime()));
            cs.setDate("_fecha_modificacion", new java.sql.Date(evaluacion.getFechaModificacion().getTime()));
            resultado = cs.executeUpdate();
            evaluacion.setIdEvaluacion(cs.getInt("_id_evaluacion"));
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Evaluacion evaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_EVALUACION(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_evaluacion", Types.INTEGER);
            cs.setString("_descripcion", evaluacion.getDescripcion());
            cs.setInt("_fid_docente", evaluacion.getDocente().getIdUsuario());
            cs.setDate("_fechaInicio", new java.sql.Date(evaluacion.getFechaSubido().getTime()));
            cs.setDate("_fechaFin", new java.sql.Date(evaluacion.getFechaLimite().getTime()));
            cs.setDouble("_puntos_maximos", evaluacion.getNota());
            cs.setString("_TipoEvaluacion", evaluacion.getTipo().toString());
            cs.setInt("_fid_bimestre", evaluacion.getBimestre().getIdBimestre());
            cs.setInt("_fid_curso_programado", evaluacion.getCursoProgramado().getIdCursoProgramado());
            cs.setBoolean("_activo", evaluacion.getActivo());
            cs.setDate("_fecha_creacion", new java.sql.Date(evaluacion.getFechaCreacion().getTime()));
            cs.setDate("_fecha_modificacion", new java.sql.Date(evaluacion.getFechaModificacion().getTime()));
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idEvaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_EVALUACION(?)");
            cs.setInt("_id_evaluacion", idEvaluacion);
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Evaluacion> listarTodos() {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVALUACIONES_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setDescripcion(rs.getString("descripcion"));
                Docente docente = new Docente();
                docente.setIdUsuario(rs.getInt("fid_docente"));
                evaluacion.setDocente(docente);
                evaluacion.setFechaSubido(new Date(rs.getDate("fechaInicio").getTime()));
                evaluacion.setFechaSubido(new Date(rs.getDate("fechaFin").getTime()));
                evaluacion.setNota(rs.getDouble("puntos_maximos"));
                evaluacion.setTipo(TipoEvaluacion.valueOf(rs.getString("TipoEvaluacion")));
                Bimestre bimestre = new Bimestre();
                bimestre.setIdBimestre(rs.getInt("fid_bimestre"));
                evaluacion.setBimestre(bimestre);
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                evaluacion.setCursoProgramado(cursoProgramado);
                evaluacion.setActivo(rs.getBoolean("activo"));
                evaluacion.setFechaCreacion(new Date(rs.getDate("fecha_creacion").getTime()));
                evaluacion.setFechaModificacion(new Date(rs.getDate("fecha_modificacion").getTime()));
                evaluaciones.add(evaluacion);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return evaluaciones;
    }
}

