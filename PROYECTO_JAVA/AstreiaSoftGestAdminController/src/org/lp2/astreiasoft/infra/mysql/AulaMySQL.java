package org.lp2.astreiasoft.infra.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.dao.AulaDAO;
import org.lp2.astreiasoft.infra.model.Aula;
import org.lp2.astreiasoft.infra.model.EstadoAula;

public class AulaMySQL implements AulaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertar(Aula aula) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_AULA(?,?,?,?)}");
            cs.registerOutParameter("_id_aula", java.sql.Types.INTEGER);
            cs.setString("_nombre", aula.getNombre());
            cs.setInt("_capacidad", aula.getCapacidad());
            cs.setString("_codigo", aula.getCodigo());

            resultado = cs.executeUpdate();
            aula.setIdAula(cs.getInt("_id_aula"));
            if(resultado!=0)
                resultado  = aula.getIdAula();
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
    public int modificar(Aula aula) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_AULA(?,?,?,?,?)}");
            cs.setInt("_id_aula", aula.getIdAula());
            cs.setString("_nombre", aula.getNombre());
            cs.setInt("_capacidad", aula.getCapacidad());
            cs.setString("_codigo", aula.getCodigo());
            cs.setString("_EstadoAula", aula.getEstado().name());

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
    public int eliminar(int idAula) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_AULA(?)}");
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
    public ArrayList<Aula> listarTodas() {
        ArrayList<Aula> aulas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AULAS_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Aula aula = new Aula();
                aula.setIdAula(rs.getInt("id_aula"));
                aula.setNombre(rs.getString("nombre"));
                aula.setCapacidad(rs.getInt("capacidad"));
                aula.setCodigo(rs.getString("codigo"));
                aula.setEstado(EstadoAula.valueOf(rs.getString("EstadoAula")));

                aulas.add(aula);
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
        return aulas;
    }

}
