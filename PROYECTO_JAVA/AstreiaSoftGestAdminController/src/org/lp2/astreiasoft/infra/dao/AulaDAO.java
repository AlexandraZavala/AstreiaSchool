package org.lp2.astreiasoft.infra.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.infra.model.Aula;

/**
 *
 * @author mezav
 */
public interface AulaDAO {
    
    int insertar(Aula aula);
    int modificar(Aula aula);
    int eliminar(int idAula);
    ArrayList<Aula> listarTodas();
    
    
    
}
