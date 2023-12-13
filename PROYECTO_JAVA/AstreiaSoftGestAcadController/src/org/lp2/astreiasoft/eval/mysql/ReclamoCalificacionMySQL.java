package org.lp2.astreiasoft.eval.mysql;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.Types;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.ReclamoCalificacionDAO;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.EstadoEntrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
import org.lp2.astreiasoft.eval.model.ReclamoCalificacion;

public class ReclamoCalificacionMySQL implements ReclamoCalificacionDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private EstadoEntrega estado;

    @Override
    public int insertar(ReclamoCalificacion reclamoCalificacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_RECLAMOCALIFICACION(?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_reclamo", Types.INTEGER);
            
            cs.setInt("_fid_nota", reclamoCalificacion.getNota().getIdNotaEvaluacion());
            cs.setString("_descripcion", reclamoCalificacion.getDescripcion());
            cs.setDate("_fecha_reclamo", new java.sql.Date(reclamoCalificacion.getFechaReclamo().getTime()));
            
        //Aqui falla
            //estado =  reclamoCalificacion.getEstado();
            //cs.setString("_estado",reclamoCalificacion.getEstado().toString());
            
            cs.setString("_respuesta", reclamoCalificacion.getRespuesta());
            cs.setDate("_fecha_respuesta", new java.sql.Date(reclamoCalificacion.getFechaRespuesta().getTime()));
            resultado = cs.executeUpdate();
            reclamoCalificacion.setIdReclamoCalificacion(cs.getInt("_id_reclamo"));
        } catch (Exception ex) {
            ex.printStackTrace(); // Imprime la traza completa de la excepción
            System.out.println("Error al ejecutar el procedimiento almacenado: " + ex.getMessage());
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
    public int modificar(ReclamoCalificacion reclamoCalificacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_RECLAMOCALIFICACION(?,?,?,?,?,?,?) }");
            cs.setInt("_id_reclamo",reclamoCalificacion.getIdReclamoCalificacion());
            cs.setInt("_fid_nota", reclamoCalificacion.getNota().getIdNotaEvaluacion());
            cs.setString("_descripcion", reclamoCalificacion.getDescripcion());
            cs.setDate("_fecha_reclamo", new java.sql.Date(reclamoCalificacion.getFechaReclamo().getTime()));
            cs.setString("_estado", reclamoCalificacion.getEstado().toString());
            cs.setString("_respuesta", reclamoCalificacion.getRespuesta());
            cs.setDate("_fecha_respuesta", new java.sql.Date(reclamoCalificacion.getFechaRespuesta().getTime()));
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
    public int eliminar(int idReclamo) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_RECLAMOCALIFICACION(?)");
            cs.setInt("_id_reclamo", idReclamo);
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
    public ArrayList<ReclamoCalificacion> listarTodos() {
        ArrayList<ReclamoCalificacion> reclamosCalificacion = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECLAMOCALIFICACIONES_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                ReclamoCalificacion reclamoCalificacion = new ReclamoCalificacion();
                reclamoCalificacion.setIdReclamoCalificacion(rs.getInt("id_reclamo"));
                reclamoCalificacion.setNota(new NotaEvaluacion());
                reclamoCalificacion.getNota().setIdNotaEvaluacion(rs.getInt("fid_nota"));
                reclamoCalificacion.setDescripcion(rs.getString("descripcion"));
                reclamoCalificacion.setFechaReclamo(rs.getDate("fecha_reclamo"));
                reclamoCalificacion.setEstado(EstadoEntrega.valueOf(rs.getString("estado")));
                reclamoCalificacion.setRespuesta(rs.getString("respuesta"));
                reclamoCalificacion.setFechaRespuesta(rs.getDate("fecha_respuesta"));
                
                reclamosCalificacion.add(reclamoCalificacion);
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
        return reclamosCalificacion;
    }
}
