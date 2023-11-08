package org.lp2.astreiasoft.eval.mysql;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.NotaEvaluacionDAO;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;

public class NotaEvaluacionMySQL implements NotaEvaluacionDAO {
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_NOTAEVALUACION(?,?,?,?,?) }");
            cs.registerOutParameter("_id_nota", java.sql.Types.INTEGER);
            cs.setInt("_fid_entrega", notaEvaluacion.getEntrega().getIdEntrega());
            cs.setInt("_puntos_obtenidos", notaEvaluacion.getPuntajeObtenido());
            cs.setString("_observaciones", notaEvaluacion.getDetalle());
            cs.setDate("_fecha_registro", new java.sql.Date(notaEvaluacion.getFecha().getTime()));
            resultado = cs.executeUpdate();
            notaEvaluacion.setIdNotaEvaluacion(cs.getInt("_id_nota"));
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
    public int modificar(NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_NOTAEVALUACION(?,?,?,?,?) }");
            cs.setInt("_id_nota", notaEvaluacion.getIdNotaEvaluacion());
            cs.setInt("_fid_entrega", notaEvaluacion.getEntrega().getIdEntrega());
            cs.setInt("_puntos_obtenidos", notaEvaluacion.getPuntajeObtenido());
            cs.setString("_observaciones", notaEvaluacion.getDetalle());
            cs.setDate("_fecha_registro", new java.sql.Date(notaEvaluacion.getFecha().getTime()));
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
    public int eliminar(int idNotaEvaluacion) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ELIMINAR_NOTAEVALUACION(?) }");
            cs.setInt("_id_nota", idNotaEvaluacion);
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
    public ArrayList<NotaEvaluacion> listarTodos() {
        ArrayList<NotaEvaluacion> notas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_NOTAEVALUACIONES_TODAS() }");
            rs = cs.executeQuery();
            while (rs.next()) {
                NotaEvaluacion notaEvaluacion = new NotaEvaluacion();
                notaEvaluacion.setIdNotaEvaluacion(rs.getInt("id_nota"));
                Entrega entrega = new Entrega();
                entrega.setIdEntrega(rs.getInt("fid_entrega"));
                notaEvaluacion.setEntrega(entrega);
                notaEvaluacion.setPuntajeObtenido(rs.getInt("puntos_obtenidos"));
                notaEvaluacion.setDetalle(rs.getString("observaciones"));
                notaEvaluacion.setFecha(rs.getDate("fecha_registro"));
                notas.add(notaEvaluacion);
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
        return notas;
    }
}