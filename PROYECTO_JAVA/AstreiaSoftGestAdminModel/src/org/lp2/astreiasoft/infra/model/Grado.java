package org.lp2.astreiasoft.infra.model;

import java.text.SimpleDateFormat;
import org.lp2.astreiasoft.users.model.Estudiante;

import java.util.ArrayList;
import java.util.Date;

public class Grado {

    private int idGrado;
    private String nombre;
    private Date fechaCreacion;
    private NivelEducativo nivel;
    private boolean activo;
    private String nombreCompleto;

    private ArrayList<Estudiante> estudiantes;

    public Grado() {
    }

    public Grado(String nombre, NivelEducativo nivel) {
        this.nombre = nombre;
        this.nivel = nivel;
    }

    public String getNombreCompleto() {
        return nombreCompleto;
    }

    public void setNombreCompleto(String nombreCompleto) {
        this.nombreCompleto = nombreCompleto;
    }
    
    
    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }
     
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public int getIdGrado() {
        return idGrado;
    }

    public void setIdGrado(int idGrado) {
        this.idGrado = idGrado;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public NivelEducativo getNivel() {
        return nivel;
    }

    public void setNivel(NivelEducativo nivel) {
        this.nivel = nivel;
    }

    public ArrayList<Estudiante> getEstudiantes() {
        return estudiantes;
    }

    public void setEstudiantes(ArrayList<Estudiante> estudiantes) {
        this.estudiantes = estudiantes;
    }

    
    
    public void calcularCantidadAlumnos() {

    }

    public void calcularPromedioGrado() {

    }
    
    
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdGrado()+ " - " + getNombre()+ " - " +
                getNivel()+ " - " + getNivel().name() + " - " + sdf.format(getFechaCreacion())+ " - " +
        isActivo());
    }
    
    

}
