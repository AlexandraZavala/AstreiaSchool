package org.lp2.astreiasoft.eval.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Evaluacion;
public interface EvaluacionDAO {
    int insertar(Evaluacion idEvaluacion);
    int modificar(Evaluacion idEvaluacion);
    int eliminar(int idEvaluacion);
    ArrayList<Evaluacion> listarTodos();
}