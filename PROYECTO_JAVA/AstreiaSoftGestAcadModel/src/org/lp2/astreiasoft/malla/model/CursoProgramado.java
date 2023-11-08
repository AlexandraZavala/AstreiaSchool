package org.lp2.astreiasoft.malla.model;

import java.text.SimpleDateFormat;
import org.lp2.astreiasoft.users.model.Docente;
import org.lp2.astreiasoft.users.model.Estudiante;

import org.lp2.astreiasoft.eval.model.Evaluacion;

import java.util.ArrayList;
import java.util.Date;

public class CursoProgramado {

    private int idCursoProgramado;
    private String descripcion;
    private int anho;
    private ArrayList<Material> materiales;
    private ArrayList<Estudiante> estudiantes;
    private ArrayList<Docente> docentes;
    private ArrayList<Evaluacion> areas;
    //private ArrayList<Curso> cursos;
    private boolean activo;
    private Curso curso;

    public CursoProgramado() {
    }

    public CursoProgramado(String descripcion, int anho, Curso curso) {

        this.descripcion = descripcion;
        this.anho = anho;
        this.curso = curso;

    }

    public int getIdCursoProgramado() {
        return idCursoProgramado;
    }

    public void setIdCursoProgramado(int idCursoProgramado) {
        this.idCursoProgramado = idCursoProgramado;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getAnho() {
        return anho;
    }

    public void setAnho(int anho) {
        this.anho = anho;
    }

    public ArrayList<Material> getMateriales() {
        return materiales;
    }

    public void setMateriales(ArrayList<Material> materiales) {
        this.materiales = materiales;
    }

    public ArrayList<Estudiante> getEstudiantes() {
        return estudiantes;
    }

    public void setEstudiantes(ArrayList<Estudiante> estudiantes) {
        this.estudiantes = estudiantes;
    }

    public ArrayList<Docente> getDocentes() {
        return docentes;
    }

    public void setDocentes(ArrayList<Docente> docentes) {
        this.docentes = docentes;
    }

    public ArrayList<Evaluacion> getAreas() {
        return areas;
    }

    public void setAreas(ArrayList<Evaluacion> areas) {
        this.areas = areas;
    }

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public void imprimirInformacion() {

        System.out.println(
                "ID del Curso Programado: " + getIdCursoProgramado() + "\n"
                + "ID del Curso: " + getCurso().getIdCurso()+ "\n"
                + "Descripción: " + getDescripcion() + "\n"
                + "Año: " + getAnho() + "\n\n"
        );
    }

}
