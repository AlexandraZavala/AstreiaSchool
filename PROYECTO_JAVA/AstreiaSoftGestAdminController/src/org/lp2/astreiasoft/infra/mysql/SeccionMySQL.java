package org.lp2.astreiasoft.infra.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Types;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.dao.SeccionDAO;
import org.lp2.astreiasoft.infra.model.Aula;
import org.lp2.astreiasoft.infra.model.EstadoAula;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;
import org.lp2.astreiasoft.infra.model.Seccion;

/**
 *
 * @author mezav
 */
public class SeccionMySQL implements SeccionDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Seccion seccion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_SECCION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_seccion", java.sql.Types.INTEGER);

            cs.setInt("_fid_grado", seccion.getGrado().getIdGrado());
            cs.setBytes("_imagen", seccion.getImagen());
            cs.setString("_nombre_seccion", seccion.getNombre());
            cs.setInt("_anho", seccion.getAnho());
            seccion.setActivo(true);

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
    public int modificar(Seccion seccion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_SECCION(?,?,?,?,?,?)}");
            cs.setInt("_id_seccion", seccion.getIdSeccion());
            cs.setBytes("_imagen", seccion.getImagen());
            cs.setInt("_fid_grado", seccion.getGrado().getIdGrado());
            if (seccion.getAula() == null ) {
                cs.setNull("_fid_aula", Types.INTEGER);
            } else {
                cs.setInt("_fid_aula", seccion.getAula().getIdAula());
            }
            cs.setString("_nombre_seccion", seccion.getNombre());
            cs.setInt("_anho", seccion.getAnho());
            /*
            rs = cs.executeQuery();
            if(rs.next()){
                resultado = rs.getInt("id_seccion");
            }*/
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
    public int eliminar(int idSeccion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_SECCION(?)}");
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

    @Override
    public ArrayList<Seccion> listarTodas() {
        ArrayList<Seccion> secciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_SECCIONES()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Seccion seccion = new Seccion();
                seccion.setIdSeccion(rs.getInt("id_seccion"));
                seccion.setImagen(rs.getBytes("imagen"));

                seccion.setGrado(new Grado());
                seccion.getGrado().setIdGrado(rs.getInt("fid_grado"));
                seccion.getGrado().setNombre(rs.getString("nombre_grado"));
                seccion.getGrado().setNivel(NivelEducativo.valueOf(rs.getString("NivelEducativo")));

                seccion.setNombre(rs.getString("nombre_seccion"));
                seccion.setAnho(rs.getInt("anho"));
                //seccion.setActivo(rs.getBoolean("activo"));

                secciones.add(seccion);
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
        return secciones;
    }

    @Override
    public ArrayList<Seccion> listarSeccionesPorGrado(int idGrado) {
        ArrayList<Seccion> secciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call SECCIONES_X_ID_GRADO(?)}");
            cs.setInt("_id_grado", idGrado);
            rs = cs.executeQuery();
            while (rs.next()) {
                Seccion seccion = new Seccion();
                seccion.setIdSeccion(rs.getInt("id_seccion"));
                seccion.setImagen(rs.getBytes("imagen"));

                seccion.setGrado(new Grado());
                seccion.getGrado().setIdGrado(rs.getInt("fid_grado"));
                seccion.getGrado().setNombre(rs.getString("nombre_grado"));
                seccion.getGrado().setNivel(NivelEducativo.valueOf(rs.getString("NivelEducativo")));

                seccion.setNombre(rs.getString("nombre_seccion"));
                seccion.setAnho(rs.getInt("anho"));
                //seccion.setActivo(rs.getBoolean("activo"));

                secciones.add(seccion);
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
        return secciones;
    }

    @Override
    public int asignarAulaXSeccion(int idSeccion, int idAula) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ASIGNAR_AULA_SECCION(?,?)}");
            cs.setInt("_id_seccion", idSeccion);
            cs.setInt("_id_aula", idAula);

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
    public int verificarAula(int idAula) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_AULAS_ASIGNADAS(?)}");
            cs.setInt("_id_aula", idAula);
            rs = cs.executeQuery();

            if(rs.next()){
                resultado = rs.getInt("id_seccion");
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
    public ArrayList<Seccion> listarAulasDetalle(String nombreAula) {
        ArrayList<Seccion> secciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AULAS_DETALLE(?)}");
            cs.setString("_nombreAula", nombreAula);
            rs = cs.executeQuery();
            while (rs.next()) {

                Aula aula = new Aula();
                aula.setIdAula(rs.getInt("id_aula"));
                aula.setNombre(rs.getString("aula_nombre"));
                aula.setCapacidad(rs.getInt("aula_capacidad"));
                aula.setCodigo(rs.getString("aula_codigo"));

                Seccion seccion = new Seccion();
                seccion.setIdSeccion(rs.getInt("id_seccion"));
                seccion.setImagen(rs.getBytes("seccion_imagen"));
                seccion.setNombre(rs.getString("nombre_seccion"));
                seccion.setAnho(rs.getInt("seccion_anho"));
                seccion.setActivo(rs.getBoolean("seccion_estado"));

                seccion.setAula(aula);

                Grado grado = new Grado();
                grado.setIdGrado(rs.getInt("id_grado"));
                grado.setNombreCompleto(rs.getString("grado_nombre"));

                String nivelEducativo = rs.getString("NivelEducativo");
                if (nivelEducativo != null) {
                    grado.setNivel(NivelEducativo.valueOf(nivelEducativo));
                } else {
                    grado.setNivel(null); // Or set to a default value if needed
                }

                grado.setFechaCreacion(rs.getDate("grado_fecha_crea"));

                if (grado != null) {
                    seccion.setGrado(grado);
                }

                secciones.add(seccion);
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
        return secciones;
    }
    @Override
    public ArrayList<Integer> listarEstPorSeccion(int idSeccion) {
        ArrayList<Integer> idsEstudiante = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ID_ESTUDIANTEXSECCION(?)}");
            cs.setInt("_id_seccion", idSeccion);
            rs = cs.executeQuery();

            while (rs.next()) {
                int idEstudiante = rs.getInt("id_estudiante");
                idsEstudiante.add(idEstudiante);
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
        return idsEstudiante;
    }
}
