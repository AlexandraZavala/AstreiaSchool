package org.lp2.astreiasoft.users.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import static java.sql.JDBCType.INTEGER;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.dao.PadreFamiliaDAO;
import org.lp2.astreiasoft.users.model.PadreFamilia;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.users.model.Estudiante;

public class PadreFamiliaMySQL implements PadreFamiliaDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(PadreFamilia padreFamilia) {
        int resultado1 = 0, resultado2 = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PADRE_FAMILIA(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_padreFamilia", INTEGER);
            cs.registerOutParameter("_id_usuario_rol", INTEGER);
            cs.setString("_dni",padreFamilia.getDNI());
            cs.setString("_nombre", padreFamilia.getNombre());
            cs.setString("_apellido_paterno", padreFamilia.getApellidoPaterno());
            cs.setString("_apellido_materno", padreFamilia.getApellidoMaterno());
            cs.setBytes("_foto", padreFamilia.getFoto());
            cs.setString("_correo", padreFamilia.getCorreo());
            cs.setString("_genero", String.valueOf(padreFamilia.getGenero())); //es char
            cs.setString("_telefono", padreFamilia.getTelefono());
            cs.setString("_contrasenha", padreFamilia.getContrasenha());
            cs.setString("_direccion", padreFamilia.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(padreFamilia.getFechaNacimiento().getTime()));       
            cs.setInt("_numero_hijos", padreFamilia.getNumeroHijos());
            resultado1 = cs.executeUpdate();
            padreFamilia.setIdUsuario(cs.getInt("_id_padreFamilia")); 
            //para el usuario
            int idUsuarioROl= cs.getInt("_id_usuario_rol");
            
            //Para cada hijo
            for(Estudiante est : padreFamilia.getHijos()){
                cs = con.prepareCall("{call INSERTAR_HIJO_PADRE_FAMILIA(?,?,?)}");
                cs.registerOutParameter("_id_estudiante_padrefamilia", java.sql.Types.INTEGER);
                cs.setInt("_fid_estudiante", est.getIdUsuario());
                cs.setInt("_fid_padreFamilia", padreFamilia.getIdUsuario());
                cs.executeUpdate();
            }
            resultado2 = padreFamilia.getIdUsuario();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado2;
    }

    @Override
    public int modificar(PadreFamilia padreFamilia) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PADRE_FAMILIA(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_padreFamilia",padreFamilia.getIdUsuario());
            cs.setString("_dni",padreFamilia.getDNI());
            cs.setString("_nombre", padreFamilia.getNombre());
            cs.setString("_apellido_paterno", padreFamilia.getApellidoPaterno());
            cs.setString("_apellido_materno", padreFamilia.getApellidoMaterno());
            cs.setBytes("_foto", padreFamilia.getFoto());
            cs.setString("_correo", padreFamilia.getCorreo());
            cs.setString("_genero", String.valueOf(padreFamilia.getGenero())); //es char
            cs.setString("_telefono", padreFamilia.getTelefono());
            cs.setString("_contrasenha", padreFamilia.getContrasenha());
            cs.setString("_direccion", padreFamilia.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(padreFamilia.getFechaNacimiento().getTime()));       
            cs.setInt("_numero_hijos", padreFamilia.getNumeroHijos());
            cs.executeUpdate();
            
            for(Estudiante est : padreFamilia.getHijos()){
                cs = con.prepareCall("{call INSERTAR_HIJO_PADRE_FAMILIA(?,?,?)}");
                cs.registerOutParameter("_id_estudiante_padrefamilia", java.sql.Types.INTEGER);
                cs.setInt("_fid_estudiante", est.getIdUsuario());
                cs.setInt("_fid_padreFamilia", padreFamilia.getIdUsuario());
                cs.executeUpdate();
            }
            
            resultado = padreFamilia.getIdUsuario();
               
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idPadreFamilia) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PADRE_FAMILIA(?)}");
            cs.setInt("_id_padreFamilia",idPadreFamilia);
            
            resultado = cs.executeUpdate();
               
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<PadreFamilia> listarTodos(String nombreDNI) {
        ArrayList<PadreFamilia> padresFamilias = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PADRES_FAMILIA(?)}");
            cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while(rs.next()){
                PadreFamilia padreFamilia = new PadreFamilia();
                padreFamilia.setIdUsuario(rs.getInt("id_padreFamilia"));
                padreFamilia.setDNI(rs.getString("dni"));
                padreFamilia.setNombre(rs.getString("nombre"));
                padreFamilia.setApellidoPaterno(rs.getString("apellido_paterno"));
                padreFamilia.setApellidoMaterno(rs.getString("apellido_materno"));
                padreFamilia.setFoto(rs.getBytes("foto"));
                padreFamilia.setCorreo(rs.getString("direccion"));
                padreFamilia.setGenero(rs.getString("genero"));
                padreFamilia.setTelefono(rs.getString("telefono"));
                padreFamilia.setContrasenha(rs.getString("contrasenha"));
                padreFamilia.setDireccion(rs.getString("direccion"));
                padreFamilia.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                padreFamilia.setFechaRegistro(rs.getDate("fecha_registro"));
                padreFamilia.setNumeroHijos(rs.getInt("numero_hijos"));
                padreFamilia.setActivo(true);
                padresFamilias.add(padreFamilia);
                
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return padresFamilias;
    }

    @Override
    public int insertarUsuarioExiste(PadreFamilia padreFamilia) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_PADRE_FAMILIA_EXISTE_USUARIO(?,?,?,?,?,?,?,?,?,?,?,?,?) }");
            //cs.setInt("_id_usuario", adminAcad.getIdUsuario());
            cs.setString("_dni", padreFamilia.getDNI());
            cs.setString("_nombre", padreFamilia.getNombre());
            cs.setString("_apellido_paterno", padreFamilia.getApellidoPaterno());
            cs.setString("_apellido_materno", padreFamilia.getApellidoMaterno());
            cs.setBytes("_foto", padreFamilia.getFoto());
            cs.setString("_correo", padreFamilia.getCorreo());
            cs.setString("_genero", padreFamilia.getGenero());
            cs.setString("_telefono", padreFamilia.getTelefono());
            cs.setString("_contrasenha", padreFamilia.getContrasenha());
            cs.setString("_direccion", padreFamilia.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(padreFamilia.getFechaNacimiento().getTime()));
            cs.setInt("_numero_hijos", padreFamilia.getNumeroHijos());
             // Establecer el parámetro "_id_usuario" después de establecer los demás parámetros
            cs.setInt("_id_usuario", padreFamilia.getIdUsuario());
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
    public ArrayList<Estudiante> listarEstudiantesXPadre(PadreFamilia padreFamilia) {
        ArrayList<Estudiante> hijos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HIJOS_X_PADRE_FAMILIA(?)}");
            cs.setInt("_id_padreFamilia",padreFamilia.getIdUsuario());
            //cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while(rs.next()){
                Estudiante est = new Estudiante();
                est.setIdUsuario(rs.getInt("id_usuario"));
                est.setNombre(rs.getString("nombre"));
                est.setApellidoPaterno(rs.getString("apellido_paterno"));
                est.setApellidoMaterno(rs.getString("apellido_materno"));
                est.setNombreCompleto(est.getNombre() + " " + est.getApellidoMaterno() + " " + est.getApellidoPaterno());
                est.setCorreo(rs.getString("correo"));
                                
                est.setGrado(new Grado());
                est.getGrado().setIdGrado(rs.getInt("fid_grado"));
                
                est.setSeccion(new Seccion());
                est.getSeccion().setIdSeccion(rs.getInt("fid_seccion"));
                
                hijos.add(est);
                
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return hijos;
    }
    
}
