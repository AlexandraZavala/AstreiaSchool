/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.lp2.astreiasoft.admin.mysql;

import java.sql.Connection;
import java.sql.SQLException;
import java.sql.CallableStatement;
import java.util.ArrayList;
import java.util.function.Function;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.lp2.astreiasoft.admin.dao.InscripcionDAO;
import org.lp2.astreiasoft.admin.model.Inscripcion;
import org.lp2.astreiasoft.config.DBManager;
import java.sql.ResultSet;
import java.sql.Types;
import org.lp2.astreiasoft.admin.model.Matricula;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.users.model.Estudiante;
import org.lp2.astreiasoft.users.model.Usuario;


/**
 *
 * @author ricardomelendez
 */
public class InscripcionMySQL implements InscripcionDAO {
    
    private Connection obtenerConexion() throws SQLException {
        return DBManager.getInstance().getConnection();
    }

    private <T> T ejecutarEnConexion(Function<Connection, T> function) {
        Connection con = null;
        try {
            con = obtenerConexion();
            return function.apply(con);
        } catch (SQLException e) {
            System.out.println(e.getMessage());
            return null;
        } finally {
            if (con != null) {
                try {
                    con.close();
                } catch (SQLException ex) {
                    Logger.getLogger(AsistenciaMySQL.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }

    @Override
    public int insertar(Inscripcion inscripcion) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call INSERTAR_INSCRIPCION(?, ?, ?, ?, ?)}");
                cs.setBytes(1, inscripcion.getImagen());
                cs.setInt(2, inscripcion.getEstudiante().getIdUsuario());
                cs.setInt(3, inscripcion.getPadre().getIdUsuario());
                cs.setBoolean(4, inscripcion.getEsNuevo());
                cs.registerOutParameter(5, Types.INTEGER); // Cambio en el índice
                cs.execute();
                return cs.getInt(5);
            } catch (SQLException e) {
                e.printStackTrace();
                throw new RuntimeException("Error al insertar inscripción: " + e.getMessage(), e);
            }
        });
    }

    @Override
    public int modificar(Inscripcion inscripcion) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call ACTUALIZAR_ESTADO_INSCRIPCION(?, ?, ?, ?, ?)}");
                cs.setInt(1, inscripcion.getIdInscripcion());
                cs.setInt(2, inscripcion.getEstudiante().getIdUsuario());
                cs.setString(3, inscripcion.getEstado());
                cs.setBoolean(4, inscripcion.getEstudiante().isActivo());

                // Comprobación de null antes de obtener el ID del grado
                if (inscripcion.getEstudiante().getGrado() != null) {
                    cs.setInt(5, inscripcion.getEstudiante().getGrado().getIdGrado());
                } else {
                    // Si grado es null, puedes configurar un valor predeterminado o NULL
                    cs.setNull(5, Types.INTEGER); // Asumiendo que el ID del grado es de tipo INTEGER
                }

                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }



    
    @Override
    public int actualizarInscripcion(Inscripcion inscripcion) {  // Asumo que tu clase Estudiante en realidad es Usuario
        return ejecutarEnConexion(con -> {
            int resultado = 0;
            try {
                CallableStatement cs = con.prepareCall("{call ACTUALIZAR_INSCRIPCION(?,?,?,?,?,?,?,?,?,?,?,?)}");

                // Seteando los parámetros IN para la inscripción
                cs.setInt("_id_inscripcion", inscripcion.getIdInscripcion());
                cs.setInt("_id_estudiante", inscripcion.getEstudiante().getIdUsuario());  // Asumo que getEstudiante retorna un Usuario
                cs.setString("_estado", inscripcion.getEstado());  // Suponiendo que Estado es un enum
                cs.setBytes("_imagen", inscripcion.getImagen());

                // Seteando los parámetros IN para el usuario (estudiante)
                cs.setString("_DNI", inscripcion.getEstudiante().getDNI());
                cs.setString("_nombre", inscripcion.getEstudiante().getNombre());
                cs.setString("_apellido_paterno", inscripcion.getEstudiante().getApellidoPaterno());
                cs.setString("_apellido_materno", inscripcion.getEstudiante().getApellidoMaterno());
                cs.setString("_genero", inscripcion.getEstudiante().getGenero());
                cs.setDate("_fecha_nacimiento", new java.sql.Date(inscripcion.getEstudiante().getFechaNacimiento().getTime()));  // Convertir java.util.Date a java.sql.Date
                cs.setString("_telefono", inscripcion.getEstudiante().getTelefono());
                cs.setString("_direccion", inscripcion.getEstudiante().getDireccion());

                cs.execute();
                resultado = 1;  // Si la operación fue exitosa, devolvemos 1
            } catch (SQLException ex) {
                ex.printStackTrace();
                return 0;
            }
            return resultado;
        });
    }



    

    @Override
    public int eliminar(int idInscripcion) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call ELIMINAR_INSCRIPCION(?)}");
                cs.setInt(1, idInscripcion);

                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }


    @Override
    public ArrayList<Inscripcion> listarTodas() {
        return ejecutarEnConexion(con -> {
            ArrayList<Inscripcion> inscripciones = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_TODAS_INSCRIPCIONES()}");
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    // Aquí se pueden obtener y setear los objetos Estudiante y Matricula si es necesario
                    // Por ahora, sólo setearemos los IDs para simplificar el ejemplo
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("fid_estudiante"));

                    Matricula matricula = new Matricula();
                    matricula.setIdMatricula(rs.getInt("fid_matricula"));

                    Inscripcion inscripcion = new Inscripcion(
                        rs.getDate("fecha"),
                        rs.getBytes("imagen"),
                        matricula,
                        estudiante
                    );
                    inscripcion.setIdInscripcion(rs.getInt("id_inscripcion"));
                    // Aquí añadimos el estado a la inscripción
                    inscripcion.setEstado(rs.getString("estado"));
                    inscripciones.add(inscripcion);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return inscripciones;
        });
    }

    
    @Override
    public ArrayList<Usuario> listarHijosDePadre(int idPadre) {
        return ejecutarEnConexion(con -> {
            ArrayList<Usuario> hijos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call ListarHijosDePadre(?)}");
                cs.setInt(1, idPadre);  // Establecemos el ID del padre como parámetro
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Usuario hijo = new Estudiante();
                    hijo.setIdUsuario(rs.getInt("id_usuario"));
                    hijo.setDNI(rs.getString("dni"));
                    hijo.setNombre(rs.getString("nombre"));
                    hijo.setApellidoPaterno(rs.getString("apellido_paterno"));
                    hijo.setApellidoMaterno(rs.getString("apellido_materno"));
                    hijo.setCorreo(rs.getString("correo"));
                    hijo.setGenero(rs.getString("genero"));
                    hijo.setTelefono(rs.getString("telefono"));
                    hijo.setDireccion(rs.getString("direccion"));
                    hijo.setFechaNacimiento(rs.getDate("fecha_nacimiento"));

                    hijos.add(hijo);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return hijos;
        });
    }
    
    @Override
    public int insertarEstudiante(Estudiante estudiante) {
        return ejecutarEnConexion(con -> {
            int resultado = 0;
            try {
                CallableStatement cs = con.prepareCall("{call INSERTAR_ESTUDIANTE_PRE_INSCRIPCION(?,?,?,?,?,?,?,?,?)}");

                // Registrando el parámetro OUT primero porque es el primero en la definición del procedure
                cs.registerOutParameter(1, Types.INTEGER); // <--- Cambio aquí, usando índice en lugar del nombre

                // Seteando los demás parámetros IN en el orden correcto
                cs.setString(2, estudiante.getDNI());
                cs.setString(3, estudiante.getNombre());
                cs.setString(4, estudiante.getApellidoPaterno());
                cs.setString(5, estudiante.getApellidoMaterno());
                cs.setString(6, estudiante.getGenero());
                cs.setString(7, estudiante.getTelefono());
                cs.setString(8, estudiante.getDireccion());
                cs.setDate(9, new java.sql.Date(estudiante.getFechaNacimiento().getTime()));

                cs.execute();
                int idEstudianteRecibido = cs.getInt(1); // <--- Cambio aquí, usando índice en lugar del nombre
                estudiante.setIdUsuario(idEstudianteRecibido);
                resultado = idEstudianteRecibido;
            } catch (SQLException ex) {
                ex.printStackTrace();
                return 0;
            }
            return resultado;
        });
    }
    
    @Override
    public int actualizarEstudiante(Estudiante estudiante) {
        return ejecutarEnConexion(con -> {
            int resultado = 0;
            try {
                CallableStatement cs = con.prepareCall("{call ACTUALIZAR_ESTUDIANTE(?,?,?,?,?,?,?,?,?)}");

                // Seteando los parámetros IN en el orden correcto
                cs.setInt("_id_estudiante", estudiante.getIdUsuario());
                cs.setString("_dni", estudiante.getDNI());
                cs.setString("_nombre", estudiante.getNombre());
                cs.setString("_apellido_paterno", estudiante.getApellidoPaterno());
                cs.setString("_apellido_materno", estudiante.getApellidoMaterno());
                cs.setString("_genero", estudiante.getGenero());
                cs.setString("_telefono", estudiante.getTelefono());
                cs.setString("_direccion", estudiante.getDireccion());
                cs.setDate("_fecha_nacimiento", new java.sql.Date(estudiante.getFechaNacimiento().getTime()));

                cs.execute();
                resultado = estudiante.getIdUsuario();
            } catch (SQLException ex) {
                ex.printStackTrace();
                return 0;
            }
            return resultado;
        });
    }
    
    
    @Override
    public ArrayList<Inscripcion> listarPorPadre(int idPadre) {
        return ejecutarEnConexion(con -> {
            ArrayList<Inscripcion> inscripciones = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_PREINSCRIPCIONES_POR_PADRE(?)}");
                cs.setInt(1, idPadre);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("EstudianteID"));
                    estudiante.setDNI(rs.getString("DNI"));
                    estudiante.setNombre(rs.getString("Nombre"));
                    estudiante.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                    estudiante.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                    estudiante.setFoto(rs.getBytes("Foto"));
                    estudiante.setCorreo(rs.getString("Correo"));
                    estudiante.setGenero(rs.getString("Genero"));
                    estudiante.setTelefono(rs.getString("Telefono"));
                    estudiante.setDireccion(rs.getString("Direccion"));
                    estudiante.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                    estudiante.setFechaRegistro(rs.getDate("FechaRegistro"));
                    estudiante.setActivo(rs.getBoolean("Activo")); // Assuming `activo` is a boolean in the Estudiante Java class

                    //Matricula matricula = new Matricula();
                    //matricula.setIdMatricula(rs.getInt("fid_matricula"));

                    Inscripcion inscripcion = new Inscripcion();
                    inscripcion.setIdInscripcion(rs.getInt("ID"));
                    inscripcion.setFecha(rs.getDate("FechaPreinscripcion"));
                    inscripcion.setImagen(rs.getBytes("imagen"));
                    inscripcion.setEstudiante(estudiante);
                    inscripcion.setEstado(rs.getString("Estado"));
                    inscripcion.setPeriodoAcademico(rs.getString("PeriodoAcademico"));
                    inscripcion.setEsNuevo(rs.getBoolean("esNuevo"));
                    inscripciones.add(inscripcion);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return inscripciones;
        });
    }


    @Override
    public ArrayList<Inscripcion> listarPorPadreEstudiante(int idPadre, int idEstudiante) {
        return ejecutarEnConexion(con -> {
            ArrayList<Inscripcion> inscripciones = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_PREINSCRIPCIONES_POR_PADRE_ESTUDIANTE(?,?)}");
                cs.setInt(1, idPadre);
                cs.setInt(2, idEstudiante);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("EstudianteID"));
                    estudiante.setDNI(rs.getString("DNI"));
                    estudiante.setNombre(rs.getString("Nombre"));
                    estudiante.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                    estudiante.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                    estudiante.setFoto(rs.getBytes("Foto"));
                    estudiante.setCorreo(rs.getString("Correo"));
                    estudiante.setGenero(rs.getString("Genero"));
                    estudiante.setTelefono(rs.getString("Telefono"));
                    estudiante.setDireccion(rs.getString("Direccion"));
                    estudiante.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                    estudiante.setFechaRegistro(rs.getDate("FechaRegistro"));
                    estudiante.setActivo(rs.getBoolean("Activo"));

                    Inscripcion inscripcion = new Inscripcion();
                    inscripcion.setIdInscripcion(rs.getInt("ID"));
                    inscripcion.setFecha(rs.getDate("FechaPreinscripcion"));
                    inscripcion.setImagen(rs.getBytes("imagen"));
                    inscripcion.setEstudiante(estudiante);
                    inscripcion.setEstado(rs.getString("Estado"));
                    inscripcion.setPeriodoAcademico(rs.getString("PeriodoAcademico"));
                    inscripcion.setEsNuevo(rs.getBoolean("esNuevo"));
                    inscripciones.add(inscripcion);
                }

                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return inscripciones;
        });
    }
    
    @Override
    public ArrayList<Inscripcion> listarPreinscripciones() {
        return ejecutarEnConexion(con -> {
            ArrayList<Inscripcion> inscripciones = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_PREINSCRIPCIONES()}");
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("EstudianteID"));
                    estudiante.setDNI(rs.getString("DNI"));
                    estudiante.setNombre(rs.getString("Nombre"));
                    estudiante.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                    estudiante.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                    estudiante.setFoto(rs.getBytes("Foto"));
                    estudiante.setCorreo(rs.getString("Correo"));
                    estudiante.setGenero(rs.getString("Genero"));
                    estudiante.setTelefono(rs.getString("Telefono"));
                    estudiante.setDireccion(rs.getString("Direccion"));
                    estudiante.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                    estudiante.setFechaRegistro(rs.getDate("FechaRegistro"));
                    estudiante.setActivo(rs.getBoolean("Activo"));
                    
                    Grado grado = new Grado();
                    grado.setIdGrado(rs.getInt("IdGrado"));
                    grado.setNombreCompleto(rs.getString("NombreCompletoGrado"));
                    estudiante.setGrado(grado);

                    Inscripcion inscripcion = new Inscripcion();
                    inscripcion.setIdInscripcion(rs.getInt("ID"));
                    inscripcion.setFecha(rs.getDate("FechaPreinscripcion"));
                    inscripcion.setImagen(rs.getBytes("imagen"));
                    inscripcion.setEstudiante(estudiante);
                    inscripcion.setEstado(rs.getString("Estado"));
                    inscripcion.setPeriodoAcademico(rs.getString("PeriodoAcademico"));
                    inscripcion.setEsNuevo(rs.getBoolean("esNuevo"));
                    inscripciones.add(inscripcion);
                }

                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return inscripciones;
        });
    }
    
    @Override
    public ArrayList<Inscripcion> listarPreinscripcionesPorEstado(String estado) {
        return ejecutarEnConexion(con -> {
            ArrayList<Inscripcion> inscripciones = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_PREINSCRIPCIONES_POR_ESTADO(?)}");
                cs.setString(1, estado);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Estudiante estudiante = new Estudiante();
                    estudiante.setIdUsuario(rs.getInt("EstudianteID"));
                    estudiante.setDNI(rs.getString("DNI"));
                    estudiante.setNombre(rs.getString("Nombre"));
                    estudiante.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                    estudiante.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                    estudiante.setFoto(rs.getBytes("Foto"));
                    estudiante.setCorreo(rs.getString("Correo"));
                    estudiante.setGenero(rs.getString("Genero"));
                    estudiante.setTelefono(rs.getString("Telefono"));
                    estudiante.setDireccion(rs.getString("Direccion"));
                    estudiante.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                    estudiante.setFechaRegistro(rs.getDate("FechaRegistro"));
                    estudiante.setActivo(rs.getBoolean("Activo"));
                    
                    Grado grado = new Grado();
                    grado.setIdGrado(rs.getInt("IdGrado"));
                    grado.setNombreCompleto(rs.getString("NombreCompletoGrado"));
                    estudiante.setGrado(grado);

                    Inscripcion inscripcion = new Inscripcion();
                    inscripcion.setIdInscripcion(rs.getInt("ID"));
                    inscripcion.setFecha(rs.getDate("FechaPreinscripcion"));
                    inscripcion.setImagen(rs.getBytes("imagen"));
                    inscripcion.setEstudiante(estudiante);
                    inscripcion.setEstado(rs.getString("Estado"));
                    inscripcion.setPeriodoAcademico(rs.getString("PeriodoAcademico"));
                    inscripcion.setEsNuevo(rs.getBoolean("esNuevo"));
                    inscripciones.add(inscripcion);
                }

                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return inscripciones;
        });
    }

    @Override
    public ArrayList<Grado> listarGradosActivos() {
        return ejecutarEnConexion(con -> {
            ArrayList<Grado> grados = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_GRADOS_ACTIVOS()}");
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Grado grado = new Grado();
                    grado.setIdGrado(rs.getInt("id_grado"));
                    grado.setNombreCompleto(rs.getString("nombre_completop"));
                    grado.setFechaCreacion(rs.getDate("fecha_creacion"));
                    grado.setActivo(rs.getBoolean("activo"));

                    grados.add(grado);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return grados;
        });
    }

    


}
