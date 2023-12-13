package org.lp2.astreiasoft.users.mysql;

import static java.sql.Types.INTEGER;
import org.lp2.astreiasoft.users.dao.EstudianteDAO;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.Estudiante;
import java.sql.Connection;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.CallableStatement;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;
import org.lp2.astreiasoft.infra.model.Seccion;

public class EstudianteMySQL implements EstudianteDAO {

    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Estudiante estudiante) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ESTUDIANTE(?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_estudiante", INTEGER);
            cs.registerOutParameter("_id_usuario_rol", INTEGER);
            cs.setString("_dni", estudiante.getDNI());
            cs.setString("_nombre", estudiante.getNombre());
            cs.setString("_apellido_paterno", estudiante.getApellidoPaterno());
            cs.setString("_apellido_materno", estudiante.getApellidoMaterno());
            cs.setBytes("_foto", estudiante.getFoto());
            cs.setString("_correo", estudiante.getCorreo());
            cs.setString("_genero", estudiante.getGenero());
            cs.setString("_telefono", estudiante.getTelefono());
            cs.setString("_contrasenha", estudiante.getContrasenha());
            cs.setString("_direccion", estudiante.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(estudiante.getFechaNacimiento().getTime()));
            //cs.setInt("_anho_ingreso", new java.sql.Date(estudiante.getAnhoIngreso().getTime()));
            //resultado = cs.executeUpdate();
            cs.execute();
            estudiante.setIdUsuario(cs.getInt("_id_estudiante"));
            int idUsuarioROl= cs.getInt("_id_usuario_rol");
            resultado = estudiante.getIdUsuario();
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
    public int modificar(Estudiante estudiante) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ESTUDIANTE(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_estudiante", estudiante.getIdUsuario());
            cs.setString("_dni", estudiante.getDNI());
            cs.setString("_nombre", estudiante.getNombre());
            cs.setString("_apellido_paterno", estudiante.getApellidoPaterno());
            cs.setString("_apellido_materno", estudiante.getApellidoMaterno());
            cs.setBytes("_foto", estudiante.getFoto());
            cs.setString("_correo", estudiante.getCorreo());
            cs.setString("_genero", estudiante.getGenero());
            cs.setString("_telefono", estudiante.getTelefono());
            cs.setString("_contrasenha", estudiante.getContrasenha());
            cs.setString("_direccion", estudiante.getDireccion());
            cs.setDate("_fecha_nacimiento", new java.sql.Date(estudiante.getFechaNacimiento().getTime()));
            cs.executeUpdate();

            return estudiante.getIdUsuario();
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
    public int eliminar(int idEstudiante) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_ESTUDIANTE(?)");
            cs.setInt("_id_estudiante", idEstudiante);
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
    public ArrayList<Estudiante> listarTodos(String nombreDNI) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESTUDIANTES(?)}");
            cs.setString("_nombreDNI", nombreDNI);
            rs = cs.executeQuery();
            while (rs.next()) {
                Estudiante estudiante = new Estudiante();
                estudiante.setIdUsuario(rs.getInt("id_usuario"));
                estudiante.setDNI(rs.getString("dni"));
                estudiante.setNombre(rs.getString("nombre"));
                estudiante.setApellidoPaterno(rs.getString("apellido_paterno"));
                estudiante.setApellidoMaterno(rs.getString("apellido_materno"));
                estudiante.setFoto(rs.getBytes("foto"));
                estudiante.setCorreo(rs.getString("correo"));
                estudiante.setGenero(rs.getString("genero"));
                estudiante.setTelefono(rs.getString("telefono"));
                estudiante.setContrasenha(rs.getString("contrasenha"));
                estudiante.setDireccion(rs.getString("direccion"));
                estudiante.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                estudiante.setFechaRegistro(rs.getDate("fecha_registro"));

                //estudiante.setAnhoIngreso(rs.getDate("anho_ingreso"));
                estudiante.setActivo(true);
                estudiantes.add(estudiante);
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
        return estudiantes;
    }

    //FRANK
    public ArrayList<Estudiante> listarEstudianteXGrado(int idGrado) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESTUDIANTE_X_GRADO(?)}");
            cs.setInt("_id_grado", idGrado);
            rs = cs.executeQuery();
            while (rs.next()) {
                Estudiante estudiante = new Estudiante();
                estudiante.setIdEstudiante(rs.getInt("id_usuario"));
                estudiante.setDNI(rs.getString("dni"));
                estudiante.setNombre(rs.getString("nombre"));
                estudiante.setApellidoPaterno(rs.getString("apellido_paterno"));
                estudiante.setApellidoMaterno(rs.getString("apellido_materno"));
                estudiante.setFoto(rs.getBytes("foto"));
                estudiante.setCorreo(rs.getString("correo"));
                estudiante.setGenero(rs.getString("genero"));
                estudiante.setTelefono(rs.getString("telefono"));
                estudiante.setDireccion(rs.getString("direccion"));
                estudiante.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                estudiante.setFechaRegistro(rs.getDate("fecha_registro"));

                // Verifica si el Grado es null
                int idGrad = rs.getInt("id_grado");
                if (!rs.wasNull()) {
                    estudiante.setGrado(new Grado());
                    estudiante.getGrado().setIdGrado(idGrad);
                    estudiante.getGrado().setNombre(rs.getString("nombre_grado"));
                    estudiante.getGrado().setNivel(NivelEducativo.valueOf(rs.getString("NivelEducativo")));
                } else {
                    // Opcional: Configurar un Grado predeterminado o hacer otra cosa
                    estudiante.setGrado(null);
                }

                // Verifica si la Seccion es null
                int idSeccion = rs.getInt("id_seccion");
                if (!rs.wasNull()) {
                    estudiante.setSeccion(new Seccion());
                    estudiante.getSeccion().setIdSeccion(idSeccion);
                    estudiante.getSeccion().setImagen(rs.getBytes("imagen"));
                    estudiante.getSeccion().setNombre(rs.getString("nombre_seccion"));
                    estudiante.getSeccion().setAnho(rs.getInt("anho"));
                } else {
                    // Opcional: Configurar una Seccion predeterminada o hacer otra cosa
                    estudiante.setSeccion(null);
                }

                estudiantes.add(estudiante);
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
        return estudiantes;
    }

    public ArrayList<Estudiante> listarEstudiantesXSeccion(int idSeccion) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESTUDIANTES_X_SECCION(?)}");
            cs.setInt("_id_seccion", idSeccion);
            rs = cs.executeQuery();
            while (rs.next()) {
                Estudiante estudiante = new Estudiante();

                estudiante.setIdEstudiante(rs.getInt("id_usuario"));
                estudiante.setDNI(rs.getString("dni"));
                estudiante.setNombre(rs.getString("nombre"));
                estudiante.setApellidoPaterno(rs.getString("apellido_paterno"));
                estudiante.setApellidoMaterno(rs.getString("apellido_materno"));
                estudiante.setFoto(rs.getBytes("foto"));
                estudiante.setCorreo(rs.getString("correo"));
                estudiante.setGenero(rs.getString("genero"));
                estudiante.setTelefono(rs.getString("telefono"));
                estudiante.setDireccion(rs.getString("direccion"));
                estudiante.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                estudiante.setFechaRegistro(rs.getDate("fecha_registro"));

                // Verifica si el Grado es null
                int idGrad = rs.getInt("id_grado");
                if (!rs.wasNull()) {
                    estudiante.setGrado(new Grado());
                    estudiante.getGrado().setIdGrado(idGrad);
                    estudiante.getGrado().setNombre(rs.getString("nombre_grado"));
                    estudiante.getGrado().setNivel(NivelEducativo.valueOf(rs.getString("NivelEducativo")));
                } else {
                    // Opcional: Configurar un Grado predeterminado o hacer otra cosa
                    estudiante.setGrado(null);
                }

                // Verifica si la Seccion es null
                int idSec = rs.getInt("id_seccion");
                if (!rs.wasNull()) {
                    estudiante.setSeccion(new Seccion());
                    estudiante.getSeccion().setIdSeccion(idSec);
                    estudiante.getSeccion().setImagen(rs.getBytes("imagen"));
                    estudiante.getSeccion().setNombre(rs.getString("nombre_seccion"));
                    estudiante.getSeccion().setAnho(rs.getInt("anho"));
                } else {
                    // Opcional: Configurar una Seccion predeterminada o hacer otra cosa
                    estudiante.setSeccion(null);
                }

                estudiantes.add(estudiante);
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
        return estudiantes;
    }

    public int asignarSeccionAEstudiante(int idEstudiante, int idSeccion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ASIGNAR_SECCION_A_ESTUDIANTE(?,?)}");
            cs.setInt("_id_estudiante", idEstudiante);
            cs.setInt("_id_seccion", idSeccion);

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

    public int quitarSeccionDeEstudiante(int idEstudiante) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call QUITAR_SECCION_DE_ESTUDIANTE(?)}");
            cs.setInt("_id_estudiante", idEstudiante);

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
    
    public int obtenerSeccion(int idEstuduante){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_SECCION(?)}");
            cs.setInt("p_idUsuario", idEstuduante);
            
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
    public String obtenerNombre_Grado_Seccion(int idGrado, int idSeccion) {
        String nombre = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("CALL OBTENER_NOMBRE_GRADO_SECCION(?,?)");
            cs.setInt("p_id_grado", idGrado);
            cs.setInt("p_id_seccion", idSeccion);
            
            rs = cs.executeQuery();
            if (rs.next()) {
                nombre = rs.getString("nombre_grado_seccion");
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
}
