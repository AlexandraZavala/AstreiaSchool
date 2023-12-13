package org.lp2.astreiasoft.eval.mysql;
import java.io.ByteArrayOutputStream;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.eval.dao.NotaEvaluacionDAO;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
import java.io.File;
import java.io.FileOutputStream;
import java.sql.ResultSetMetaData;
import java.util.Arrays;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;

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
                
                notaEvaluacion.setEntrega(new Entrega());
                notaEvaluacion.getEntrega().setIdEntrega(rs.getInt("fid_entrega"));
                
                //Entrega entrega = new Entrega();
                //entrega.setIdEntrega(rs.getInt("fid_entrega"));
                //notaEvaluacion.setEntrega(entrega);
                
                
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

    @Override
    public byte[] generarReporte(int idHorario, int idBimestre, String nombreCurso, String nombreDocente) {
        byte [] excel = null;
        Workbook workbook = new XSSFWorkbook();
        //Workbook workbook = new HSSFWorkbook();
        Sheet sheet = workbook.createSheet("Hoja de datos");//Crea hoja nueva
        
        //Row titleRow = sheet.createRow(0);
        //Cell titleCell = titleRow.createCell(0);
        //titleCell.setCellValue("Reporte de Notas"); // Puedes personalizar el título según tus necesidades
        //Por cada línea se crea un arreglo de objetos (Object[])
        Map<String, Object[]> datos = new TreeMap<String, Object[]>();
        
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call REPORTE_NOTAS_POR_CURSO(?,?) }");
            cs.setInt("_id_horario", idHorario);
            cs.setInt("_id_bimestre", idBimestre);
            rs = cs.executeQuery();
            //cs.execute();
            //ENCABEZADO
            String[] encabezadoArray = new String[2];
            encabezadoArray[0] = "";
            datos.put("1", encabezadoArray);
            encabezadoArray = new String[2];
            encabezadoArray[0] = "REPORTE DE NOTAS";
            datos.put("2", encabezadoArray); //TITULO DEL REPORTE
            encabezadoArray = new String[2];
            encabezadoArray[0] = "";
            datos.put("3", encabezadoArray);
            encabezadoArray = new String[2];
            encabezadoArray[0] = "Curso: ";
            encabezadoArray[1] = nombreCurso;
            datos.put("4", encabezadoArray); //NOMBRE DEL CURSO
            encabezadoArray = new String[2];
            encabezadoArray[0] = "Docente: ";
            encabezadoArray[1] = nombreDocente;
            datos.put("5", encabezadoArray); //NOMBRE DEL CURSO
            encabezadoArray = new String[2];
            encabezadoArray[0] = "";
            datos.put("6", encabezadoArray);
            //NOMBRE DE LAS COLUMNAS -- PROBANDO
            ResultSetMetaData metaData = rs.getMetaData();
            int columnCount = metaData.getColumnCount();
            String[] columnaArray = new String[columnCount];
            columnaArray[0] = "Nombre";
            columnaArray[1] = "Apellido Paterno";
            columnaArray[2] = "Apellido Materno";
            for(int i = 3; i<columnCount;i++){
                columnaArray[i] = "E"+String.valueOf(i-2);
            }
            datos.put("7", columnaArray);
            int num_fila=7;
            while (rs.next()) {
                String[] filaArray = new String[columnCount];
                filaArray[0] = rs.getString("nombre");
                filaArray[1] = rs.getString("apellido_paterno");
                filaArray[2] = rs.getString("apellido_materno");
                // Iterar sobre las columnas de notas dinámicamente
                for (int i = 4; i <= columnCount; i++) {
                    String columnName = metaData.getColumnName(i);
                    filaArray[i-1] = String.valueOf(rs.getInt(columnName));
                }
                num_fila++;
                datos.put(String.valueOf(num_fila), filaArray);
            }
            /*
            do {
                rs = cs.getResultSet();
                if (rs != null) {
                    String[] filaArray = new String[columnCount];
                    filaArray[0] = rs.getString("nombre");
                    filaArray[1] = rs.getString("apellido_paterno");
                    filaArray[2] = rs.getString("apellido_materno");
                    // Iterar sobre las columnas de notas dinámicamente
                    for (int i = 4; i <= columnCount; i++) {
                        String columnName = metaData.getColumnName(i);
                        filaArray[i-1] = String.valueOf(rs.getInt(columnName));
                    }
                    num_fila++;
                    datos.put(String.valueOf(num_fila), filaArray);
                    rs.close();
                }
            } while (cs.getMoreResults());
            */
            Set<String> keyset = datos.keySet();
            int numeroRenglon = 0;
            for (String key : keyset) {
                Row row = sheet.createRow(numeroRenglon++);
                Object[] arregloObjetos = datos.get(key);
                int numeroCelda = 0;
                for (Object obj : arregloObjetos) {
                    Cell cell = row.createCell(numeroCelda++);
                    if (obj instanceof String) {
                        cell.setCellValue((String) obj);
                    } else if (obj instanceof Integer) {
                        cell.setCellValue((Integer) obj);
                    }
                }
            }
            // Utiliza ByteArrayOutputStream en lugar de FileOutputStream
            try (ByteArrayOutputStream out = new ByteArrayOutputStream()) {
                // Se genera el documento
                workbook.write(out);
                // Convierte el ByteArrayOutputStream a un array de bytes
                excel = out.toByteArray();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        
        return excel;
    }
}