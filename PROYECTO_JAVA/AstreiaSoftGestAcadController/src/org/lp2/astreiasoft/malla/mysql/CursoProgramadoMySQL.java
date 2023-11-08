
package org.lp2.astreiasoft.malla.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.malla.dao.CursoProgramadoDAO;
import org.lp2.astreiasoft.malla.model.Curso;

/**
 *
 * @author Alexandra
 */
public class CursoProgramadoMySQL implements CursoProgramadoDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(CursoProgramado cursoProgramado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_CURSOPROGRAMADO(?,?,?,?) }");
            cs.registerOutParameter("_id_curso_programado", java.sql.Types.INTEGER);
            cs.setInt("_fid_curso", cursoProgramado.getCurso().getIdCurso());
            cs.setString("_descripcion", cursoProgramado.getDescripcion());
            cs.setInt("_anho", cursoProgramado.getAnho());
            resultado = cs.executeUpdate();
            cursoProgramado.setIdCursoProgramado(cs.getInt("_id_curso_programado"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(CursoProgramado cursoProgramado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CURSOSPROGRAMADOS(?,?,?,?)}");
            cs.setInt("_id_curso_programado", cursoProgramado.getIdCursoProgramado());
            cs.setInt("_fid_curso", cursoProgramado.getCurso().getIdCurso());
            cs.setString("_descripcion", cursoProgramado.getDescripcion());
            cs.setInt("_anho", cursoProgramado.getAnho());
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
            cs = con.prepareCall("call ELIMINAR_CURSOPROGRAMADO(?)");
            cs.setInt("_id_curso_programado", idCursoProgramado);
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
    public ArrayList<CursoProgramado> listarTodos() {
        ArrayList<CursoProgramado> cursosProgramados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_PROGRAMADOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("id_curso_programado"));
                cursoProgramado.setCurso(new Curso());
                cursoProgramado.getCurso().setIdCurso(rs.getInt("fid_curso"));
                cursoProgramado.getCurso().setNombre(rs.getString("nombre_curso"));
                
                cursoProgramado.setDescripcion(rs.getString("descripcion"));
                cursoProgramado.setAnho(rs.getInt("anho"));
                //cursoProgramado.setActivo(rs.getBoolean("activo"));
                cursosProgramados.add(cursoProgramado);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cursosProgramados;
    }
    
    @Override
    public ArrayList<CursoProgramado> listarPorNombre(String nombre) {
        ArrayList<CursoProgramado> cursosProgramados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_PROGRAMADOS_POR_NOMBRE(?)}");
            cs.setString(1, nombre); // Establecer el nombre como parámetro
            rs = cs.executeQuery();
            while (rs.next()) {
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("id_curso_programado"));
                cursoProgramado.setCurso(new Curso());
                
                cursoProgramado.getCurso().setIdCurso(rs.getInt("fid_curso"));
                cursoProgramado.getCurso().setNombre(rs.getString("nombre_curso"));
                cursoProgramado.setDescripcion(rs.getString("descripcion"));
                cursoProgramado.setAnho(rs.getInt("anho"));
                //cursoProgramado.setActivo(rs.getBoolean("activo"));
                cursosProgramados.add(cursoProgramado);
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
        return cursosProgramados;
    }
    
    @Override
    public int verificar_curso(CursoProgramado cursoPro){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_CURSO_PROGRAMADO(?,?)}");
            cs.setInt("_anho", cursoPro.getAnho());
            cs.setInt("_fid_curso", cursoPro.getCurso().getIdCurso());
            
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
    public int verificar_estudiantes(int idCursoP, int idSeccion){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VerificarEstudiantesAsociados(?,?)}");
            cs.setInt("p_idCursoProgramado", idCursoP);
            cs.setInt("p_idSeccion", idSeccion);
            
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
    public ArrayList<CursoProgramado> listarPorGrado(int idGrado){
        ArrayList<CursoProgramado> cursosProgramados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_PROGRAMADOS_POR_GRADO(?)}");
            cs.setInt(1, idGrado); // Establecer el nombre como parámetro
            rs = cs.executeQuery();
            while (rs.next()) {
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("id_curso_programado"));
                cursoProgramado.setDescripcion(rs.getString("descripcion"));
                cursoProgramado.setAnho(rs.getInt("anho"));
                cursoProgramado.setCurso(new Curso());
                
                cursoProgramado.getCurso().setIdCurso(rs.getInt("id_curso"));
                cursoProgramado.getCurso().setNombre(rs.getString("nombre_curso"));
                cursoProgramado.getCurso().setHorasSemanales(rs.getInt("horas_semanales"));
                
                cursosProgramados.add(cursoProgramado);
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
        return cursosProgramados;
    }
    
    @Override
    public int asignarEstudiantesCursoProgramado(int idCursoProgramado, ArrayList<Integer> estudiantes) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            
            cs = con.prepareCall("{ call INSERTAR_CURSOPROGRAMADO_ESTUDIANTE(?, ?) }");
            cs.setInt(1, idCursoProgramado);

            for (int estudianteId : estudiantes) {
                cs.setInt(2, estudianteId);
                resultado += cs.executeUpdate();
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
    public ArrayList<CursoProgramado> listarPorUsuario(int idUsuario) {
        ArrayList<CursoProgramado> cursosProgramados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_PROGRAMADOS_POR_USUARIO(?)}");
            cs.setInt(1, idUsuario); // Establecer el nombre como parámetro
            rs = cs.executeQuery();
            while (rs.next()) {
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("id_curso_programado"));
                cursoProgramado.setCurso(new Curso());
                cursoProgramado.getCurso().setIdCurso(rs.getInt("fid_curso"));
                cursoProgramado.setDescripcion(rs.getString("descripcion"));
                cursoProgramado.setAnho(rs.getInt("anho"));
                cursosProgramados.add(cursoProgramado);
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
        return cursosProgramados;
    }
}
