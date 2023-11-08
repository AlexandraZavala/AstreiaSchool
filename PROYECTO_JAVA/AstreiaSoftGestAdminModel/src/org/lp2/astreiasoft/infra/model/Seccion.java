package org.lp2.astreiasoft.infra.model;

import java.text.SimpleDateFormat;
import org.lp2.astreiasoft.users.model.Estudiante;

import java.util.ArrayList;
import java.util.Date;

public class Seccion {

    private int idSeccion;
    private byte[] imagen;
    private String nombre;
    private boolean activo;
    private int anho;
    private Grado grado;
    private Aula aula;
    
   // private ArrayList<Estudiante> estudiantes;

    public Seccion(){
    }

    public Seccion(byte[] imagen, String nombre, int anho) {
        this.imagen = imagen;
        this.nombre = nombre;
        this.anho = anho;
    }

    
    
    public int getIdSeccion() {
        return idSeccion;
    }

    public void setIdSeccion(int idSeccion) {
        this.idSeccion = idSeccion;
    }
    
    
    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }


    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
     public int getAnho() {
        return anho;
    }

    public void setAnho(int anho) {
        this.anho = anho;
    }
    
    
    public Grado getGrado() {
        return grado;
    }

    public void setGrado(Grado grado) {
        this.grado = grado;
    }    
    public Aula getAula() {
        return aula;
    }

    public void setAula(Aula aula) {
        this.aula = aula;
    }


    public void obtenerEstudiantes(){

    }
    public void obtenerHorarios(){

    }

    public void calularPromedioSeccion(){
        
    }
    
    public void imprimirInformacion(){
        //SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdSeccion()+ " - " + getNombre()+ " - " + getImagen() +
                getAnho()+ " - " + getGrado().getIdGrado()+" - " + getGrado().getNombre() +" - " +getGrado().getNivel().name() );
    }
    
}
