/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.admin.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.admin.model.Asistencia;

/**
 *
 * @author ricardomelendez
 */
public interface AsistenciaDAO {
    int insertar(Asistencia area);
    int modificar(Asistencia area);
    int eliminar(int idArea);
    ArrayList<Asistencia> listarTodas();
}
