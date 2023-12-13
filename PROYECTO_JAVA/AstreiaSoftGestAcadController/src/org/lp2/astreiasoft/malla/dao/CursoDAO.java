package org.lp2.astreiasoft.malla.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.malla.model.Curso;


/**
 *
 * @author Alexandra
 */
public interface CursoDAO {
    int insertar(Curso curso);
    int modificar(Curso curso);
    int eliminar(int idCurso);
    ArrayList<Curso> listarTodos();
    ArrayList<Curso> listarPorNombre(String nombre);
    ArrayList<Curso> listarPorUsuarioYAnio(int idUsuario, int anio);
    int verificar_curso(Curso curso);
    int verificar_eliminar_curso(int idCurso);
    //Ale
    public String obtenerNombrePorId(int id);
    int encontrarPorCurso(int idCurso);
}
