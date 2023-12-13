package org.lp2.astreiasoft.eval.mysql;
import java.sql.Blob;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.EvaluacionDAO;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Bimestre;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.EstadoEntrega;
import org.lp2.astreiasoft.eval.model.EvaluacionConEntrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
import org.lp2.astreiasoft.eval.model.TipoEvaluacion;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.users.model.Docente;

public class EvaluacionMySQL implements EvaluacionDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Evaluacion evaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_EVALUACION(?,?,?,?,?,?,?,?,?,?) }"); // Actualizar el número de parámetros
            cs.registerOutParameter("_id_evaluacion", Types.INTEGER);
            //cs.setString("_nombre", evaluacion.getNombre()); // Añadir parámetro para el nombre
            cs.setString("_descripcion", evaluacion.getDescripcion());
            cs.setInt("_fid_docente", evaluacion.getDocente().getIdUsuario());
            cs.setInt("_fid_bimestre", evaluacion.getBimestre().getIdBimestre());
            
            // Aquí usamos java.sql.Timestamp para preservar la información de la hora
            cs.setTimestamp("_fechaInicio", new java.sql.Timestamp(evaluacion.getFechaSubido().getTime()));
            cs.setTimestamp("_fechaFin", new java.sql.Timestamp(evaluacion.getFechaLimite().getTime()));
            
            cs.setDouble("_puntos_maximos", evaluacion.getNota());
            cs.setString("_TipoEvaluacion", evaluacion.getTipo().toString());
            cs.setInt("_fid_curso_programado", evaluacion.getCursoProgramado().getIdCursoProgramado());
            cs.setBoolean("_activo", true);
            resultado = cs.executeUpdate();
            evaluacion.setIdEvaluacion(cs.getInt("_id_evaluacion"));
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                if (cs != null) cs.close();
                if (con != null) con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Evaluacion evaluacion) {
        int resultado = 0;
        Connection con = null;
        CallableStatement cs = null;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ModificarEvaluacion(?,?,?,?,?,?,?) }");

            // Establecer los parámetros para la llamada al procedimiento
            cs.setInt("_id_evaluacion", evaluacion.getIdEvaluacion());
            cs.setInt("_fid_bimestre", evaluacion.getBimestre().getIdBimestre());
            cs.setString("_descripcion", evaluacion.getDescripcion());
            cs.setTimestamp("_fechaInicio", new java.sql.Timestamp(evaluacion.getFechaSubido().getTime()));
            cs.setTimestamp("_fechaFin", new java.sql.Timestamp(evaluacion.getFechaLimite().getTime()));
            cs.setDouble("_puntos_maximos", evaluacion.getNota());
            cs.setString("_TipoEvaluacion", evaluacion.getTipo().toString());

            // Ejecutar el procedimiento almacenado
            resultado = cs.executeUpdate();
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            // Cerrar los recursos de JDBC de manera segura
            try {
                if (cs != null) cs.close();
                if (con != null) con.close();
            } catch (SQLException ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idEvaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_EVALUACION(?)");
            cs.setInt("_id_evaluacion", idEvaluacion);
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
    public ArrayList<String> listarTiposEvaluacion() {
        ArrayList<String> tiposEvaluacion = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ListarTiposEvaluacion()}");
            ResultSet rs = cs.executeQuery();

            while (rs.next()) {
                // Asumiendo que el resultado es un solo string con los tipos separados por comas
                String tipos = rs.getString(1); // Obtiene el primer campo del resultado
                String[] tiposArray = tipos.replaceAll("enum\\('", "").replaceAll("'\\)", "").split("','");
                for (String tipo : tiposArray) {
                    tiposEvaluacion.add(tipo);
                }
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                if (con != null) con.close();
                if (cs != null) cs.close();
            } catch (SQLException ex) {
                System.out.println(ex.getMessage());
            }
        }
        return tiposEvaluacion;
    }

    @Override
    public ArrayList<Evaluacion> listarTodos() {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVALUACIONES_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setDescripcion(rs.getString("descripcion"));
                Docente docente = new Docente();
                docente.setIdUsuario(rs.getInt("fid_docente"));
                evaluacion.setDocente(docente);
                evaluacion.setFechaSubido(new Date(rs.getDate("fechaInicio").getTime()));
                evaluacion.setFechaSubido(new Date(rs.getDate("fechaFin").getTime()));
                evaluacion.setNota(rs.getDouble("puntos_maximos"));
                evaluacion.setTipo(TipoEvaluacion.valueOf(rs.getString("TipoEvaluacion")));
                Bimestre bimestre = new Bimestre();
                bimestre.setIdBimestre(rs.getInt("fid_bimestre"));
                evaluacion.setBimestre(bimestre);
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                evaluacion.setCursoProgramado(cursoProgramado);
                evaluacion.setActivo(rs.getBoolean("activo"));
                evaluaciones.add(evaluacion);
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
        return evaluaciones;
    }
    
    @Override
    public ArrayList<Evaluacion> listarEvaluacionesPorNombre(int idCursoProgramado, String nombreEvaluacion) {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVALUACIONES_POR_NOMBRE(?,?)}");
            cs.setInt(1, idCursoProgramado);
            cs.setString(2, nombreEvaluacion);
            rs = cs.executeQuery();
            while (rs.next()) {
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setNombre(rs.getString("nombre"));
                evaluacion.setDescripcion(rs.getString("descripcion"));
                // Asume que tienes una clase Docente y su respectivo setter en Evaluacion
                Docente docente = new Docente();
                docente.setIdUsuario(rs.getInt("fid_docente"));
                evaluacion.setDocente(docente);
                evaluacion.setFechaSubido(new java.util.Date(rs.getTimestamp("fechaInicio").getTime()));
                evaluacion.setFechaLimite(new java.util.Date(rs.getTimestamp("fechaFin").getTime()));
                evaluacion.setNota(rs.getDouble("puntos_maximos"));
                // Asume que tienes un enum o clase para TipoEvaluacion y su respectivo setter en Evaluacion
                evaluacion.setTipo(TipoEvaluacion.valueOf(rs.getString("TipoEvaluacion")));
                // Asume que tienes una clase CursoProgramado y su respectivo setter en Evaluacion
                CursoProgramado cursoProgramado = new CursoProgramado();
                cursoProgramado.setIdCursoProgramado(rs.getInt("fid_curso_programado"));
                evaluacion.setCursoProgramado(cursoProgramado);
                evaluacion.setActivo(rs.getBoolean("activo"));
                evaluaciones.add(evaluacion);
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            // Cerrar recursos de manera segura
            try { if (rs != null) rs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (cs != null) cs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (con != null) con.close(); } catch (SQLException e) { e.printStackTrace(); }
        }
        return evaluaciones;
    }
    
    public ArrayList<EvaluacionConEntrega> listarEvaluacionesConEntregasYUltimaNota(int idCursoProgramado, int idUsuario) {
        ArrayList<EvaluacionConEntrega> lista = new ArrayList<>();
        Connection con = null;
        CallableStatement cs = null;
        ResultSet rs = null;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVALUACIONES_CON_ENTREGAS_Y_ULTIMA_NOTA(?,?)}");
            cs.setInt(1, idCursoProgramado);
            cs.setInt(2, idUsuario);
            rs = cs.executeQuery();

            while (rs.next()) {
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setNombre(rs.getString("Nombre Evaluacion"));
                evaluacion.setTipo(TipoEvaluacion.valueOf(rs.getString("TipoEvaluacion")));
                evaluacion.setFechaSubido(rs.getTimestamp("Fecha de Inicio"));
                evaluacion.setFechaLimite(rs.getTimestamp("Fecha de Fin"));
                                                //Porque no getDate
                
                Entrega entrega;
                if (rs.getString("Estado").equals("Sin Entregar")) {
                    // No crear un objeto Entrega si no hay entrega
                    entrega = null;
                } else {
                    // Crear el objeto Entrega y llenar sus datos
                    entrega = new Entrega();
                    entrega.setIdEntrega(rs.getInt("ID Entrega")); // Esto es seguro porque ya sabemos que hay una entrega

                    // Si hay una entrega, los siguientes campos no deberían ser NULL
       //             entrega.setEstado(EstadoEntrega.valueOf(rs.getString("Estado")));
       //             entrega.setFechaEntrega(rs.getTimestamp("Fecha de Entrega"));
       //             entrega.setObservaciones(rs.getString("Observaciones Entrega"));
                    
                    if (rs.getTimestamp("Fecha de Revision") != null) {
                        entrega.setFechaRevision(rs.getTimestamp("Fecha de Revision"));
                    } else {
                        // Manejar el caso de fecha de revisión nula, por ejemplo, estableciendo un valor predeterminado o dejándolo como nulo
                        entrega.setFechaRevision(null); // o cualquier valor por defecto si es requerido
                    }

                    
                    Blob archivoBlob = rs.getBlob("Archivo");
                    if (archivoBlob != null) {
                        int blobLength = (int) archivoBlob.length();  
                        byte[] blobAsBytes = archivoBlob.getBytes(1, blobLength);
                        entrega.setArchivo(blobAsBytes);
                        archivoBlob.free(); // Free up the blob resources in the database
                    }
                }

                NotaEvaluacion notaEvaluacion = null;
                if (rs.getInt("Puntos Obtenidos") != 0) {
                    notaEvaluacion = new NotaEvaluacion();
                    notaEvaluacion.setPuntajeObtenido(rs.getInt("Puntos Obtenidos"));
                    notaEvaluacion.setDetalle(rs.getString("Observaciones Nota"));
                    notaEvaluacion.setFecha(rs.getTimestamp("Fecha de Registro Nota"));
                }

                EvaluacionConEntrega evaluacionConEntrega = new EvaluacionConEntrega(evaluacion, entrega, notaEvaluacion);
                lista.add(evaluacionConEntrega);
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try { if (rs != null) rs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (cs != null) cs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (con != null) con.close(); } catch (SQLException e) { e.printStackTrace(); }
        }

        return lista;
    }
    
}


