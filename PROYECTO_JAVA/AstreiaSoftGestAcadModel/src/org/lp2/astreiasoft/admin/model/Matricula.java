package org.lp2.astreiasoft.admin.model;

import java.util.ArrayList;
import java.util.Date;

public class Matricula {
    private int idMatricula;
    private Date fechaInicio;
    private Date fechaFin;
    private String estado;
    private double monto;
    
    public Matricula() {};
    
    public Matricula(Date fechaInicio, Date fechaFin, String estado, double monto) {
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
        this.estado = estado;
        this.monto = monto;
    }

    public int getIdMatricula() {
        return idMatricula;
    }

    public void setIdMatricula(int idMatricula) {
        this.idMatricula = idMatricula;
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

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public double getMonto() {
        return monto;
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }

//    public ArrayList<Inscripcion> getInscripciones() {
//        return inscripciones;
//    }
//
//    public void setInscripciones(ArrayList<Inscripcion> inscripciones) {
//        this.inscripciones = inscripciones;
//    }
}
