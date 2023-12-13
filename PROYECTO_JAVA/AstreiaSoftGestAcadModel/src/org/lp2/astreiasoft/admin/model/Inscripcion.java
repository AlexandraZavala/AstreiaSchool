package org.lp2.astreiasoft.admin.model;
import org.lp2.astreiasoft.users.model.Estudiante;

import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.users.model.PadreFamilia;


public class Inscripcion {

    private int idInscripcion;
    private String estado;
    private Date fecha;
    private byte[] imagen;
    private Matricula matricula;
    private Estudiante estudiante;
    private PadreFamilia padreFamilia;
    private String periodoAcademico; // Adding this new field
    private boolean esNuevo;

    // Constantes para los valores del campo estado.
    public static final String PRE_INSCRITO = "Pre-Inscrito";
    public static final String INSCRITO = "Inscrito";
    public static final String RECHAZADO = "Rechazado";

    public Inscripcion() {}
    
    public Inscripcion(Date fecha, byte[] imagen, Matricula matricula, Estudiante estudiante) {
        this.estado = PRE_INSCRITO; // Valor por defecto
        this.fecha = fecha;
        this.imagen = imagen;
        this.matricula = matricula;
        this.estudiante = estudiante;
    }
    
    public String getPeriodoAcademico() {
        return periodoAcademico;
    }

    public void setPeriodoAcademico(String periodoAcademico) {
        this.periodoAcademico = periodoAcademico;
    }
    
    public boolean getEsNuevo() {
        return esNuevo;
    }

    public void setEsNuevo(boolean esNuevo) {
        this.esNuevo = esNuevo;
    }

    public int getIdInscripcion() {
        return idInscripcion;
    }

    public void setIdInscripcion(int idInscripcion) {
        this.idInscripcion = idInscripcion;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        if (estado.equals(PRE_INSCRITO) || estado.equals(INSCRITO) || estado.equals(RECHAZADO)) {
            this.estado = estado;
        } else {
            throw new IllegalArgumentException("Valor de estado inválido.");
        }
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public Matricula getMatricula() {
        return matricula;
    }

    public void setMatricula(Matricula matricula) {
        this.matricula = matricula;
    }

    public Estudiante getEstudiante() {
        return estudiante;
    }

    public void setEstudiante(Estudiante estudiante) {
        this.estudiante = estudiante;
    }
    
    public PadreFamilia getPadre() {
        return padreFamilia;
    }

    public void setPadre(PadreFamilia padreFamilia) {
        this.padreFamilia = padreFamilia;
    }
}
