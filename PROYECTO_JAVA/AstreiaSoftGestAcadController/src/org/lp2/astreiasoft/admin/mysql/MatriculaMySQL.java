/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.lp2.astreiasoft.admin.mysql;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.CallableStatement;
import java.util.ArrayList;
import java.sql.ResultSet;
import java.util.function.Function;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import org.lp2.astreiasoft.admin.dao.MatriculaDAO;
import org.lp2.astreiasoft.admin.model.Matricula;
import org.lp2.astreiasoft.config.DBManager;
import java.sql.Types;
import java.util.Calendar;
import java.util.Date;

/**
 *
 * @author ricardomelendez
 */
public class MatriculaMySQL implements MatriculaDAO {
    
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
    public int insertar(Matricula matricula) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call INSERTAR_MATRICULA(?, ?, ?, ?)}");
                cs.setDate(1, new java.sql.Date(matricula.getFechaInicio().getTime()));
                cs.setDate(2, new java.sql.Date(matricula.getFechaFin().getTime()));
                cs.setDouble(3, matricula.getMonto());

                // Registrar el parámetro OUT
                cs.registerOutParameter(4, Types.INTEGER);

                cs.execute();

                // Capturar y devolver el valor del parámetro OUT
                return cs.getInt(4);
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }
    
    @Override
    public int verificarMatriculaParaPreinscripcion() {
        return ejecutarEnConexion(con -> {
            int resultado = 0;
            try (CallableStatement cs = con.prepareCall("{call VERIFICAR_MATRICULA_PARA_PREINSCRIPCION(?)}")) {
                cs.registerOutParameter(1, Types.INTEGER);

                cs.execute();

                resultado = cs.getInt(1);
            } catch (SQLException e) {
                e.printStackTrace();
                resultado = -99; // Código de error para una excepción SQL
            }
            return resultado;
        });
    }




    @Override
    public int modificar(Matricula matricula) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call MODIFICAR_MATRICULA(?, ?, ?, ?)}");
                cs.setInt(1, matricula.getIdMatricula());
                cs.setDate(2, new java.sql.Date(matricula.getFechaInicio().getTime()));
                cs.setDate(3, new java.sql.Date(matricula.getFechaFin().getTime()));
                cs.setDouble(4, matricula.getMonto());

                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }


    @Override
    public int eliminar(int idMatricula) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call ELIMINAR_MATRICULA(?)}");
                cs.setInt(1, idMatricula);
                cs.execute();
                return 1;
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
    public ArrayList<Matricula> listarTodas() {
        return ejecutarEnConexion(con -> {
            ArrayList<Matricula> matriculas = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_TODAS_MATRICULAS()}");
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Matricula matricula = new Matricula(
                        rs.getDate("fecha_inicio"),
                        rs.getDate("fecha_fin"),
                        rs.getString("estado"),
                        rs.getDouble("monto")
                    );
                    matricula.setIdMatricula(rs.getInt("id_matricula"));
                    matriculas.add(matricula);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return matriculas;
        });
    }
    
    @Override
    public ArrayList<Matricula> listarMatriculaPorAnho(int inputAnho) {
        return ejecutarEnConexion(con -> {
            ArrayList<Matricula> matriculas = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_MATRICULA_POR_ANHO(?)}");
                cs.setInt(1, inputAnho);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Matricula matricula = new Matricula(
                        rs.getDate("fecha_inicio"),
                        rs.getDate("fecha_fin"),
                        rs.getString("estado"),
                        rs.getDouble("monto")
                    );
                    matricula.setIdMatricula(rs.getInt("id_matricula"));
                    matriculas.add(matricula);
                }
                rs.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return matriculas;
        });
    }
    
    @Override
    public ArrayList<Integer> listarAnhosMatriculacion() {
        return ejecutarEnConexion(con -> {
            ArrayList<Integer> anhos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call LISTAR_ANHOS_MATRICULACION(?)}");
                cs.registerOutParameter(1, java.sql.Types.VARCHAR);
                cs.execute();
                String anhosStr = cs.getString(1);

                // Verificar si anhosStr es null o está vacío
                if (anhosStr != null && !anhosStr.isEmpty()) {
                    for (String anho : anhosStr.split(",")) {
                        anhos.add(Integer.parseInt(anho));
                    }
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return anhos;
        });
    }
}
