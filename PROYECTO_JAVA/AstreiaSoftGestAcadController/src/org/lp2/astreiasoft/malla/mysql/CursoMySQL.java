
package org.lp2.astreiasoft.malla.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.malla.model.Curso;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.malla.dao.CursoDAO;
import org.lp2.astreiasoft.malla.model.AreaCurricular;

/**
 *
 * @author Alexandra
 */
public class CursoMySQL implements CursoDAO {
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Curso curso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CURSO(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_curso", java.sql.Types.INTEGER);
            
            cs.setInt("_fid_grado", curso.getGrado().getIdGrado());
            cs.setBytes("_imagen", curso.getImagen());
            cs.setInt("_fid_areaCurricular", curso.getAreaCurricular().getIdAreaCurricular());
            cs.setString("_nombre_curso", curso.getNombre());
            cs.setString("_descripcion_curso", curso.getDescripcion());
            cs.setInt("_horas_semanales", curso.getHorasSemanales());
            
            resultado = cs.executeUpdate();
            
            curso.setIdCurso(cs.getInt("_id_curso"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Curso curso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CURSO(?,?,?,?,?,?,?)}");
            cs.setInt("_id_curso", curso.getIdCurso());
            cs.setBytes("_imagen", curso.getImagen());
            cs.setInt("_fid_grado", curso.getGrado().getIdGrado());
            cs.setInt("_fid_areaCurricular", curso.getAreaCurricular().getIdAreaCurricular());
            cs.setString("_nombre_curso", curso.getNombre());
            cs.setString("_descripcion_curso", curso.getDescripcion());
            cs.setInt("_horas_semanales", curso.getHorasSemanales());
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
    public int eliminar(int idCurso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_CURSO(?)");
            cs.setInt("_id_curso", idCurso);
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
    public ArrayList<Curso> listarTodos() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
//                curso.setImagen(rs.getBytes("imagen"));
                curso.setGrado(new Grado());
                curso.getGrado().setIdGrado(rs.getInt("fid_grado"));
                
                curso.setAreaCurricular(new AreaCurricular());
                curso.getAreaCurricular().setIdAreaCurricular(rs.getInt("fid_areaCurricular"));
                
                //curso.setNombre(rs.getString("nombre_curso"));
                curso.setNombreGrado(rs.getString("nombre_completo"));
                curso.setDescripcion(rs.getString("descripcion_curso"));
                curso.setHorasSemanales(rs.getInt("horas_semanales"));

                curso.setActivo(true);
                cursos.add(curso);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cursos;
    }
    @Override
    public ArrayList<Curso> listarPorNombre(String nombreParam) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_POR_NOMBRE(?)}");
            cs.setString(1, nombreParam); // Establecer el nombre como parámetro
            rs = cs.executeQuery();
            while (rs.next()) {
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
                curso.setImagen(rs.getBytes("imagen"));
                curso.setGrado(new Grado());
                curso.getGrado().setNombre(rs.getString("nombre_completo_grado"));
                curso.getGrado().setIdGrado(rs.getInt("fid_grado"));
                curso.setAreaCurricular(new AreaCurricular());
                curso.getAreaCurricular().setIdAreaCurricular(rs.getInt("fid_areaCurricular"));
                curso.getAreaCurricular().setNombre(rs.getString("nombre_area_curricular"));
                curso.setNombre(rs.getString("nombre_curso"));
                curso.setDescripcion(rs.getString("descripcion_curso"));
                curso.setHorasSemanales(rs.getInt("horas_semanales"));
                curso.setActivo(true);
                cursos.add(curso);
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
        return cursos;
    }
    
    @Override
    public int verificar_curso(Curso curso){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_CURSO(?,?,?)}");
            cs.setInt("_fid_grado", curso.getGrado().getIdGrado());
            cs.setInt("_fid_areaCurricular", curso.getAreaCurricular().getIdAreaCurricular());
            cs.setString("_nombre_curso", curso.getNombre());
            
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
    public int verificar_eliminar_curso(int idCurso){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_ELIMINAR_CURSO(?)}");
            cs.setInt("_id_curso", idCurso);
            
            
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
    public String obtenerNombrePorId(int id){
        String nombre = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_NOMBRE_CURSO_POR_ID(?)}");
            cs.setInt("p_id_curso", id);
            rs = cs.executeQuery();
            if (rs.next()) {
                nombre = rs.getString("nombre_curso");
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
        return nombre;
    }
    
    @Override
    public int encontrarPorCurso(int idCurso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ENCONTRAR_CURSO_PROGRAMADO_POR_CURSO(?)}");
            cs.setInt("_id_Curso", idCurso);
            rs = cs.executeQuery();
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
    public ArrayList<Curso> listarPorUsuarioYAnio(int idUsuario, int anio) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_POR_USUARIO_Y_ANHO(?,?)}");
            cs.setInt("idUsuario", idUsuario);
            cs.setInt("anhoEspecificado", anio);
            rs = cs.executeQuery();
            while (rs.next()) {
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
                curso.setImagen(rs.getBytes("imagen"));
                curso.setGrado(new Grado());
                curso.getGrado().setIdGrado(rs.getInt("fid_grado"));
                curso.setAreaCurricular(new AreaCurricular());
                curso.getAreaCurricular().setIdAreaCurricular(rs.getInt("fid_areaCurricular"));
                curso.setNombre(rs.getString("nombre_curso"));
                curso.setDescripcion(rs.getString("descripcion_curso"));
                curso.setHorasSemanales(rs.getInt("horas_semanales"));
                curso.setActivo(true);
                cursos.add(curso);
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
        return cursos;
    }
    
}
