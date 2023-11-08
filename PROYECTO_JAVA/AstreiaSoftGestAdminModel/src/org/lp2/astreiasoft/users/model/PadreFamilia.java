package org.lp2.astreiasoft.users.model;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class PadreFamilia extends Usuario{
    private ArrayList<Estudiante> hijos;
    private int numeroHijos;
    private boolean activo;
    
    
    public PadreFamilia(){}
    
    public PadreFamilia(String DNI, String nombre, String apellidoPaterno, 
            String apellidoMaterno, byte[] foto, String correo, String genero, 
            String telefono, String contrasenha, String direccion, 
            Date fechaNacimiento, Rol rol, 
            int numeroHijos) {
        super(DNI,  nombre,  apellidoPaterno,  apellidoMaterno,  foto, correo,  genero,  telefono,
             contrasenha,  direccion,  fechaNacimiento,  rol);
        
        this.numeroHijos=numeroHijos;
    }

    public int getNumeroHijos() {
        return numeroHijos;
    }

    public void setNumeroHijos(int numeroHijos) {
        this.numeroHijos = numeroHijos;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
    
    
    public ArrayList<Estudiante> getHijos() {
        return hijos;
    }

    public void setHijos(ArrayList<Estudiante> hijos) {
        this.hijos = hijos;
    }
    
    public void agregarHijo(Estudiante estudiante) {
        hijos.add(estudiante);
    }

    public void eliminarHijo(Estudiante estudiante) {
        hijos.remove(estudiante);
    }

    public void verCalificacionesHijo(Estudiante estudiante) {
        // Aquí se podría acceder al historial de calificaciones del estudiante
        // y mostrarlas.
    }

    public void verHorarioHijo(Estudiante estudiante) {
        // Aquí se podría acceder al horario de clases del estudiante
        // y mostrarlo.
    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdUsuario() + ". " + getDNI() + " - " +
                getNombre() + " " + getApellidoPaterno() + " " + getApellidoMaterno() +
                " - " + getCorreo() + " - " + getGenero() + "  telf: "+ getTelefono()+
                " -- "+ getDireccion() + " FN: " + sdf.format(getFechaNacimiento()) +
                "  FR: " + sdf.format(getFechaRegistro()) + "  Hijo: "+numeroHijos);
    }
}
