/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.admin.dao;

import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.admin.model.Inscripcion;
import org.lp2.astreiasoft.admin.model.Matricula;

/**
 *
 * @author ricardomelendez
 */
public interface MatriculaDAO {
    int insertar(Matricula area);
    int modificar(Matricula area);
    int eliminar(int idArea);
    ArrayList<Matricula> listarTodas();
    ArrayList<Matricula> listarMatriculaPorAnho(int inputAnho);
    ArrayList<Integer> listarAnhosMatriculacion();
    int verificarMatriculaParaPreinscripcion();
}
