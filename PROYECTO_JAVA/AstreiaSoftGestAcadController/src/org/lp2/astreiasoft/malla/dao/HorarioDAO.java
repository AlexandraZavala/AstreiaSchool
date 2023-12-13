
package org.lp2.astreiasoft.malla.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.malla.model.Horario;

/**
 *
 * @author Alexandra
 */
public interface HorarioDAO {
    int insertar(Horario horario);
    int modificar(Horario horario);
    int eliminar(int idHorario);
    ArrayList<Horario> listarTodos();
    ArrayList<Horario> listarTodosPorId(int idSeccion);
    ArrayList<Horario> listarTodosPorIdDocente(int idDocente);
    String obtenerNombreDocente(int idHorario);
    String obtenerNombreCurso(int idHorario);
    int verificarEliminarHorarioCursDocente(int idHorario);
    int verificarEliminarHorarioCursEstudiante(int idHorario);
}
