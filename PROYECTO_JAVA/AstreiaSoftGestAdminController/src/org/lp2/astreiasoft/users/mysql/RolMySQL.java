/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.lp2.astreiasoft.users.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import org.lp2.astreiasoft.config.DBManager;
import org.lp2.astreiasoft.users.dao.RolDAO;
import org.lp2.astreiasoft.users.model.NombreRol;
import org.lp2.astreiasoft.users.model.Rol;
import org.lp2.astreiasoft.users.model.Usuario;

/**
 *
 * @author mezav
 */
public class RolMySQL implements RolDAO{
    
    
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<Rol> listarTodas() {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ROLES_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Rol rol = new Rol();
                rol.setIdRol(rs.getInt("id_rol"));
                rol.setNombre(NombreRol.valueOf(rs.getString("NombreRol")));
                
                roles.add(rol);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return roles;
    }
    
    
    
    
    @Override
    public ArrayList<Rol> listarRolesXUsuario(int idUsuario) {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ROLES_X_USUARIO(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            while (rs.next()) {
                Rol rol = new Rol();
                rol.setIdRol(rs.getInt("id_rol"));
                rol.setNombre(NombreRol.valueOf(rs.getString("NombreRol")));
                
                roles.add(rol);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return roles;
    }
    
    
    
    
}
