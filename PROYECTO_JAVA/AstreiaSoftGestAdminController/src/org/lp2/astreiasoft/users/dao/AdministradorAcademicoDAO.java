/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.users.dao;
import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.AdministradorAcademico;

public interface AdministradorAcademicoDAO {
    int insertar(AdministradorAcademico adminAcad);
    int insertarUsuarioExiste(AdministradorAcademico adminAcad);
    int modificar(AdministradorAcademico adminAcad);
    int eliminar(int idAdminAcad);
    ArrayList<AdministradorAcademico> listarTodos(String nombreDNI);
}