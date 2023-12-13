
package org.lp2.astreiasoft.malla.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.malla.model.CursoProgramado;

/**
 *
 * @author Alexandra
 */
public interface CursoProgramadoDAO {
    int insertar(CursoProgramado cursoProgramado);
    int modificar(CursoProgramado cursoProgramado);
    int eliminar(int idCursoProgramado);
    int eliminarHorarios(int idCursoProgramado);
    ArrayList<CursoProgramado> listarTodos();
    ArrayList<CursoProgramado> listarPorNombre(String nombre);
    ArrayList<CursoProgramado> listarPorGrado(int idGrado);
    int verificar_curso(CursoProgramado curso);
    int verificar_estudiantes(int idCursoP, int idSeccion);
    int verificar_docente(int idCursoP, int idDocente);
    int asignarEstudiantesCursoProgramado(int idCursoProgramado, ArrayList<Integer> estudiantes);
    int asignarDocenteCursoProgramado(int idCursoProgramado, int idDocente);
    ArrayList<CursoProgramado> listarPorUsuario(int idUsuario);
}
