package org.lp2.astreiasoft.services.gestacad;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.lp2.astreiasoft.eval.dao.BimestreDAO;
import org.lp2.astreiasoft.eval.dao.EntregaDAO;
import org.lp2.astreiasoft.eval.dao.EvaluacionDAO;
import org.lp2.astreiasoft.eval.dao.NotaEvaluacionDAO;
import org.lp2.astreiasoft.eval.dao.ReclamoCalificacionDAO;
import org.lp2.astreiasoft.eval.model.Bimestre;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import org.lp2.astreiasoft.eval.model.EvaluacionConEntrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
import org.lp2.astreiasoft.eval.model.ReclamoCalificacion;
import org.lp2.astreiasoft.eval.mysql.BimestreMySQL;
import org.lp2.astreiasoft.eval.mysql.EntregaMySQL;
import org.lp2.astreiasoft.eval.mysql.EvaluacionMySQL;
import org.lp2.astreiasoft.eval.mysql.NotaEvaluacionMySQL;
import org.lp2.astreiasoft.eval.mysql.ReclamoCalificacionMySQL;

@WebService(serviceName = "EvalWS")
public class EvalWS {
    private BimestreDAO daoBimestre  = new BimestreMySQL();
    private EntregaDAO daoEntrega = new EntregaMySQL();
    private EvaluacionDAO daoEvaluacion = new EvaluacionMySQL();
    private NotaEvaluacionDAO daoNotaEvaluacion = new NotaEvaluacionMySQL();
    private ReclamoCalificacionDAO daoReclamoCalificacion = new ReclamoCalificacionMySQL();
    
    // ****************** BIMESTRE ******************
    
    @WebMethod(operationName = "insertarBimestre")
    public int insertarBimestre(@WebParam(name = "bimestre") Bimestre bimestre) {
        int resultado = 0;
        try {
            resultado = daoBimestre.insertar(bimestre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarBimestre")
    public int modificarBimestre(@WebParam(name = "bimestre") Bimestre bimestre) {
        int resultado = 0;
        try {
            resultado = daoBimestre.modificar(bimestre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarBimestre")
    public int eliminarBimestre(@WebParam(name = "idBimestre") int idBimestre) {
        int resultado = 0;
        try {
            resultado = daoBimestre.eliminar(idBimestre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarBimestres")
    public ArrayList<Bimestre> listarBimestres() {
        ArrayList<Bimestre> bimestres = new ArrayList<>();
        try {
            bimestres = daoBimestre.listarTodos();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return bimestres;
    }
    
        // ****************** ENTREGA ******************
    
    @WebMethod(operationName = "insertarEntrega")
    public int insertarEntrega(
        @WebParam(name = "entrega") Entrega entrega,
        @WebParam(name = "idEvaluacion") int idEvaluacion,
        @WebParam(name = "idEstudiante") int idEstudiante) {

        int resultado = 0;
        try {
            // Suponiendo que 'daoEntrega' es tu objeto DAO que contiene el método 'insertar'
            resultado = daoEntrega.insertar(entrega, idEvaluacion, idEstudiante);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    
    @WebMethod(operationName = "modificarEntrega")
    public int modificarEntrega(@WebParam(name = "bimestre") Entrega entrega) {
        int resultado = 0;
        try {
            resultado = daoEntrega.modificar(entrega);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarEntrega")
    public int eliminarEntrega(@WebParam(name = "idEntrega") int idEntrega) {
        int resultado = 0;
        try {
            resultado = daoEntrega.eliminar(idEntrega);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEntrega")
    public ArrayList<Entrega> listarEntrega() {
        ArrayList<Entrega> entregas = new ArrayList<>();
        try {
            entregas = daoEntrega.listarTodos();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return entregas;
    }
    
    // ****************** EVALUACION ******************
    
    @WebMethod(operationName = "insertarEvaluacion")
    public int insertarEvaluacion(@WebParam(name = "evaluacion") Evaluacion evaluacion) {
        int resultado = 0;
        try {
            resultado = daoEvaluacion.insertar(evaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarEvaluacion")
    public int modificarEvaluacion(@WebParam(name = "evaluacion") Evaluacion evaluacion) {
        int resultado = 0;
        try {
            resultado = daoEvaluacion.modificar(evaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarEvaluacion")
    public int eliminarEvaluacion(@WebParam(name = "idEvaluacion") int idEvaluacion) {
        int resultado = 0;
        try {
            resultado = daoEvaluacion.eliminar(idEvaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEvaluacion")
    public ArrayList<Evaluacion> listarEvaluacion() {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try {
            evaluaciones = daoEvaluacion.listarTodos();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return evaluaciones;
    }
    
    // ****************** NOTA EVALUACION ******************
    
    @WebMethod(operationName = "insertarNotaEvaluacion")
    public int insertarNotaEvaluacion(@WebParam(name = "notaEvaluacion") NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        try {
            resultado = daoNotaEvaluacion.insertar(notaEvaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarNotaEvaluacion")
    public int modificarNotaEvaluacion(@WebParam(name = "notaEvaluacion") NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        try {
            resultado = daoNotaEvaluacion.modificar(notaEvaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarNotaEvaluacion")
    public int eliminarNotaEvaluacion(@WebParam(name = "idNotaEvaluacion") int idNotaEvaluacion) {
        int resultado = 0;
        try {
            resultado = daoNotaEvaluacion.eliminar(idNotaEvaluacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarNotaEvaluacion")
    public ArrayList<NotaEvaluacion> listarNotaEvaluacion() {
        ArrayList<NotaEvaluacion> notasEvaluaciones = new ArrayList<>();
        try {
            notasEvaluaciones = daoNotaEvaluacion.listarTodos();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return notasEvaluaciones;
    }

    // EXTRA

    @WebMethod(operationName = "listarTiposEvaluacion")
    public ArrayList<String> listarTiposEvaluacion() {
        ArrayList<String> tiposEvaluacion = new ArrayList<>();
        try {
            tiposEvaluacion = daoEvaluacion.listarTiposEvaluacion();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return tiposEvaluacion;
    }
    
    @WebMethod(operationName = "listarEvaluacionesPorNombre")
    public ArrayList<Evaluacion> listarEvaluacionesPorNombre(
            @WebParam(name = "idCursoProgramado") int idCursoProgramado,
            @WebParam(name = "nombreEvaluacion") String nombreEvaluacion) {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try {
            evaluaciones = daoEvaluacion.listarEvaluacionesPorNombre(idCursoProgramado, nombreEvaluacion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return evaluaciones;
    }
    
    @WebMethod(operationName = "listarEvaluacionesConEntregasYUltimaNota")
    public ArrayList<EvaluacionConEntrega> listarEvaluacionesConEntregasYUltimaNota(
            @WebParam(name = "idCursoProgramado") int idCursoProgramado,
            @WebParam(name = "idUsuario") int idUsuario) {
        ArrayList<EvaluacionConEntrega> evaluacionesConEntrega = new ArrayList<>();
        try {
            evaluacionesConEntrega = daoEvaluacion.listarEvaluacionesConEntregasYUltimaNota(idCursoProgramado, idUsuario);
        } catch (Exception ex) {
            System.out.println("Error al listar evaluaciones con entregas y última nota: " + ex.getMessage());
        }
        return evaluacionesConEntrega;
    }
    
    @WebMethod(operationName = "listarEntregasPorEvaluacion")
    public ArrayList<NotaEvaluacion> listarEntregasPorEvaluacion(@WebParam(name = "idEvaluacion") int idEvaluacion) {
        ArrayList<NotaEvaluacion> entregas = new ArrayList<>();
        try {
            entregas = daoEntrega.listarEntregasPorEvaluacion(idEvaluacion);
        } catch (Exception ex) {
            System.out.println("Error al listar entregas por evaluación: " + ex.getMessage());
        }
        return entregas;
    }
    
    @WebMethod(operationName = "modificarEntregaYNota")
    public int modificarEntregaYNota(@WebParam(name = "notaEvaluacion") NotaEvaluacion notaEvaluacion) {
        int resultado = 0;
        try {
            resultado = daoEntrega.asignarOAnularNota(notaEvaluacion);
        } catch (Exception ex) {
            System.out.println("Error al modificar entrega y nota: " + ex.getMessage());
        }
        return resultado;
    }

    //
    
    // ****************** RECLAMO CALIFICACION ******************
    
    @WebMethod(operationName = "insertarReclamoCalificacion")
    public int insertarReclamoCalificacion(@WebParam(name = "reclamoCalificacion") ReclamoCalificacion reclamoCalificacion) {
        int resultado = 0;
        try {
            resultado = daoReclamoCalificacion.insertar(reclamoCalificacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarReclamoCalificacion")
    public int modificarReclamoCalificacion(@WebParam(name = "reclamoCalificacion") ReclamoCalificacion reclamoCalificacion) {
        int resultado = 0;
        try {
            resultado = daoReclamoCalificacion.modificar(reclamoCalificacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarReclamoCalificacion")
    public int eliminarReclamoCalificacion(@WebParam(name = "idReclamoCalificacion") int idReclamoCalificacion) {
        int resultado = 0;
        try {
            resultado = daoNotaEvaluacion.eliminar(idReclamoCalificacion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarReclamoCalificaciones")
    public ArrayList<ReclamoCalificacion> listarReclamoCalificaciones() {
        ArrayList<ReclamoCalificacion> reclamosCalificacion = new ArrayList<>();
        try {
            reclamosCalificacion = daoReclamoCalificacion.listarTodos();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return reclamosCalificacion;
    }
    
    
    
    //Alberto
    @WebMethod(operationName = "generarReporteDeNotas")
    public byte[] generarReporteDeNotas(@WebParam(name = "idHorario") int idHorario,
            @WebParam(name = "idBimestre") int idBimestre,
            @WebParam(name = "nombreCurso") String nombreCurso,
            @WebParam(name = "nombreDocente") String nombreDocente){
        byte[]reporte = null;
        try{
                reporte = daoNotaEvaluacion.generarReporte(idHorario, idBimestre, 
                        nombreCurso, nombreDocente);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return reporte;
    }
        
}
