
package org.lp2.astreiasoft.eval.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Entrega;

/**
 *
 * @author ricardomelendez
 */
public interface EntregaDAO {
    int insertar(Entrega entrega);
    int modificar(Entrega entrega);
    int eliminar(int idEntrega);
    ArrayList<Entrega> listarTodos();
}