package org.lp2.astreiasoft.users.model;
import java.text.SimpleDateFormat;
import java.util.Date;

public class AdministradorAcademico extends Empleado {
    private boolean activo;
    private String experiencia; 

    public AdministradorAcademico(){};
    public AdministradorAcademico(String DNI, String nombre, String apellidoPaterno, String apellidoMaterno, byte[] foto, String correo, String genero, String telefono,
            String contrasenha, String direccion, Date fechaNacimiento, Rol rol,   //USUARIO
            Date fechaContratacion, double salario,  //EMPLEADO
            String experiencia) //Administrador
    {  
        super(DNI,  nombre,  apellidoPaterno,
             apellidoMaterno, foto, correo, genero, 
             telefono, contrasenha, direccion,  
             fechaNacimiento, rol,
             fechaContratacion,  salario);
        
        this.experiencia = experiencia;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    public String getExperiencia() {
        return experiencia;
    }

    public void setExperiencia(String experiencia) {
        this.experiencia = experiencia;
    }
    
    public void aprobarMatricula(){

    }
    public void asignarCursosProgramados(){

    }

    public void asignarDocentesCursos(){

    }

    public void asignarEstudiantesCursos(){

    }

    public void gestionarEventos(){
        
    }
    
    public void imprimirInformacion() {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdUsuario() + ". " + getDNI() + " - " +
                getNombre()+ " " + getApellidoPaterno() + " - " +
                getGenero() + " - " + sdf.format(getFechaNacimiento()) +
                " - " + sdf.format(getFechaContratacion()) + 
                " - "  + getSalario() + " - " + getExperiencia());
    }
    
    
   
}
