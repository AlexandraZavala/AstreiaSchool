package org.lp2.astreiasoft.eval.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.BimestreDAO;
import org.lp2.astreiasoft.eval.model.Bimestre;

public class BimestreMySQL implements BimestreDAO {
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Bimestre bimestre) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_BIMESTRE(?,?,?,?) }");
            cs.registerOutParameter("_id_bimestre", java.sql.Types.INTEGER);
            cs.setString("_nombre", bimestre.getNombre());
            cs.setDate("_fecha_inicio", new java.sql.Date(bimestre.getInicioPeriodo().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(bimestre.getFinPeriodo().getTime()));
            resultado = cs.executeUpdate();
            
            bimestre.setIdBimestre(cs.getInt("_id_bimestre"));
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
    public int modificar(Bimestre bimestre) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_BIMESTRE(?,?,?,?)}");
            cs.setInt("_id_bimestre", bimestre.getIdBimestre());
            cs.setString("_nombre", bimestre.getNombre());
            cs.setDate("_fecha_inicio", new java.sql.Date(bimestre.getInicioPeriodo().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(bimestre.getFinPeriodo().getTime()));
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
    public int eliminar(int idBimestre) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_BIMESTRE(?)");
            cs.setInt("_id_bimestre", idBimestre);
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
    public ArrayList<Bimestre> listarTodos() {
        ArrayList<Bimestre> bimestres = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_BIMESTRES_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Bimestre bimestre = new Bimestre();
                bimestre.setIdBimestre(rs.getInt("id_bimestre"));
                bimestre.setNombre(rs.getString("nombre"));
                bimestre.setInicioPeriodo(rs.getDate("fecha_inicio"));
                bimestre.setFinPeriodo(rs.getDate("fecha_fin"));
                bimestres.add(bimestre);
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
        return bimestres;
    }
}
