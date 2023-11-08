/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.users.dao;

import java.util.ArrayList;
import org.lp2.astreiasoft.users.model.Rol;
import org.lp2.astreiasoft.users.model.Usuario;

/**
 *
 * @author mezav
 */
public interface RolDAO {
    
    ArrayList<Rol> listarTodas();
    
    ArrayList<Rol> listarRolesXUsuario(int idUsuario);
    
}
