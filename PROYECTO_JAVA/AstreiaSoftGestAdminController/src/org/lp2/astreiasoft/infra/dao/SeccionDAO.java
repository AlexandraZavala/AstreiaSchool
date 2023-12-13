package org.lp2.astreiasoft.infra.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.infra.model.Seccion;


public interface SeccionDAO {
    int insertar(Seccion seccion);
    int modificar(Seccion seccion);
    int eliminar(int idSeccion);
    ArrayList<Seccion> listarTodas();
    ArrayList<Seccion> listarSeccionesPorGrado(int idGrado);
    int asignarAulaXSeccion(int idSeccion, int idAula);
    int verificarAula(int idAula);
    ArrayList<Seccion> listarAulasDetalle(String nombreAula);
    public ArrayList<Integer> listarEstPorSeccion(int idSeccion);
}
