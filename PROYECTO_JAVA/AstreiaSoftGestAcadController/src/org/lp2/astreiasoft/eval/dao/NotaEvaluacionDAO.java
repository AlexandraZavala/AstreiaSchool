package org.lp2.astreiasoft.eval.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;
public interface NotaEvaluacionDAO {
    int insertar(NotaEvaluacion notaEvaluacion);
    int modificar(NotaEvaluacion notaEvaluacion);
    int eliminar(int idNotaEvaluacion);
    ArrayList<NotaEvaluacion> listarTodos();
    byte[] generarReporte(int idHorario, int idBimestre, String nombreCurso, String nombreDocente);
}