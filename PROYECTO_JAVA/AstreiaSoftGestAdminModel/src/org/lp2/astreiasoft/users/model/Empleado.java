package org.lp2.astreiasoft.users.model;
import java.util.Date;

public class Empleado extends Usuario {
 
    private Date fechaContratacion;
    private double salario;
    
    public Empleado(){}
    public Empleado(String DNI, String nombre, String apellidoPaterno,
            String apellidoMaterno, byte[] foto, String correo, String genero, String telefono, 
            String contrasenha, String direccion, Date fechaNacimiento,
            Rol rol,
            Date fechaContratacion, double salario) {
        super( DNI,  nombre,  apellidoPaterno,
             apellidoMaterno, foto, correo,  genero,  telefono, 
             contrasenha,  direccion,  fechaNacimiento,
             rol);
        this.fechaContratacion = fechaContratacion;
        this.salario = salario;
        
    }


    public Date getFechaContratacion() {
        return fechaContratacion;
    }

    public void setFechaContratacion(Date fechaContratacion) {
        this.fechaContratacion = fechaContratacion;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public void iniciarContrato(){

    }

    public void finalizarContrato(){

    }

    public void evaluarDesempeño(){
        
    }
}
