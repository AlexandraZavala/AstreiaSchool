package org.lp2.astreiasoft.users.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.Estudiante;
import org.lp2.astreiasoft.users.model.PadreFamilia;

public interface PadreFamiliaDAO {
    int insertar(PadreFamilia padreFamilia);
    int insertarUsuarioExiste(PadreFamilia padreFamilia);
    int modificar(PadreFamilia padreFamilia);
    int eliminar(int idPadreFamilia);
    ArrayList<PadreFamilia> listarTodos(String nombreDNI); 
    ArrayList<Estudiante> listarEstudiantesXPadre(PadreFamilia padreFamilia);
}
