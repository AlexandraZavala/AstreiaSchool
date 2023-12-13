package org.lp2.astreiasoft.malla.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Material {
    
    private int idMaterial;
    private String nombre;
    private String descripcion;
    private CursoProgramado cursoProgramado;
    private byte[] archivo;
    private Date fechaModificacion;
    
    private boolean activo;
    
    public Material(){}
    
    public Material(String nombre, String descripcion, String link, Date fechaModificacion, CursoProgramado cursoProgramado) {
        
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.cursoProgramado = cursoProgramado;
        this.fechaModificacion=fechaModificacion;
        
    }

    public CursoProgramado getCursoProgramado() {
        return cursoProgramado;
    }

    public void setCursoProgramado(CursoProgramado cursoProgramado) {
        this.cursoProgramado = cursoProgramado;
    }
    
    
    
    public int getIdMaterial() {
        return idMaterial;
    }

    public void setIdMaterial(int idMaterial) {
        this.idMaterial = idMaterial;
    }

    public byte[] getArchivo() {
        return archivo;
    }

    public void setArchivo(byte[] archivo) {
        this.archivo = archivo;
    }
    
    

    public Date getFechaModificacion() {
        return fechaModificacion;
    }

    public void setFechaModificacion(Date fechaModificacion) {
        this.fechaModificacion = fechaModificacion;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }


    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
    
    public void subirMaterial(){

    }

    public void verMaterial(){

    }

    public void descargarMaterial(){
        
    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(
            "ID del Material: " + getIdMaterial() + "\n" +
            "ID del CursoProgramado: " + getCursoProgramado().getIdCursoProgramado()+ "\n" +        
            "Nombre: " + getNombre() + "\n" +
            "Descripción: " + getDescripcion() + "\n" +
            "Fecha de Modificación: " + sdf.format(getFechaModificacion()) + "\n"
        );
    }
    
}