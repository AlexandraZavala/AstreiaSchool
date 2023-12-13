/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.lp2.astreiasoft.admin.mysql;

import java.sql.Connection;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.function.Function;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.lp2.astreiasoft.admin.dao.EventoDAO;
import org.lp2.astreiasoft.admin.model.Evento;
import org.lp2.astreiasoft.config.DBManager;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Time;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.ZoneId;
import java.util.Date;
import java.sql.Types;

/**
 *
 * @author ricardomelendez
 */
public class EventoMySQL implements EventoDAO{
    
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
    public int insertar(Evento evento) {
       return ejecutarEnConexion(con -> {
           try {
               CallableStatement cs = con.prepareCall("{call sp_InsertarEvento(?, ?, ?, ?, ?, ?)}");
               cs.setString(1, evento.getNombre());
               cs.setString(2, evento.getDescripcion());
               cs.setTimestamp(3, new java.sql.Timestamp(evento.getFechaInicio().getTime()));
               cs.setTimestamp(4, new java.sql.Timestamp(evento.getFechaFin().getTime()));
               cs.setString(5, evento.getLugar()); // Nuevo parámetro para lugar
               cs.registerOutParameter(6, Types.INTEGER); // Cambio en el índice

               cs.execute();

               int idEventoInsertado = cs.getInt(6); // Cambio en el índice

               return idEventoInsertado;
           } catch (SQLException e) {
               e.printStackTrace();
               return 0;
           }
       });
    }




    @Override
    public int modificar(Evento evento) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call sp_ModificarEvento(?, ?, ?, ?, ?, ?)}");
                cs.setInt(1, evento.getIdEvento());
                cs.setString(2, evento.getNombre());
                cs.setString(3, evento.getDescripcion());
                cs.setTimestamp(4, new java.sql.Timestamp(evento.getFechaInicio().getTime()));
                cs.setTimestamp(5, new java.sql.Timestamp(evento.getFechaFin().getTime()));
                cs.setString(6, evento.getLugar()); // Nuevo parámetro para lugar

                int affectedRows = cs.executeUpdate();
                System.out.println("Registros afectados: " + affectedRows); // Esta línea imprimirá el número de registros afectados en tus logs.
                return affectedRows;

            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }



    @Override
    public int eliminar(int idEvento) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call sp_EliminarEvento(?)}");
                cs.setInt(1, idEvento);

                return cs.executeUpdate();
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
    public ArrayList<Evento> listarTodas() {
        return ejecutarEnConexion(con -> {
            ArrayList<Evento> eventos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call sp_ListarTodosEventos()}");
                ResultSet resultSet = cs.executeQuery();

                while (resultSet.next()) {
                    Evento evento = new Evento();
                    evento.setIdEvento(resultSet.getInt("id_evento"));
                    evento.setNombre(resultSet.getString("nombre_evento"));
                    evento.setDescripcion(resultSet.getString("descripcion_evento"));
                    evento.setFechaInicio(resultSet.getTimestamp("fecha_inicio_evento")); // Cambio aquí
                    evento.setFechaFin(resultSet.getTimestamp("fecha_fin_evento")); // Cambio aquí
                    evento.setLugar(resultSet.getString("lugar_evento"));
                    eventos.add(evento);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return eventos;
        });
    }

    
    @Override
    public ArrayList<Evento> listarEventosPorNombreYFecha(String nombre, Date fechaInicio) {
        return ejecutarEnConexion(con -> {
            ArrayList<Evento> eventos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call sp_ListarEventosPorNombreYFecha(?, ?)}");
                if (nombre != null && !nombre.isEmpty()) {
                    cs.setString(1, nombre);
                } else {
                    cs.setNull(1, Types.VARCHAR);
                }

                if (fechaInicio != null) {
                    cs.setTimestamp(2, new java.sql.Timestamp(fechaInicio.getTime()));
                } else {
                    cs.setNull(2, Types.TIMESTAMP);
                }

                ResultSet resultSet = cs.executeQuery();

                while (resultSet.next()) {
                    Evento evento = new Evento();
                    evento.setIdEvento(resultSet.getInt("id_evento"));
                    evento.setNombre(resultSet.getString("nombre_evento"));
                    evento.setDescripcion(resultSet.getString("descripcion_evento"));
                    evento.setFechaInicio(resultSet.getTimestamp("fecha_inicio_evento"));
                    evento.setFechaFin(resultSet.getTimestamp("fecha_fin_evento"));
                    evento.setLugar(resultSet.getString("lugar_evento"));
                    eventos.add(evento);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return eventos;
        });
    }
    
    @Override
    public ArrayList<Evento> listarEventosPorNombre(String nombre) {
        return ejecutarEnConexion(con -> {
            ArrayList<Evento> eventos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call sp_ListarEventosPorNombre(?)}");
                if (nombre != null && !nombre.isEmpty()) {
                    cs.setString(1, nombre);
                } else {
                    cs.setNull(1, Types.VARCHAR);
                }

                ResultSet resultSet = cs.executeQuery();

                while (resultSet.next()) {
                    Evento evento = new Evento();
                    evento.setIdEvento(resultSet.getInt("id_evento"));
                    evento.setNombre(resultSet.getString("nombre_evento"));
                    evento.setDescripcion(resultSet.getString("descripcion_evento"));
                    evento.setFechaInicio(resultSet.getTimestamp("fecha_inicio_evento"));
                    evento.setFechaFin(resultSet.getTimestamp("fecha_fin_evento"));
                    evento.setLugar(resultSet.getString("lugar_evento"));
                    eventos.add(evento);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return eventos;
        });
    }
    
    @Override
    public ArrayList<Evento> listarEventosInscritosPorEstudiante(int idEstudiante) {
        return ejecutarEnConexion(con -> {
            ArrayList<Evento> eventos = new ArrayList<>();
            try {
                CallableStatement cs = con.prepareCall("{call sp_listarEventosInscritosPorEstudiante(?)}");
                cs.setInt(1, idEstudiante);
                ResultSet rs = cs.executeQuery();

                while (rs.next()) {
                    Evento evento = new Evento();
                    evento.setIdEvento(rs.getInt("id_evento"));
                    evento.setNombre(rs.getString("nombre_evento"));
                    evento.setDescripcion(rs.getString("descripcion_evento"));
                    evento.setFechaInicio(rs.getTimestamp("fecha_inicio_evento"));
                    evento.setFechaFin(rs.getTimestamp("fecha_fin_evento"));
                    evento.setLugar(rs.getString("lugar_evento"));
                    eventos.add(evento);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            return eventos;
        });
    }

    @Override
    public int inscribirEstudianteEnEvento(int idEstudiante, int idEvento) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call sp_inscribirEstudianteEnEvento(?, ?)}");
                cs.setInt(1, idEstudiante);
                cs.setInt(2, idEvento);
                return cs.executeUpdate();
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }

    @Override
    public int cancelarInscripcionEvento(int idEstudiante, int idEvento) {
        return ejecutarEnConexion(con -> {
            try {
                CallableStatement cs = con.prepareCall("{call sp_cancelarInscripcionEvento(?, ?)}");
                cs.setInt(1, idEstudiante);
                cs.setInt(2, idEvento);
                return cs.executeUpdate();
            } catch (SQLException e) {
                e.printStackTrace();
                return 0;
            }
        });
    }
}
