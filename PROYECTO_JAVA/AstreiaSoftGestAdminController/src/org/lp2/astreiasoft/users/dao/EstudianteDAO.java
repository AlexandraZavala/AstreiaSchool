/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.users.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.Estudiante;

public interface EstudianteDAO {
    int insertar(Estudiante estudiante);
    int modificar(Estudiante estudiante);
    int eliminar(int idEstudiante);
    ArrayList<Estudiante> listarTodos(String nombreDNI);
    //FRANK
    ArrayList<Estudiante> listarEstudianteXGrado(int idGrado) ;
    ArrayList<Estudiante> listarEstudiantesXSeccion(int idSeccion);
    
    int asignarSeccionAEstudiante(int idEstudiante, int idSeccion);
    int quitarSeccionDeEstudiante(int idEstudiante);
}
