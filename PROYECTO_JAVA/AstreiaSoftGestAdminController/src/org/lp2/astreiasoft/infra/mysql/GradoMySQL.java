package org.lp2.astreiasoft.infra.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.infra.dao.GradoDAO;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;

/**
 *
 * @author mezav
 */
public class GradoMySQL implements GradoDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public ArrayList<Grado> listarTodas() {
        ArrayList<Grado> grados = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_GRADOS_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Grado grado = new Grado();
                grado.setIdGrado(rs.getInt("id_grado"));
                grado.setNombreCompleto(rs.getString("nombre_completo"));
                grado.setFechaCreacion(rs.getDate("fecha_creacion"));
                grado.setActivo(true);

                grados.add(grado);
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
        return grados;
    }

    public List<NivelEducativo> listarNivelesEducativos() {
        return Arrays.asList(NivelEducativo.values());
    }

    

}
