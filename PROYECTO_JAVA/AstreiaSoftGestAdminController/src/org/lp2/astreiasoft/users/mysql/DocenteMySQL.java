package org.lp2.astreiasoft.users.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.users.dao.DocenteDAO;
import org.lp2.astreiasoft.users.model.Docente;

public class DocenteMySQL implements DocenteDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
        
    @Override
    public int insertar(Docente docente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_DOCENTE(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            
            cs.registerOutParameter("_id_docente", INTEGER);
            cs.registerOutParameter("_id_usuario_rol", INTEGER);
            cs.setString("_dni",docente.getDNI());
            cs.setString("_nombre", docente.getNombre());
            cs.setString("_apellido_paterno", docente.getApellidoPaterno());
            cs.setString("_apellido_materno", docente.getApellidoMaterno());
            cs.setBytes("_foto", docente.getFoto());
            cs.setString("_correo", docente.getCorreo());
            cs.setString("_genero", String.valueOf(docente.getGenero())); //es char
            cs.setString("_telefono", docente.getTelefono());
            cs.setString("_contrasenha", docente.getContrasenha());
            cs.setString("_direccion", docente.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(docente.getFechaNacimiento().getTime()));
            //empleado
            cs.setDate("_fecha_contratacion", new java.sql.Date(docente.getFechaContratacion().getTime()));       
            cs.setDouble("_salario",docente.getSalario());
            //docente
            cs.setString("_especialidad", docente.getEspecialidad());
            resultado= cs.executeUpdate();
            docente.setIdUsuario(cs.getInt("_id_docente"));
            int idUsuarioROl= cs.getInt("_id_usuario_rol");
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            ex.printStackTrace();
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Docente docente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_DOCENTE(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            
            cs.setInt("_id_docente", docente.getIdUsuario());
            cs.setString("_dni",docente.getDNI());
            cs.setString("_nombre", docente.getNombre());
            cs.setString("_apellido_paterno", docente.getApellidoPaterno());
            cs.setString("_apellido_materno", docente.getApellidoMaterno());
            cs.setBytes("_foto", docente.getFoto());
            cs.setString("_correo", docente.getCorreo());
            cs.setString("_genero", String.valueOf(docente.getGenero())); //es char
            cs.setString("_telefono", docente.getTelefono());
            cs.setString("_contrasenha", docente.getContrasenha());
            cs.setString("_direccion", docente.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(docente.getFechaNacimiento().getTime()));       
            cs.setDate("_fecha_contratacion", new java.sql.Date(docente.getFechaContratacion().getTime()));       
            cs.setDouble("_salario",docente.getSalario());
            cs.setString("_especialidad", docente.getEspecialidad());
            
            resultado = cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idDocente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DOCENTE(?)}");
            cs.setInt("_id_docente",idDocente);
            
            resultado = cs.executeUpdate();
               
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Docente> listarTodos(String nombreDNI) {
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DOCENTES_TODOS(?)}");
            cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while(rs.next()){
                Docente docente = new Docente();
                docente.setIdUsuario(rs.getInt("id_docente"));
                docente.setDNI(rs.getString("dni"));
                docente.setNombre(rs.getString("nombre"));
                docente.setApellidoPaterno(rs.getString("apellido_paterno"));
                docente.setApellidoMaterno(rs.getString("apellido_materno"));
                docente.setFoto(rs.getBytes("foto"));
                docente.setCorreo(rs.getString("correo"));
                docente.setGenero(rs.getString("genero"));
                docente.setTelefono(rs.getString("telefono"));
                docente.setContrasenha(rs.getString("contrasenha"));
                docente.setDireccion(rs.getString("direccion"));
                docente.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                docente.setFechaRegistro(rs.getDate("fecha_registro"));
                docente.setFechaContratacion(rs.getDate("fecha_contratacion"));
                docente.setSalario(rs.getDouble("salario"));
                docente.setEspecialidad(rs.getString("especialidad"));
                //docente.setActivo(true);
                docentes.add(docente);
                
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return docentes;
    }
	
	
	@Override
    public ArrayList<Docente> listarTodosDocentesCursos() {
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DOCENTES_TODOS_CURSOS()}");
            
            rs = cs.executeQuery();
            while(rs.next()){
                Docente docente = new Docente();
                docente.setIdUsuario(rs.getInt("id_docente"));
                docente.setDNI(rs.getString("dni"));
                docente.setNombre(rs.getString("nombre"));
                docente.setApellidoPaterno(rs.getString("apellido_paterno"));
                docente.setApellidoMaterno(rs.getString("apellido_materno"));
                
               
                docentes.add(docente);
                
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return docentes;
    }
	
	
    @Override
    public int insertarUsuarioExiste(Docente docente) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_DOCENTE_EXISTE_USUARIO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?) }");
            //cs.setInt("_id_usuario", adminAcad.getIdUsuario());
            cs.setString("_dni", docente.getDNI());
            cs.setString("_nombre", docente.getNombre());
            cs.setString("_apellido_paterno", docente.getApellidoPaterno());
            cs.setString("_apellido_materno", docente.getApellidoMaterno());
            cs.setBytes("_foto", docente.getFoto());
            cs.setString("_correo", docente.getCorreo());
            cs.setString("_genero", docente.getGenero());
            cs.setString("_telefono", docente.getTelefono());
            cs.setString("_contrasenha", docente.getContrasenha());
            cs.setString("_direccion", docente.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(docente.getFechaNacimiento().getTime()));
            cs.setDate("_fecha_contratacion", new java.sql.Date(docente.getFechaContratacion().getTime()));
            cs.setDouble("_salario", docente.getSalario());
            cs.setString("_especialidad", docente.getEspecialidad());
             // Establecer el parámetro "_id_usuario" después de establecer los demás parámetros
            cs.setInt("_id_usuario", docente.getIdUsuario());
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
    public String obtenerNombre(int idDocente) {
        String nombreCompleto = "";
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_NOMBRE_DOCENTE(?)}");
            cs.setInt("_id_docente", idDocente);
            rs = cs.executeQuery();
            if(rs.next()){
                nombreCompleto = rs.getString("nombrecompleto");
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return nombreCompleto;
    }
    
}
