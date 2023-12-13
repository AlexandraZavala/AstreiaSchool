package org.lp2.astreiasoft.users.model;
public class Rol {
    private int idRol;
    private NombreRol nombre;
    private boolean activo;
    
    
    public Rol(){}

    public Rol(NombreRol nombre) {
        this.nombre = nombre;
    }

    public int getIdRol() {
        return idRol;
    }

    public void setIdRol(int idRol) {
        this.idRol = idRol;
    }

    public NombreRol getNombre() {
        return nombre;
    }

    public void setNombre(NombreRol nombre) {
        this.nombre = nombre;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    
    public void imprimirInformacion(){
        System.out.println(getIdRol()+ " - " + getNombre().name());
    }
    
    
    
    
}
