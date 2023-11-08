package org.lp2.astreiasoft.infra.model;

import java.text.SimpleDateFormat;

public class Aula {
    private int idAula;    
    private String nombre;
    private int capacidad;
    private String codigo;
    private EstadoAula estado;
    private Seccion seccion;

    public Aula() {
    }
    
    public Aula( String nombre, int capacidad, String codigo,  EstadoAula estado) {
        this.nombre = nombre;
        this.capacidad = capacidad;
        this.codigo = codigo;
        this.estado = estado;
    }
    
        
    public int getIdAula() {
        return idAula;
    }

    public void setIdAula(int idAula) {
        this.idAula = idAula;
    }

    
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public EstadoAula getEstado() {
        return estado;
    }

    public void setEstado(EstadoAula estado) {
        this.estado = estado;
    }

    
    public Seccion getSeccion() {
        return seccion;
    }

    public void setSeccion(Seccion seccion) {
        this.seccion = seccion;
    }
    
    
    public void asignarNuevaAula(){
        
    }
    
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        System.out.println(getIdAula()+ " - " + getNombre()+ " - " +
                getCapacidad()+ " - " + getCodigo() +" - " + getEstado().name() );
    }
}
