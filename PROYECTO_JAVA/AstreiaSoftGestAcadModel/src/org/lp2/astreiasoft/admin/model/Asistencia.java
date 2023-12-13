package org.lp2.astreiasoft.admin.model;

import org.lp2.astreiasoft.users.model.Estudiante;


import java.util.Date;
import org.lp2.astreiasoft.malla.model.Horario;

public class Asistencia {
    private int idAsistencia;
    private Estudiante estudiante;
    private Date fecha;
    private EstadoAsistencia estado;
    private String observaciones;
    private Horario horario;
    
    public Asistencia() {};

    public Asistencia(Estudiante estudiante, Date fecha, Horario horario,
                        EstadoAsistencia estado, String observaciones) {
        this.estudiante = estudiante;
        this.fecha = fecha;
        this.estado = estado;
        this.observaciones = observaciones;
        this.horario = horario;
    }
    
    public int getIdAsistencia() {
        return idAsistencia;
    }
    
    public void setIdAsistencia(int idAsistencia) {
        this.idAsistencia = idAsistencia;
    }
    
    public Estudiante getEstudiante() {
        return estudiante;
    }

    public void setEstudiante(Estudiante estudiante) {
        this.estudiante = estudiante;
    }
    
    public Horario getHorario() {
        return horario;
    }

    public void setHorario(Horario horario) {
        this.horario = horario;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public EstadoAsistencia getEstado() {
        return estado;
    }

    public void setEstado(EstadoAsistencia estado) {
        this.estado = estado;
    }

    public String getObservaciones() {
        return observaciones;
    }

    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }
    
    public void calculaPromedioAsistencia(){
        
    }
    
}
