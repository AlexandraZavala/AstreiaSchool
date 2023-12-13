package org.lp2.astreiasoft.eval.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Evaluacion;
import org.lp2.astreiasoft.eval.model.EvaluacionConEntrega;
public interface EvaluacionDAO {
    int insertar(Evaluacion idEvaluacion);
    int modificar(Evaluacion idEvaluacion);
    int eliminar(int idEvaluacion);
    ArrayList<Evaluacion> listarTodos();
    ArrayList<String> listarTiposEvaluacion();
    ArrayList<Evaluacion> listarEvaluacionesPorNombre(int idCursoProgramado, String nombreEvaluacion);
    ArrayList<EvaluacionConEntrega> listarEvaluacionesConEntregasYUltimaNota(int idCursoProgramado, int idUsuario);
}