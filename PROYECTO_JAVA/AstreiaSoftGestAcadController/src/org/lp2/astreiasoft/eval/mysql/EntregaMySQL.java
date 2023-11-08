package org.lp2.astreiasoft.eval.mysql;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.EntregaDAO;
import org.lp2.astreiasoft.eval.model.Entrega;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.Types;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.EstadoEntrega;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import org.lp2.astreiasoft.users.model.Estudiante;

public class EntregaMySQL implements EntregaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Entrega entrega) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ENTREGA(?,?,?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_entrega", Types.INTEGER);
            cs.setInt("_fid_evaluacion", entrega.getEvaluacion().getIdEvaluacion());
            cs.setInt("_fid_estudiante", entrega.getEstudiante().getIdUsuario());
//            cs.setBlob("_archivo",entrega.getArchivo());
//            byte[] archivo = entrega.getArchivo();
            if(entrega.getArchivo() != null){
                cs.setBytes("_archivo", entrega.getArchivo());
            }
            else{
                cs.setNull("_archivo", Types.BINARY);
            }
            
            cs.setDate("_fecha_entrega", new java.sql.Date(entrega.getFechaEntrega().getTime()));
            cs.setString("_estado", "Completado");
            cs.setString("_observaciones", entrega.getObservaciones());
            cs.setDate("_fecha_revision", new java.sql.Date(entrega.getFechaRevision().getTime()));
            resultado = cs.executeUpdate();
            entrega.setIdEntrega(cs.getInt("_id_entrega"));
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
    public int modificar(Entrega entrega) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ENTREGA(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_entrega", entrega.getIdEntrega());
            cs.setInt("_fid_evaluacion", entrega.getEvaluacion().getIdEvaluacion());
            cs.setInt("_fid_estudiante", entrega.getEstudiante().getIdUsuario());
            
            if(entrega.getArchivo() != null){
                cs.setBytes("_archivo", entrega.getArchivo());
            }
            else{
                cs.setNull("_archivo", Types.BINARY);
            }
            cs.setDate("_fecha_entrega", new java.sql.Date(entrega.getFechaEntrega().getTime()));
            cs.setString("_estado", "Completado");
            cs.setString("_observaciones", entrega.getObservaciones());
            cs.setDate("_fecha_revision", new java.sql.Date(entrega.getFechaRevision().getTime()));
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
    public int eliminar(int idEntrega) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_ENTREGA(?)");
            cs.setInt("_id_entrega", idEntrega);
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
    public ArrayList<Entrega> listarTodos() {
        ArrayList<Entrega> entregas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ENTREGAS_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Entrega entrega = new Entrega();
                entrega.setIdEntrega(rs.getInt("id_entrega"));
                entrega.setEvaluacion(new Evaluacion());
                entrega.getEvaluacion().setIdEvaluacion(rs.getInt("fid_evaluacion"));
                entrega.setEstudiante(new Estudiante());
                entrega.getEstudiante().setIdUsuario(rs.getInt("fid_estudiante"));
                entrega.setArchivo(rs.getBytes("archivo"));
                entrega.setFechaEntrega(rs.getDate("fecha_entrega"));
                entrega.setEstado(EstadoEntrega.valueOf(rs.getString("estado")));
                entrega.setObservaciones(rs.getString("observaciones"));
                entrega.setFechaRevision(rs.getDate("fecha_revision"));
                entregas.add(entrega);
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
        return entregas;
    }

}