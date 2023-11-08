package org.lp2.astreiasoft.eval.model;

import java.util.Date;

public class ReclamoCalificacion {
    
    private int idReclamoCalificacion;
    private NotaEvaluacion nota;
    private String descripcion;
    private Date fechaReclamo;
    private Date fechaRespuesta;
    private String respuesta;
    private EstadoEntrega estado;
    
    public ReclamoCalificacion(){}
    
    public ReclamoCalificacion(NotaEvaluacion nota, String descripcion, Date fechaReclamo, Date fechaRespuesta, String respuesta, EstadoEntrega estado) {
        
        this.nota = nota;
        this.descripcion = descripcion;
        this.fechaReclamo = fechaReclamo;
        this.fechaRespuesta = fechaRespuesta;
        this.respuesta = respuesta;   
        this.estado = estado;
    }

    public int getIdReclamoCalificacion() {
        return idReclamoCalificacion;
    }

    public void setIdReclamoCalificacion(int idReclamoCalificacion) {
        this.idReclamoCalificacion = idReclamoCalificacion;
    }
 
    public NotaEvaluacion getNota() {
        return nota;
    }

    public void setNota(NotaEvaluacion nota) {
        this.nota = nota;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Date getFechaReclamo() {
        return fechaReclamo;
    }

    public void setFechaReclamo(Date fechaReclamo) {
        this.fechaReclamo = fechaReclamo;
    }

    public Date getFechaRespuesta() {
        return fechaRespuesta;
    }

    public void setFechaRespuesta(Date fechaRespuesta) {
        this.fechaRespuesta = fechaRespuesta;
    }

    public String getRespuesta() {
        return respuesta;
    }

    public void setRespuesta(String respuesta) {
        this.respuesta = respuesta;
    }   

    public EstadoEntrega getEstado() {
        return estado;
    }

    public void setEstado(EstadoEntrega estado) {
        this.estado = estado;
    }
}