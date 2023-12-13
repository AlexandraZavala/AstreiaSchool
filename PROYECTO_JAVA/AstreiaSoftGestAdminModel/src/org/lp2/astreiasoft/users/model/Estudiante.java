package org.lp2.astreiasoft.users.model;
import java.text.SimpleDateFormat;
import org.lp2.astreiasoft.infra.model.Aula;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.Seccion;

import java.util.Date;

public class Estudiante extends Usuario{
    private int idEstudiante;
    private Grado grado;
    private Seccion seccion;
    private Aula aula;
    private PadreFamilia padre;
    private boolean activo;
	private String nombreCompleto;
    
    public Estudiante(){}
    
    public Estudiante(String DNI, String nombre, String apellidoPaterno, 
            String apellidoMaterno,byte[] foto, String correo, String genero, 
            String telefono, String contrasenha, String direccion, 
            Date fechaNacimiento, Rol rol, //USUARIO
            Grado grado, PadreFamilia padre, Aula aula, Seccion seccion) //ESTUDIANTE
    {
        super(DNI,  nombre,  apellidoPaterno,  apellidoMaterno,foto,  correo,  genero,  telefono,
             contrasenha,  direccion,  fechaNacimiento,  rol);
        this.grado = grado;
        this.padre = padre;
        this.aula = aula;
        this.seccion = seccion;
    }

    public int getIdEstudiante() {
        return idEstudiante;
    }

    public void setIdEstudiante(int id) {
        this.idEstudiante = id;
    }
	
	public String getNombreCompleto() {
        return nombreCompleto;
    }

    public void setNombreCompleto(String nombreCompleto) {
        this.nombreCompleto = nombreCompleto;
    }
    
    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public Grado getGrado() {
        return grado;
    }

    public void setGrado(Grado grado) {
        this.grado = grado;
    }

    public Seccion getSeccion() {
        return seccion;
    }

    public void setSeccion(Seccion seccion) {
        this.seccion = seccion;
    }

    public Aula getAula() {
        return aula;
    }

    public void setAula(Aula aula) {
        this.aula = aula;
    }
    
    public PadreFamilia getPadre() {
        return padre;
    }

    public void setPadre(PadreFamilia padre) {
        this.padre = padre;
    }
    
    public void imprimirInformacion() {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdUsuario() + ". " + getDNI() + " - " +
                getNombre()+ " " + getApellidoPaterno() + " - " +
                getGenero() + " - " + sdf.format(getFechaNacimiento()) );
    }
    
    
    public void verHorario() {}
    public void verCalificaciones() {}
    public void crearReclamo(int idTarea, String reclamo) {}
   
}
