/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.admin.dao;

import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.admin.model.Evento;

/**
 *
 * @author ricardomelendez
 */
public interface EventoDAO {
    int insertar(Evento area);
    int modificar(Evento area);
    int eliminar(int idArea);
    ArrayList<Evento> listarTodas();
    ArrayList<Evento> listarEventosPorNombreYFecha(String nombre, Date fechaInicio);
    ArrayList<Evento> listarEventosPorNombre(String nombre);
    ArrayList<Evento> listarEventosInscritosPorEstudiante(int idEstudiante);
    int inscribirEstudianteEnEvento(int idEstudiante, int idEvento);
    int cancelarInscripcionEvento(int idEstudiante, int idEvento);
}
