package org.lp2.astreiasoft.malla.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Time;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;
import org.lp2.astreiasoft.malla.model.Horario;
import org.lp2.astreiasoft.malla.dao.HorarioDAO;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.malla.model.DiaSemana;
import org.lp2.astreiasoft.users.model.Docente;
/**
 *
 * @author Alexandra
 */
public class HorarioMySQL implements HorarioDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Horario horario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_HORARIO(?,?,?,?,?,?) }");
            
            
            cs.setInt("_fid_curso_programado", horario.getCursoProgramado().getIdCursoProgramado());
            cs.setInt("_fid_docente", horario.getDocente().getIdUsuario());
            cs.setInt("_fid_seccion", horario.getSeccion().getIdSeccion());
            
            cs.setTime("_hora_inicio", Time.valueOf(horario.getHoraIni()));
            cs.setTime("_hora_fin", Time.valueOf(horario.getHoraFin()));
            cs.setString("_DiaSemana",horario.getDiaSemana());
              
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
    public int modificar(Horario horario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_HORARIO(?,?,?,?,?,?,?)}");

            cs.setInt("_id_horario", horario.getIdHorario()); 
            cs.setInt("_fid_curso_programado", horario.getCursoProgramado().getIdCursoProgramado());
            cs.setInt("_fid_docente", horario.getDocente().getIdUsuario());
            cs.setInt("_fid_seccion", horario.getSeccion().getIdSeccion());
            
            cs.setTime("_hora_inicio", Time.valueOf(horario.getHoraIni()));
            cs.setTime("_hora_fin", Time.valueOf(horario.getHoraFin()));
           
            
            cs.setString("_DiaSemana",horario.getDiaSemana());
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
    public int eliminar(int idHorario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_HORARIO(?)");
            cs.setInt("_id_horario", idHorario);
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
    public ArrayList<Horario> listarTodos() {
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                Seccion seccion= new Seccion();
                Grado grado= new Grado();
                CursoProgramado cursoProgramado= new CursoProgramado();
                Docente docente = new Docente();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setSeccion(seccion);
                horario.getSeccion().setGrado(grado);
                horario.setCursoProgramado(cursoProgramado);
                horario.setDocente(docente);
                horario.getSeccion().setIdSeccion(rs.getInt("fid_seccion"));
                horario.getSeccion().setNombre(rs.getString("nombre_seccion"));
                horario.getSeccion().getGrado().setNombre(rs.getString("nombre_grado"));
                horario.getSeccion().getGrado().setNivel(NivelEducativo.valueOf(rs.getString("NivelEducativo")));
                horario.getCursoProgramado().setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                horario.getCursoProgramado().setDescripcion(rs.getString("nombre_curso"));
                horario.getDocente().setIdUsuario(rs.getInt("fid_docente"));
                horario.getDocente().setNombre(rs.getString("nombre_docente"));
                
                horario.setHoraIni(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                
 
                
                horario.setDiaSemana(rs.getString("DiaSemana"));
                
                horario.setActivo(true);
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios;
    }
    
    @Override
    public ArrayList<Horario> listarTodosPorId(int idSeccion) {
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIOS_X_IDSECCION(?)}");
            cs.setInt("_idSeccion", idSeccion);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                Seccion seccion= new Seccion();
                Grado grado= new Grado();
                CursoProgramado cursoProgramado= new CursoProgramado();
                Docente docente = new Docente();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setSeccion(seccion);
                horario.getSeccion().setGrado(grado);
                horario.setCursoProgramado(cursoProgramado);
                horario.setDocente(docente);
                horario.getSeccion().setIdSeccion(rs.getInt("fid_seccion"));
                
                horario.getCursoProgramado().setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                horario.getCursoProgramado().setDescripcion(rs.getString("nombre_curso"));
                horario.getDocente().setIdUsuario(rs.getInt("fid_docente"));
                horario.getDocente().setNombre(rs.getString("nombre_docente"));
                
                horario.setHoraIni(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                
                horario.setDiaSemana(rs.getString("DiaSemana"));
                
                horario.setActivo(true);
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios;
    }
    
    
    @Override
    public ArrayList<Horario> listarTodosPorIdDocente(int idDocente) {
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIOS_X_IDDOCENTE(?)}");
            cs.setInt("_idDocente", idDocente);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                Seccion seccion= new Seccion();
                Grado grado= new Grado();
                CursoProgramado cursoProgramado= new CursoProgramado();
                Docente docente = new Docente();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setSeccion(seccion);
                horario.getSeccion().setGrado(grado);
                horario.setCursoProgramado(cursoProgramado);
                horario.setDocente(docente);
                horario.getSeccion().setIdSeccion(rs.getInt("fid_seccion"));
                
                horario.getCursoProgramado().setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                horario.getDocente().setIdUsuario(rs.getInt("fid_docente"));
                
                horario.setHoraIni(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                
                horario.setDiaSemana(rs.getString("DiaSemana"));
                
                horario.setActivo(true);
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios;
    }
    
    
    @Override
    public String obtenerNombreDocente(int idHorario) {
        String nombre = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("CALL OBTENER_NOMBRE_DOCENTE_POR_HORARIO(?)");
            cs.setInt("p_id_horario", idHorario);
            
            rs = cs.executeQuery();
            if (rs.next()) {
                nombre = rs.getString("nombre_docente");
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
    public String obtenerNombreCurso(int idHorario) {
        String nombre = null;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call OBTENER_NOMBRE_CURSO_POR_HORARIO(?)");
            cs.setInt("p_id_horario", idHorario);
            rs = cs.executeQuery();
            if (rs.next()) {
                nombre = rs.getString("nombre_curso");
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return nombre;
    }
    
    @Override
    public int verificarEliminarHorarioCursDocente(int idHorario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call VERIFICAR_ELIMINAR_HORARIO_CURSODOCENTE(?)");
            cs.setInt("p_idHorario", idHorario);
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
    public int verificarEliminarHorarioCursEstudiante(int idHorario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call VERIFICAR_ELIMINAR_HORARIO_CURSO_ESTUDIANTE(?)");
            cs.setInt("p_idHorario", idHorario);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}