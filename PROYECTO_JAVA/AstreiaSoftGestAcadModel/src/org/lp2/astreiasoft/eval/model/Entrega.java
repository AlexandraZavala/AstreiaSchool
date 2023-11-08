package org.lp2.astreiasoft.eval.model;
import org.lp2.astreiasoft.users.model.Estudiante;
import java.util.ArrayList;
import java.util.Date;

public class Entrega {
    private int idEntrega;
    private Estudiante estudiante;
    private Evaluacion evaluacion;
    private Date fechaEntrega;
    private Date fechaRevision;
    private EstadoEntrega estado;
    private String observaciones;
    private byte[] archivo;

    public Entrega(){}
    public Entrega(Estudiante estudiante, Evaluacion evaluacion, Date fechaSubida, Date fechaRevision,
                         EstadoEntrega estado, String observaciones, byte[] archivo) {
        this.estudiante = estudiante;
        this.evaluacion = evaluacion;
        this.fechaEntrega = fechaSubida;
        this.fechaRevision = fechaRevision;
        this.estado = estado;
        this.observaciones = observaciones;
        this.archivo = archivo;
    }

    public int getIdEntrega() {
        return idEntrega;
    }

    public void setIdEntrega(int idEntrega) {
        this.idEntrega = idEntrega;
    }

    public String getObservaciones() {
        return observaciones;
    }

    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }

    public Date getFechaRevision() {
        return fechaRevision;
    }

    public void setFechaRevision(Date fechaRevision) {
        this.fechaRevision = fechaRevision;
    }
    
    

    public byte[] getArchivo() {
        return archivo;
    }

    public void setArchivo(byte[] archivo) {
        this.archivo = archivo;
    }
    
    
    
    public Estudiante getEstudiante() {
        return estudiante;
    }

    public void setEstudiante(Estudiante estudiante) {
        this.estudiante = estudiante;
    }

    public Evaluacion getEvaluacion() {
        return evaluacion;
    }

    public void setEvaluacion(Evaluacion evaluacion) {
        this.evaluacion = evaluacion;
    }

    public Date getFechaEntrega() {
        return fechaEntrega;
    }

    public void setFechaEntrega(Date fechaSubida) {
        this.fechaEntrega = fechaSubida;
    }

    

    public EstadoEntrega getEstado() {
        return estado;
    }

    public void setEstado(EstadoEntrega estado) {
        this.estado = estado;
    }

    
    public void consultarEstadoEntrega(){

    }

    public void anularEntrega(){

    }

}
