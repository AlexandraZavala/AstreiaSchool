package org.lp2.astreiasoft.infra.dao;
//org.lp2.astreiasoft.infra.dao.GradoDAO;

import java.util.ArrayList;
import java.util.List;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;

/**
 *
 * @author mezav
 */
public interface GradoDAO {
    
    ArrayList<Grado> listarTodas();
    
    List<NivelEducativo> listarNivelesEducativos() ;
    
    
    
}