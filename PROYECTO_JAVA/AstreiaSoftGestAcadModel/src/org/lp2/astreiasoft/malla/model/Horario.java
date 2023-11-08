package org.lp2.astreiasoft.malla.model;

import java.text.SimpleDateFormat;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.admin.model.Asistencia;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.users.model.Docente;

public class Horario {
    
    private int idHorario;
    private CursoProgramado cursoProgramado;
    private Docente docente;
    private String diaSemana;
    private LocalTime horaIni;
    private LocalTime horaFin;
    private Seccion seccion;
    
    private Boolean activo;
    private ArrayList<Asistencia> asistencias; //agregar import
    
    public Horario(){}

    public Horario(CursoProgramado cursoProgramado, Docente docente, String diaSemana, LocalTime horaIni, LocalTime horaFin, Seccion seccion) {
        this.docente = docente;
        this.cursoProgramado = cursoProgramado;
        this.diaSemana = diaSemana;
        this.horaIni = horaIni;
        this.horaFin = horaFin;
        this.seccion=seccion;
        
        
    }
    
    public int getIdHorario() {
        return idHorario;
    }

    public void setIdHorario(int idHorario) {
        this.idHorario = idHorario;
    }

    public Docente getDocente() {
        return docente;
    }

    public void setDocente(Docente docente) {
        this.docente = docente;
    }
    
    
    
    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }
    

    public CursoProgramado getCursoProgramado() {
        return cursoProgramado;
    }

    public void setCursoProgramado(CursoProgramado cursoProgramado) {
        this.cursoProgramado = cursoProgramado;
    }

    public String getDiaSemana() {
        return diaSemana;
    }

    public void setDiaSemana(String diaSemana) {
        this.diaSemana = diaSemana;
    }

    public LocalTime getHoraIni() {
        return horaIni;
    }

    public void setHoraIni(LocalTime horaIni) {
        this.horaIni = horaIni;
    }

    public LocalTime getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(LocalTime horaFin) {
        this.horaFin = horaFin;
    }

    public ArrayList<Asistencia> getAsistencias() {
        return asistencias;
    }

    public void setAsistencias(ArrayList<Asistencia> asistencias) {
        this.asistencias = asistencias;
    }

    public Seccion getSeccion() {
        return seccion;
    }

    public void setSeccion(Seccion seccion) {
        this.seccion = seccion;
    }

   
    
    public void obtenerDuracion(){

    }

    public void cambiarAula(){

    }
    public void solapamientoCon(){

    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        System.out.println(
            "ID del Horario: " + getIdHorario() + "\n" +
            "Descripción del Curso: " + getCursoProgramado().getDescripcion() + "\n" +
            "Nombre del Docente: " + getDocente().getNombre()+ "\n" +
            "Día de la Semana: " + getDiaSemana() + "\n" +
            //"Fecha: " + sdf.format(getFecha()) + "\n" +
            "Hora de Inicio: " + getHoraIni() + "\n" +
            "Hora de Fin: " + getHoraFin() + "\n" +
            "Nombre de la Sección: " + getSeccion().getNombre() + "\n" +
            "Nombre del Grado: " + getSeccion().getGrado().getNombre() + " - " + getSeccion().getGrado().getNivel()+ "\n"
        );
    }
}