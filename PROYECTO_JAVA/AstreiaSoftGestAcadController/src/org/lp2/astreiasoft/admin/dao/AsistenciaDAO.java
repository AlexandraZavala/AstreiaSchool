/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.admin.dao;

import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.admin.model.Asistencia;
import org.lp2.astreiasoft.malla.model.Horario;
import org.lp2.astreiasoft.users.model.Estudiante;

/**
 *
 * @author ricardomelendez
 */
public interface AsistenciaDAO {
    int insertar(Asistencia area);
    int modificar(Asistencia area);
    int eliminar(int idArea);
    ArrayList<Asistencia> listarTodas();
    ArrayList<Horario> listarHorariosDelCurso(int idCursoProg, int idDocente, String dia);
    ArrayList<Estudiante> listarEstudiantesDelCursoProgramado(int idCursoProgramado, int idHorario);
    ArrayList<Asistencia> obtenerOListarAsistencias(int idHorario, Date fecha);
}
