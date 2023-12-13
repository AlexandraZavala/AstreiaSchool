package org.lp2.astreiasoft.admin.model;
import java.time.LocalTime;
import java.util.Date;

public class Evento {
    private int idEvento;
    private String nombre;
    private String descripcion;
    private String lugar;
    private Date fechaInicio; // Cambio en el nombre del campo
    private Date fechaFin; // Nuevo campo para fecha de fin
    
    public Evento() {}
    
    public Evento(String nombre, String descripcion, Date fechaInicio, Date fechaFin) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
    }

    public int getIdEvento() {
        return idEvento;
    }

    public void setIdEvento(int idEvento) {
        this.idEvento = idEvento;
    }
    
    public String getLugar() {
        return lugar;
    }
    
    public void setLugar(String lugar) {
        this.lugar = lugar;
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

    
    public void calificarEvento(){

    }
    public void generarCertificadoParticipacion(){
        
    }

    public void setFecha(java.sql.Date fechaSql) {
        this.fechaFin = new java.util.Date(fechaSql.getTime());
    }
    
    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }
}