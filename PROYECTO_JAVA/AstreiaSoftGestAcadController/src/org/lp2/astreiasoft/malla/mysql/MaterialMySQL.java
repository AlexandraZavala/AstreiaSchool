package org.lp2.astreiasoft.malla.mysql;
import java.sql.Blob;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.malla.dao.MaterialDAO;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.malla.model.Material;

/**
 *
 * @author Alexandra
 */
public class MaterialMySQL implements MaterialDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Material material) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_MATERIAL(?,?,?,?,?) }");
            cs.registerOutParameter("_id_material", java.sql.Types.INTEGER);
            cs.setInt("_fid_curso_programado", material.getCursoProgramado().getIdCursoProgramado());
            cs.setString("_titulo", material.getNombre());
            cs.setString("_descripcion", material.getDescripcion());
            cs.setBytes("_archivo", material.getArchivo());
            /****/
            
            resultado = cs.executeUpdate();
            material.setIdMaterial(cs.getInt("_id_material"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Material material) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MATERIAL(?,?,?,?,?)}");
            cs.setInt("_id_material", material.getIdMaterial());
            cs.setInt("_fid_curso_programado", material.getCursoProgramado().getIdCursoProgramado());
            cs.setString("_titulo", material.getDescripcion());
            cs.setString("_descripcion", material.getDescripcion());
            /*Blob archivoBlob = con.createBlob();
            archivoBlob.setBytes(1, material.getArchivo());
            cs.setBlob("_archivo", archivoBlob);*/
            cs.setBytes("_archivo", material.getArchivo());
            
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
    public int eliminar(int idCursoProgramado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_MATERIAL(?)");
            cs.setInt("_id_material", idCursoProgramado);
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
    public ArrayList<Material> listarTodos() {
        ArrayList<Material> materiales = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MATERIALES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Material material = new Material();
                material.setCursoProgramado(new CursoProgramado());
                material.setIdMaterial(rs.getInt("id_material"));
                material.getCursoProgramado().setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                material.setNombre(rs.getString("titulo"));
                material.setDescripcion(rs.getString("descripcion"));
                material.setFechaModificacion(rs.getDate("fecha_modificacion"));
                material.setActivo(true);
                
                materiales.add(material);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return materiales;
    }
    
    @Override
    public ArrayList<Material> listarPorCursoProgramado(int idCursoProgramado) {
        ArrayList<Material> materiales = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MATERIALES_POR_CURSO_PROGRAMADO(?)}");
            cs.setInt("_id_curso_programado", idCursoProgramado);
            rs = cs.executeQuery();
            while(rs.next()){
                Material material = new Material();
                material.setCursoProgramado(new CursoProgramado());
                material.setIdMaterial(rs.getInt("id_material"));
                material.setNombre(rs.getString("titulo"));
                material.setDescripcion(rs.getString("descripcion"));
                material.setArchivo(rs.getBytes("archivo"));
                material.setActivo(true);
                materiales.add(material);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return materiales;
    }
}