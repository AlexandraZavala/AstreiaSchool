package org.lp2.astreiasoft.eval.model;
import java.util.Date;

public class NotaEvaluacion {
    private int idNotaEvaluacion;
    private Entrega entrega;    
    private int puntajeObtenido;
    private String detalle;
    private Date fecha;
    
    public NotaEvaluacion(){}
    
    public NotaEvaluacion(Entrega entrega, int puntajeObtenido, String detalle, Date fecha) {
        this.entrega = entrega;
        this.puntajeObtenido = puntajeObtenido;
        this.detalle = detalle;
        this.fecha = fecha;
    }

    public int getIdNotaEvaluacion() {
        return idNotaEvaluacion;
    }

    public void setIdNotaEvaluacion(int idNotaEvaluacion) {
        this.idNotaEvaluacion = idNotaEvaluacion;
    }

    public Entrega getEntrega() {
        return entrega;
    }

    public void setEntrega(Entrega entrega) {
        this.entrega = entrega;
    }
    
    public int getPuntajeObtenido() {
        return puntajeObtenido;
    }

    public void setPuntajeObtenido(int puntajeObtenido) {
        this.puntajeObtenido = puntajeObtenido;
    }

    public String getDetalle() {
        return detalle;
    }

    public void setDetalle(String detalle) {
        this.detalle = detalle;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public void asignarNota(){
        
    }
    
}