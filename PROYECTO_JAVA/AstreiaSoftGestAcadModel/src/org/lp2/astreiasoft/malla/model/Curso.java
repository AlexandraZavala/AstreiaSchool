package org.lp2.astreiasoft.malla.model;
import java.text.SimpleDateFormat;
import java.util.Date;
import org.lp2.astreiasoft.infra.model.Grado;

public class Curso {

    
    private int idCurso;

    
    private byte[] imagen;
    private int horasSemanales;
    private String descripcion;
    private String codigo;
    private String nombre;
    private Date fechaCreacion;
    private Date fechaModificacion;
    private boolean activo;
    private Grado grado;
    private AreaCurricular areaCurricular;
    private String nombreGrado;
    
    public Curso(){}

    public Curso(byte[] imagen, String nombre, String descripcion,int horasSemanale, Grado grado, AreaCurricular areaCurricular) {
        
        this.imagen = imagen;
        this.descripcion = descripcion;
        this.horasSemanales=horasSemanale;
        //this.codigo = codigo;
        this.grado=grado;
        this.nombre = nombre;
        this.areaCurricular=areaCurricular;
        
    }

    public String getNombreGrado() {
        return nombreGrado;
    }

    public void setNombreGrado(String nombreGrado) {
        this.nombreGrado = nombreGrado;
    }
    
    
    public int getIdCurso() {
        return idCurso;
    }

    public void setIdCurso(int idCurso) {
        this.idCurso = idCurso;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }
    
    
    public AreaCurricular getAreaCurricular() {
        return areaCurricular;
    }

    public void setAreaCurricular(AreaCurricular areaCurricular) {
        this.areaCurricular = areaCurricular;
    }
    
    
    
    public Grado getGrado() {
        return grado;
    }

    public void setGrado(Grado grado) {
        this.grado = grado;
    }
    
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
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

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public int getHorasSemanales() {
        return horasSemanales;
    }

    public void setHorasSemanales(int horasSemanales) {
        this.horasSemanales = horasSemanales;
    }

    public void imprimirInformacion(){
        System.out.println(
            "ID del Curso: " + getIdCurso() + "\n" +
            "Imagen: " + getImagen() + "\n"+
            "Nombre del Curso: " + getNombre() + "\n" +
            "Descripción del Curso: " + getDescripcion() + "\n" +
            "Horas Semanales: " + getHorasSemanales() + "\n\n"
            
        );
    }
    
}
