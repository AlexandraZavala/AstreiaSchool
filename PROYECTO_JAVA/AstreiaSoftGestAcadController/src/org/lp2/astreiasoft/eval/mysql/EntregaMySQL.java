package org.lp2.astreiasoft.eval.mysql;
import java.sql.Blob;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.EntregaDAO;
import org.lp2.astreiasoft.eval.model.Entrega;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.sql.Types;
import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.eval.model.EstadoEntrega;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
import org.lp2.astreiasoft.users.model.Estudiante;

public class EntregaMySQL implements EntregaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public int insertar(Entrega entrega, int idEvaluacion, int idEstudiante) {
        int idEntrega = 0;
        Connection con = null;
        CallableStatement cs = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_ENTREGA(?,?,?,?,?) }");
            cs.registerOutParameter(1, Types.INTEGER); // Registrar el parámetro de salida
            cs.setInt(2, idEvaluacion);
            cs.setInt(3, idEstudiante);
            cs.setBytes(4, entrega.getArchivo());
            cs.setString(5, entrega.getObservaciones());

            cs.executeUpdate();
            idEntrega = cs.getInt(1); // Obtener el ID de la entrega insertada
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
        return idEntrega;
    }
    
    @Override
    public int modificar(Entrega entrega) {
        int resultado = 0;
        Connection con = null;
        CallableStatement cs = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_ENTREGA(?,?,?)}");
            cs.setInt(1, entrega.getIdEntrega());

            if (entrega.getArchivo() != null) {
                cs.setBytes(2, entrega.getArchivo());
            } else {
                cs.setNull(2, java.sql.Types.BLOB); // O el tipo de SQL apropiado para el archivo
            }

            cs.setString(3, entrega.getObservaciones());

            resultado = cs.executeUpdate();
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
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
    public int asignarOAnularNota(NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        Connection con = null;
        CallableStatement cs = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ASIGNAR_O_ANULAR_NOTA(?,?,?,?)}");

            // Establecer los parámetros del procedimiento almacenado usando NotaEvaluacion y su Entrega asociada
            cs.setInt(1, notaEvaluacion.getEntrega().getIdEntrega());
            cs.setInt(2, notaEvaluacion.getPuntajeObtenido());
            cs.setString(3, notaEvaluacion.getDetalle());
            // Establecer el estado de anulado basado en el estado de la Entrega asociada
            cs.setBoolean(4, false);

            resultado = cs.executeUpdate();
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
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
    public int eliminar(int idEntrega) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_ENTREGA(?)");
            cs.setInt("_id_entrega", idEntrega);
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
    public ArrayList<Entrega> listarTodos() {
        ArrayList<Entrega> entregas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ENTREGAS_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Entrega entrega = new Entrega();
                entrega.setIdEntrega(rs.getInt("id_entrega"));
                entrega.setEvaluacion(new Evaluacion());
                entrega.getEvaluacion().setIdEvaluacion(rs.getInt("fid_evaluacion"));
                entrega.setEstudiante(new Estudiante());
                entrega.getEstudiante().setIdUsuario(rs.getInt("fid_estudiante"));
                entrega.setArchivo(rs.getBytes("archivo"));
                entrega.setFechaEntrega(rs.getDate("fecha_entrega"));
                entrega.setEstado(EstadoEntrega.valueOf(rs.getString("estado")));
                entrega.setObservaciones(rs.getString("observaciones"));
                entrega.setFechaRevision(rs.getDate("fecha_revision"));
                entregas.add(entrega);
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
        return entregas;
    }
    
    @Override
    public ArrayList<NotaEvaluacion> listarEntregasPorEvaluacion(int idEvaluacion) {
        ArrayList<NotaEvaluacion> notasEvaluaciones = new ArrayList<>();
        Connection con = null;
        CallableStatement cs = null;
        ResultSet rs = null;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ENTREGAS_POR_EVALUACION(?)}");
            cs.setInt(1, idEvaluacion);
            rs = cs.executeQuery();

            while (rs.next()) {
                Entrega entrega = new Entrega();
                NotaEvaluacion notaEvaluacion = new NotaEvaluacion();

                // Configurar entrega y estudiante
                entrega.setIdEntrega(rs.getInt("id_entrega"));
                Estudiante estudiante = new Estudiante();
                estudiante.setNombre(rs.getString("nombre"));
                estudiante.setApellidoPaterno(rs.getString("apellido_paterno"));
                estudiante.setApellidoMaterno(rs.getString("apellido_materno"));
                entrega.setEstudiante(estudiante);

                // Configurar entrega
                entrega.setEstado(EstadoEntrega.valueOf(rs.getString("estado")));
                entrega.setObservaciones(rs.getString("observaciones"));
                entrega.setFechaEntrega(rs.getDate("fecha_entrega"));
                entrega.setArchivo(rs.getBytes("archivo"));
                entrega.setFechaRevision(rs.getDate("fecha_revision"));

                // Configurar NotaEvaluacion
                notaEvaluacion.setIdNotaEvaluacion(rs.getInt("id_nota"));
                notaEvaluacion.setEntrega(entrega);
                notaEvaluacion.setPuntajeObtenido(rs.getInt("puntos_obtenidos"));
                notaEvaluacion.setDetalle(rs.getString("observaciones_nota"));
                notaEvaluacion.setFecha(rs.getDate("fecha_registro_nota"));

                notasEvaluaciones.add(notaEvaluacion);
            }
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try { if (rs != null) rs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (cs != null) cs.close(); } catch (SQLException e) { e.printStackTrace(); }
            try { if (con != null) con.close(); } catch (SQLException e) { e.printStackTrace(); }
        }
        return notasEvaluaciones;
    }



    
    

}