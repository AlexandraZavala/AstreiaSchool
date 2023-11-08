package org.lp2.astreiasoft.eval.model;

import java.time.LocalTime;
import java.util.Date;

public class Bimestre {
    private int idBimestre;
    private String nombre;
    private Date inicioPeriodo;
    private Date finPeriodo;
    
    
    public Bimestre(){}

    public Bimestre(String nombre, Date inicioPeriodo, Date finPeriodo) {
        this.inicioPeriodo = inicioPeriodo;
        this.finPeriodo = finPeriodo;
        this.nombre=nombre;
    }

    public Date getInicioPeriodo() {
        return inicioPeriodo;
    }

    public void setInicioPeriodo(Date inicioPeriodo) {
        this.inicioPeriodo = inicioPeriodo;
    }

    public Date getFinPeriodo() {
        return finPeriodo;
    }

    public void setFinPeriodo(Date finPeriodo) {
        this.finPeriodo = finPeriodo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getIdBimestre() {
        return idBimestre;
    }

    public void setIdBimestre(int idBimestre) {
        this.idBimestre = idBimestre;
    }
    
    
}
