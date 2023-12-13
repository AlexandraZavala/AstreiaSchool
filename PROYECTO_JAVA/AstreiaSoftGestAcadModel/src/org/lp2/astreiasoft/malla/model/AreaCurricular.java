package org.lp2.astreiasoft.malla.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class AreaCurricular {
    
    private int idAreaCurricular;
    private String nombre;
    
    private boolean activo;//se agrego porque hay DAO, si no hay DAO sacar
    private String descripcion;//se añadió esto, tmb Fecha de descripción se añade?
    private Date fechaCreacion;
    
    public AreaCurricular(){}
    
    public AreaCurricular(String nombre, String descripcion) {
        
        this.nombre = nombre;
        this.descripcion = descripcion;
        
    }

    public int getIdAreaCurricular() {
        return idAreaCurricular;
    }

    public void setIdAreaCurricular(int idAreaCurricular) {
        this.idAreaCurricular = idAreaCurricular;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String Descripcion) {
        this.descripcion = Descripcion;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        System.out.println(
            "ID: " + getIdAreaCurricular() + "\n" +
            "Nombre: " + getNombre() + "\n" +
            "Descripción: " + getDescripcion() + "\n" +
            "Fecha de Creación: " + sdf.format(getFechaCreacion()) + "\n\n"
            
        );
    }
}