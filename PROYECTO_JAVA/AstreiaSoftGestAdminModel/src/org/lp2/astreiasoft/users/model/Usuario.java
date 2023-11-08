package org.lp2.astreiasoft.users.model;
import java.util.Date;

public class Usuario {
    
    private int idUsuario;
    private String DNI;
    private String nombre;
    private String apellidoPaterno;
    private String apellidoMaterno;
    private byte[] foto;
    private String correo;
    private String genero;
    private String telefono;
    private String contrasenha;
    private String direccion;
    private Date fechaNacimiento;
    private Date fechaRegistro;
    private Rol rol;
    
    public Usuario() {}
    
    public Usuario(String DNI, String nombre, String apellidoPaterno,
            String apellidoMaterno, byte[] foto,String correo, String genero, String telefono, 
            String contrasenha, String direccion, Date fechaNacimiento,
            Rol rol) {
        
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.foto = foto;
        this.correo = correo;
        this.contrasenha = contrasenha;
        this.fechaNacimiento = fechaNacimiento;
        this.DNI = DNI;
        this.telefono = telefono;
        this.direccion = direccion;
        this.genero = genero;
        this.rol = rol;
        
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int id) {
        this.idUsuario = id;
    }

    public String getNombre() {
        return nombre;
    }

    //
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }


    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String apellidoMaterno) {
        this.apellidoMaterno = apellidoMaterno;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }
    
    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getContrasenha() {
        return contrasenha;
    }

    public void setContrasenha(String contrasenha) {
        this.contrasenha = contrasenha;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public Rol getRol() {
        return rol;
    }

    public void setRol(Rol rol) {
        this.rol = rol;
    }

    public void iniciarSesion(){

    }

    public void cambiarContrasena(){

    }

    public void actualizarInformacion(){

    }

    public void recuperarContrasena(){

    }

    public void verNotificaciones(){

    }

    public void marcarNotificacionComoLeida(){

    }

    public void eliminarCuenta(){

    }

    public void verPerfil(){

    }

    public void cerrarSesion(){
        
    }

}
