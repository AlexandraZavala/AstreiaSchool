
package org.lp2.astreiasoft.eval.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Entrega;
import org.lp2.astreiasoft.eval.model.NotaEvaluacion;

/**
 *
 * @author ricardomelendez
 */
public interface EntregaDAO {
    int insertar(Entrega entrega, int idEvaluacion, int idEstudiante);
    int modificar(Entrega entrega);
    int eliminar(int idEntrega);
    ArrayList<Entrega> listarTodos();
    int asignarOAnularNota(NotaEvaluacion notaEvaluacion);
    ArrayList<NotaEvaluacion> listarEntregasPorEvaluacion(int idEvaluacion);
}