package org.lp2.astreiasoft.eval.model;
import org.lp2.astreiasoft.users.model.Docente;
import java.util.ArrayList;
import java.util.Date;
import org.lp2.astreiasoft.malla.model.CursoProgramado;

public class Evaluacion {
    
    private int idEvaluacion;
    private String descripcion;
    private Date fechaSubido;
    private Date fechaLimite;
    private Docente docente;    
    private Bimestre bimestre;
    private CursoProgramado cursoProgramado;
    private double nota;
    private TipoEvaluacion tipo;
    private Boolean activo;
    private ArrayList<Entrega> entregas;
    private Date fechaCreacion;
    private Date fechaModificacion;
    
    public Evaluacion() {
    }
    
    public Evaluacion(String descripcion, Date fechaSubido, 
                        Date fechaLimite, Docente docente, Bimestre bimestre, CursoProgramado cursoProgramado,
                        double nota, TipoEvaluacion tipo, Boolean activo, Date fechaCreacion, Date fechaModificacion) {
        
        this.descripcion = descripcion;
        this.fechaSubido = fechaSubido;
        this.fechaLimite = fechaLimite;
        this.docente = docente;
        this.nota = nota;
        this.tipo = tipo;
        this.bimestre = bimestre;
        this.cursoProgramado = cursoProgramado;
        this.activo = activo; //SE TIENE QUE QUITAR
        this.fechaCreacion = fechaCreacion; //SE TIENE QUE QUITAR
        this.fechaModificacion = fechaModificacion; //SE TIENE QUE QUITAR
        this.tipo = tipo;
    }

    public int getIdEvaluacion() {
        return idEvaluacion;
    }

    public void setIdEvaluacion(int idEvaluacion) {
        this.idEvaluacion = idEvaluacion;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }

    
    public Bimestre getBimestre() {
        return bimestre;
    }

    public void setBimestre(Bimestre bimestre) {
        this.bimestre = bimestre;
    }

    public CursoProgramado getCursoProgramado() {
        return cursoProgramado;
    }

    public void setCursoProgramado(CursoProgramado cursoProgramado) {
        this.cursoProgramado = cursoProgramado;
    }


    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Docente getDocente() {
        return docente;
    }

    public void setDocente(Docente docente) {
        this.docente = docente;
    }

    public Date getFechaSubido() {
        return fechaSubido;
    }

    public void setFechaSubido(Date fechaSubido) {
        this.fechaSubido = fechaSubido;
    }

    public Date getFechaLimite() {
        return fechaLimite;
    }

    public void setFechaLimite(Date fechaLimite) {
        this.fechaLimite = fechaLimite;
    }

    public double getNota() {
        return nota;
    }

    public void setNota(double nota) {
        this.nota = nota;
    }

    public TipoEvaluacion getTipo() {
        return tipo;
    }

    public void setTipo(TipoEvaluacion tipo) {
        this.tipo = tipo;
    }

    public ArrayList<Entrega> getEntregas() {
        return entregas;
    }

    public void setEntregas(ArrayList<Entrega> entregas) {
        this.entregas = entregas;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Date getFechaModificacion() {
        return fechaModificacion;
    }

    public void setFechaModificacion(Date fechaModificacion) {
        this.fechaModificacion = fechaModificacion;
    }
}
