/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.admin.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.admin.model.Inscripcion;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.users.model.Estudiante;
import org.lp2.astreiasoft.users.model.Usuario;

/**
 *
 * @author ricardomelendez
 */
public interface InscripcionDAO {
    int insertar(Inscripcion area);
    int modificar(Inscripcion area);
    int eliminar(int idArea);
    ArrayList<Inscripcion> listarTodas();
    ArrayList<Usuario> listarHijosDePadre(int idPadre);
    int insertarEstudiante(Estudiante estudiante);
    ArrayList<Inscripcion> listarPorPadre(int idPadre);
    ArrayList<Inscripcion> listarPorPadreEstudiante(int idPadre, int idEstudiante);
    int actualizarEstudiante(Estudiante estudiante);
    int actualizarInscripcion(Inscripcion inscripcion);
    ArrayList<Inscripcion> listarPreinscripciones();
    ArrayList<Inscripcion> listarPreinscripcionesPorEstado(String estado);
    ArrayList<Grado> listarGradosActivos();
}
