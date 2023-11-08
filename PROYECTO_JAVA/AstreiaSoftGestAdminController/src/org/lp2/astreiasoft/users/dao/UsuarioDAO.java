/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package org.lp2.astreiasoft.users.dao;

import org.lp2.astreiasoft.users.model.Usuario;

public interface UsuarioDAO {
    Usuario Encontrar(String DNI);
    int editar(Usuario usuario);
    int verificarUsuario(String correo, String password);
    int asignarRolUsuario(Usuario usuario);
}
