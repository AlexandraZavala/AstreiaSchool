
package org.lp2.astreiasoft.users.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.users.dao.UsuarioDAO;
import org.lp2.astreiasoft.users.model.Usuario;

/**
 *
 * @author adida
 */
public class UsuarioMySQL implements UsuarioDAO{

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public Usuario Encontrar(String IdDNI) {
          
        Usuario usuario = new Usuario();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ENCONTRAR_USUARIO(?)}");
            cs.setString("_IdDNI", IdDNI);
            rs = cs.executeQuery();
            if (rs.next()) {
                usuario.setIdUsuario(rs.getInt("id_usuario"));
                usuario.setDNI(rs.getString("dni"));
                usuario.setNombre(rs.getString("nombre"));
                usuario.setApellidoPaterno(rs.getString("apellido_paterno"));
                usuario.setApellidoMaterno(rs.getString("apellido_materno"));
                usuario.setFoto(rs.getBytes("foto"));
                usuario.setCorreo(rs.getString("correo"));
                usuario.setGenero(rs.getString("genero"));
                usuario.setTelefono(rs.getString("telefono"));
                usuario.setContrasenha(rs.getString("contrasenha"));
                usuario.setDireccion(rs.getString("direccion"));
                usuario.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
            } else {
                usuario = null;
            }
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return usuario;
    }
    @Override
    public int verificarUsuario(String correo, String password) {
        int resultado=0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_USUARIO(?,?)}");
            cs.setString("_correo", correo);
            cs.setString("_contrasenha", password);
            rs = cs.executeQuery();
           if (rs.next()) {
                resultado = rs.getInt("id_usuario");
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
        return resultado;
    }

    @Override
    public int editar(Usuario usuario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call EDITAR_PERFIL(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_usuario",usuario.getIdUsuario());
            cs.setString("_dni",usuario.getDNI());
            cs.setString("_nombre", usuario.getNombre());
            cs.setString("_apellido_paterno", usuario.getApellidoPaterno());
            cs.setString("_apellido_materno", usuario.getApellidoMaterno());
            cs.setBytes("_foto", usuario.getFoto());
            cs.setString("_genero", String.valueOf(usuario.getGenero()));
            cs.setString("_telefono", usuario.getTelefono());
            cs.setString("_direccion", usuario.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(usuario.getFechaNacimiento().getTime()));   
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int asignarRolUsuario(Usuario usuario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ASIGNAR_ROL_USUARIO(?,?,?)}");
            cs.registerOutParameter("_id_usuario_rol", INTEGER);
            cs.setInt("_fid_usuario", usuario.getIdUsuario());
            cs.setInt("_fid_rol",usuario.getRol().getIdRol());
            cs.executeUpdate();
            //suario.setUsuario(cs.getInt("_id_estudiante"));
            resultado = cs.getInt("_id_usuario_rol");
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
}
