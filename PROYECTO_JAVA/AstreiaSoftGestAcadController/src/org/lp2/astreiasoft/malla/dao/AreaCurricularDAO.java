
package org.lp2.astreiasoft.malla.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.malla.model.AreaCurricular;

/**
 *
 * @author Alexandra
 */
public interface AreaCurricularDAO {
    int insertar(AreaCurricular areaCurricular);
    int modificar(AreaCurricular areaCurricular);
    int eliminar(int idAreaCurricular);
    int verificar_area(String nombre);
    ArrayList<AreaCurricular> listarTodas();
    ArrayList<AreaCurricular> listarPorNombre(String nombre);
    public String obtenerNombrePorId(int id);
    
}
