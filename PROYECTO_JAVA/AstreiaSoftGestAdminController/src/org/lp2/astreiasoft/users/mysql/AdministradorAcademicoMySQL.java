package org.lp2.astreiasoft.users.mysql;

import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.AdministradorAcademico;
import java.sql.Connection;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.CallableStatement;
//import static java.sql.Types.INTEGER;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.users.dao.AdministradorAcademicoDAO;

public class AdministradorAcademicoMySQL implements AdministradorAcademicoDAO {
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(AdministradorAcademico adminAcad) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ADMINISTRADOR_ACADEMICO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_administrador_academico", java.sql.Types.INTEGER);
            cs.registerOutParameter("_id_usuario_rol", java.sql.Types.INTEGER);
            cs.setString("_dni", adminAcad.getDNI());
            cs.setString("_nombre", adminAcad.getNombre());
            cs.setString("_apellido_paterno", adminAcad.getApellidoPaterno());
            cs.setString("_apellido_materno", adminAcad.getApellidoMaterno());
            cs.setBytes("_foto", adminAcad.getFoto());
            cs.setString("_correo", adminAcad.getCorreo());
            cs.setString("_genero", adminAcad.getGenero());
            cs.setString("_telefono", adminAcad.getTelefono());
            cs.setString("_contrasenha", adminAcad.getContrasenha());
            cs.setString("_direccion", adminAcad.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(adminAcad.getFechaNacimiento().getTime()));
            cs.setDate("_fecha_contratacion", new java.sql.Date(adminAcad.getFechaContratacion().getTime()));
            cs.setDouble("_salario", adminAcad.getSalario());
            cs.setString("_experiencia", adminAcad.getExperiencia());
            resultado = cs.executeUpdate();
            adminAcad.setIdUsuario(cs.getInt("_id_administrador_academico"));
            int idUsuarioROl= cs.getInt("_id_usuario_rol");
            
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
    public int modificar(AdministradorAcademico adminAcad) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ADMINISTRADOR_ACADEMICO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_administrador_academico", adminAcad.getIdUsuario());
            cs.setString("_dni", adminAcad.getDNI());
            cs.setString("_nombre", adminAcad.getNombre());
            cs.setString("_apellido_paterno", adminAcad.getApellidoPaterno());
            cs.setString("_apellido_materno", adminAcad.getApellidoMaterno());
            cs.setBytes("_foto", adminAcad.getFoto());
            cs.setString("_correo", adminAcad.getCorreo());
            cs.setString("_genero", adminAcad.getGenero());
            cs.setString("_telefono", adminAcad.getTelefono());
            cs.setString("_contrasenha", adminAcad.getContrasenha());
            cs.setString("_direccion", adminAcad.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(adminAcad.getFechaNacimiento().getTime()));
            cs.setDate("_fecha_contratacion", new java.sql.Date(adminAcad.getFechaContratacion().getTime()));
            cs.setDouble("_salario", adminAcad.getSalario());
            cs.setString("_experiencia", adminAcad.getExperiencia());
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
    public int eliminar(int idAdminAcad) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_ADMINISTRADOR_ACADEMICO(?)");
            cs.setInt("_id_administrador_academico", idAdminAcad);
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
    public ArrayList<AdministradorAcademico> listarTodos(String nombreDNI) {
        ArrayList<AdministradorAcademico> adminAcads = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ADMINISTRADORES_ACADEMICOS(?)}");
            cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while (rs.next()) {
                AdministradorAcademico adminAcad = new AdministradorAcademico();
                adminAcad.setIdUsuario(rs.getInt("id_usuario"));
                adminAcad.setDNI(rs.getString("dni"));
                adminAcad.setNombre(rs.getString("nombre"));
                adminAcad.setApellidoPaterno(rs.getString("apellido_paterno"));
                adminAcad.setApellidoMaterno(rs.getString("apellido_materno"));
                adminAcad.setFoto(rs.getBytes("foto"));
                adminAcad.setCorreo(rs.getString("correo"));
                adminAcad.setGenero(rs.getString("genero"));
                adminAcad.setTelefono(rs.getString("telefono"));
                adminAcad.setContrasenha(rs.getString("contrasenha"));
                adminAcad.setDireccion(rs.getString("direccion"));
                adminAcad.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                adminAcad.setFechaRegistro(rs.getDate("fecha_registro"));
                adminAcad.setFechaContratacion(rs.getDate("fecha_contratacion"));
                adminAcad.setSalario(rs.getDouble("salario"));
                adminAcad.setExperiencia(rs.getString("experiencia"));
                adminAcads.add(adminAcad);
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
        return adminAcads;
    }

    @Override
    public int insertarUsuarioExiste(AdministradorAcademico adminAcad) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ADMINISTRADOR_ACADEMICO_EXISTE_USUARIO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?) }");
            //cs.setInt("_id_usuario", adminAcad.getIdUsuario());
            cs.setString("_dni", adminAcad.getDNI());
            cs.setString("_nombre", adminAcad.getNombre());
            cs.setString("_apellido_paterno", adminAcad.getApellidoPaterno());
            cs.setString("_apellido_materno", adminAcad.getApellidoMaterno());
            cs.setBytes("_foto", adminAcad.getFoto());
            cs.setString("_correo", adminAcad.getCorreo());
            cs.setString("_genero", adminAcad.getGenero());
            cs.setString("_telefono", adminAcad.getTelefono());
            cs.setString("_contrasenha", adminAcad.getContrasenha());
            cs.setString("_direccion", adminAcad.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(adminAcad.getFechaNacimiento().getTime()));
            cs.setDate("_fecha_contratacion", new java.sql.Date(adminAcad.getFechaContratacion().getTime()));
            cs.setDouble("_salario", adminAcad.getSalario());
            cs.setString("_experiencia", adminAcad.getExperiencia());
             // Establecer el parámetro "_id_usuario" después de establecer los demás parámetros
            cs.setInt("_id_usuario", adminAcad.getIdUsuario());
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
    
    
}