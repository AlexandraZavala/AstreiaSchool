package org.lp2.astreiasoft.users.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Docente extends Empleado {

    private String especialidad;
    private boolean activo;
    //private ArrayList<Asignatura> cursos;
    
    public Docente(){}
    

    public Docente(String DNI, String nombre, String apellidoPaterno, 
            String apellidoMaterno, byte[] foto, String correo, String genero, 
            String telefono, String contrasenha, String direccion, 
            Date fechaNacimiento, Rol rol, //USUARIO
            Date fechaContratacion, double salario,  //EMPLEADO
            String especialidad) { //DOCENTE) 
        super(DNI,  nombre,  apellidoPaterno,
             apellidoMaterno, foto, correo, genero, 
             telefono, contrasenha, direccion,  
             fechaNacimiento, rol,
             fechaContratacion,  salario);
        
        this.especialidad = especialidad;

    }

    private Docente(String DNI, String nombre, String apellidoPaterno, String apellidoMaterno, String correo, String genero, String telefono, String contrasenha, String direccion, Date fechaNacimiento, Rol rol, Date fechaContratacion, double salario) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }


    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
    

    public void asignarTareaSeccion(){

    }

    public void asignarAsistenciaAlumno(){

    }

    public void modificarAsistenciaAlumno(){

    }

    public void eliminarRecursoCurso(){

    }

    public void crearTarea(){

    }

    public void eliminarTareaSeccion(){

    }

    public void asignarNotaEvaluacion(){

    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdUsuario() + ". " + getDNI() + " - " +
                getNombre() + " " + getApellidoPaterno() + " " + getApellidoMaterno() +
                " - " + getCorreo() + " - " + getGenero() + "  telf: "+getTelefono()+
                " - "+ getDireccion() + " FN: " + sdf.format(getFechaNacimiento()) +
                " FR: " + getFechaRegistro() + "  Fecha Entro: " +getFechaContratacion()+
                " - " + getSalario()+ "  -Esp: "+especialidad);
    }
    
}
