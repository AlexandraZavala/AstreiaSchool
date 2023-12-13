
package org.lp2.astreiasoft.malla.mysql;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.malla.dao.AreaCurricularDAO;
import org.lp2.astreiasoft.malla.model.AreaCurricular;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.PreparedStatement;
import java.util.ArrayList;

/**
 *
 * @author Alexandra
 */
public class AreaCurricularMySQL implements AreaCurricularDAO{
    private Connection con;
    
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(AreaCurricular areaCurricular) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_AREACURRICULAR(?,?,?) }");
            cs.registerOutParameter("_id_areaCurricular", 
                java.sql.Types.INTEGER);
            cs.setString("_nombre_area_curricular", areaCurricular.getNombre());
            cs.setString("_descripcion", areaCurricular.getDescripcion());
            resultado = cs.executeUpdate();
            
            areaCurricular.setIdAreaCurricular(cs.getInt("_id_areaCurricular"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(AreaCurricular areaCurricular) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_AREACURRICULAR(?,?,?)}");
            cs.setInt("_id_areaCurricular", areaCurricular.getIdAreaCurricular());
            cs.setString("_nombre_area_curricular", areaCurricular.getNombre());
            cs.setString("_descripcion", areaCurricular.getDescripcion());
            
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idAreaCurricular) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_AREACURRICULAR(?)");
            cs.setInt("_id_areaCurricular", idAreaCurricular);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<AreaCurricular> listarTodas() {
        ArrayList<AreaCurricular> areasCurriculares = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AREACURRICULARES_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                AreaCurricular areaCurricular = new AreaCurricular();
                
                areaCurricular.setIdAreaCurricular(rs.getInt("id_areaCurricular"));
                areaCurricular.setNombre(rs.getString("nombre_area_curricular"));
                areaCurricular.setDescripcion(rs.getString("descripcion"));
                areaCurricular.setActivo(rs.getBoolean("activo"));
                areaCurricular.setFechaCreacion(rs.getDate("fecha_creacion"));
                
                areasCurriculares.add(areaCurricular);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return areasCurriculares;
    }
    
    @Override
    public ArrayList<AreaCurricular> listarPorNombre(String nombre) {
        ArrayList<AreaCurricular> areasCurriculares = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AREACURRICULARES_POR_NOMBRE(?)}");
            cs.setString("nombre", nombre);
            rs = cs.executeQuery();
            while (rs.next()) {
                AreaCurricular areaCurricular = new AreaCurricular();
                areaCurricular.setIdAreaCurricular(rs.getInt("id_areaCurricular"));
                areaCurricular.setNombre(rs.getString("nombre_area_curricular"));
                areaCurricular.setDescripcion(rs.getString("descripcion"));
                areaCurricular.setActivo(rs.getBoolean("activo"));
                areaCurricular.setFechaCreacion(rs.getDate("fecha_creacion"));
                areasCurriculares.add(areaCurricular);
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
        return areasCurriculares;
    }
    
    @Override
    public String obtenerNombrePorId(int id){
        String nombreAreaCurricular = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call NOMBRE_AREA_CURRICULAR_ID(?)}");
            cs.setInt("_id_areaCurricular", id);
            rs = cs.executeQuery();
            if (rs.next()) {
                nombreAreaCurricular = rs.getString("nombre_area_curricular");
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
        return nombreAreaCurricular;
    }
    
    @Override
    public int verificar_area(String nombre){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call VERIFICAR_AREA(?) }");
            cs.setString("_nombre_area_curricular", nombre);
            ResultSet rs = cs.executeQuery();

            if (rs.next()) {
                resultado = rs.getInt(1);
            }
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int verificar_eliminar_area(int idArea){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call VERIFICAR_ELIMINAR_AREA(?) }");
            cs.setInt("_id_areaCurricular", idArea);
            ResultSet rs = cs.executeQuery();

            if (rs.next()) {
                resultado = rs.getInt(1);
            }
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
}
