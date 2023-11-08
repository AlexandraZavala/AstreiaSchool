package org.lp2.astreiasoft.eval.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.eval.model.Bimestre;
public interface BimestreDAO {
    int insertar(Bimestre bimestre);
    int modificar(Bimestre bimestre);
    int eliminar(int idBimestre);
    ArrayList<Bimestre> listarTodos();
}