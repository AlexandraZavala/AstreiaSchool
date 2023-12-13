package org.lp2.astreiasoft.users.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.Docente;

public interface DocenteDAO {
    int insertar(Docente docente);
    int insertarUsuarioExiste(Docente docente);
    int modificar(Docente docente);
    int eliminar(int idDocente);
    ArrayList<Docente> listarTodos(String nombreDNI); 
	ArrayList<Docente> listarTodosDocentesCursos(); 
    String obtenerNombre(int idDocente);
}
