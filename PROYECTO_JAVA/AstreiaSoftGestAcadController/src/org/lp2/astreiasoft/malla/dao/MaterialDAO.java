

package org.lp2.astreiasoft.malla.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.malla.model.Material;

/**
 *
 * @author Alexandra
 */
public interface MaterialDAO {
    int insertar(Material material);
    int modificar(Material material);
    int eliminar(int idMAterial);
    ArrayList<Material> listarTodos(); 
    ArrayList<Material> listarPorCursoProgramado(int idCursoProgramado);
}