package org.lp2.astreiasoft.eval.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.ReclamoCalificacion;
public interface ReclamoCalificacionDAO {
    int insertar(ReclamoCalificacion reclamoCalificacion);
    int modificar(ReclamoCalificacion reclamoCalificacion);
    int eliminar(int idReclamoCalificacion);
    ArrayList<ReclamoCalificacion> listarTodos();
}