/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.lp2.astreiasoft.services.gestadmin;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.lp2.astreiasoft.users.dao.AdministradorAcademicoDAO;
import org.lp2.astreiasoft.users.dao.DocenteDAO;
import org.lp2.astreiasoft.users.dao.EstudianteDAO;
import org.lp2.astreiasoft.users.dao.PadreFamiliaDAO;
import org.lp2.astreiasoft.users.dao.RolDAO;
import org.lp2.astreiasoft.users.dao.UsuarioDAO;
import org.lp2.astreiasoft.users.model.AdministradorAcademico;
import org.lp2.astreiasoft.users.model.Docente;
import org.lp2.astreiasoft.users.model.Estudiante;
import org.lp2.astreiasoft.users.model.PadreFamilia;
import org.lp2.astreiasoft.users.model.Rol;
import org.lp2.astreiasoft.users.model.Usuario;
import org.lp2.astreiasoft.users.mysql.AdministradorAcademicoMySQL;
import org.lp2.astreiasoft.users.mysql.DocenteMySQL;
import org.lp2.astreiasoft.users.mysql.EstudianteMySQL;
import org.lp2.astreiasoft.users.mysql.PadreFamiliaMySQL;
import org.lp2.astreiasoft.users.mysql.RolMySQL;
import org.lp2.astreiasoft.users.mysql.UsuarioMySQL;

/**
 *
 * @author mezav
 */
@WebService(serviceName = "UserWS")
public class UserWS {

    private RolDAO daoRol = new RolMySQL();
    private UsuarioDAO daoUsuario = new UsuarioMySQL();
    
    
    @WebMethod(operationName = "listarRolesTodos") 
    public ArrayList<Rol> listarRolesTodos() {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            roles = daoRol.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return roles;
    }
    
    @WebMethod(operationName = "verificarCuentaUsuario") 
    public int verificarCuentaUsuario(String user, String password) {
        int resultado = 0;
        try {
            resultado = daoUsuario.verificarUsuario(user, password);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarRolesDeUsuario") 
    public ArrayList<Rol> verificarRolesDeUsuario(int idUsuario) {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            roles = daoRol.listarRolesXUsuario(idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return roles;
    }
    
    /////Usuario
    @WebMethod(operationName = "encontrarUsuario")
    public Usuario
        encontrarUsuario(@WebParam(name = "IdDNI")String IdDNI) {
        Usuario usuario = new Usuario();
        try {
            usuario = daoUsuario.Encontrar(IdDNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return usuario;
    }
        
    @WebMethod(operationName = "editarPerfil")
    public int editarPerfil(@WebParam(name = "usuario") 
            Usuario usuario) {
        int resultado = 0;
        try {
            resultado = daoUsuario.editar(usuario);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }    
        
    /////////ADMINISTRADOR
    private AdministradorAcademicoDAO daoAdministrador = new AdministradorAcademicoMySQL();
    
    @WebMethod(operationName = "insertarAdministrador")
    public int insertarAdministrador(@WebParam(name = "administrador")
            AdministradorAcademico administrador){
        int resultado = 0;
        try{
            resultado = daoAdministrador.insertar(administrador);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    } 
    
    @WebMethod(operationName = "insertarAdministradorUsuarioExiste")
    public int insertarAdministradorUsuarioExiste(@WebParam(name = "administrador")
            AdministradorAcademico administrador){
        int resultado = 0;
        try{
            resultado = daoAdministrador.insertarUsuarioExiste(administrador);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    } 
        
    @WebMethod(operationName = "modificarAdministrador")
    public int modificarAdministrador(@WebParam(name = "administrador") 
            AdministradorAcademico administrador) {
        int resultado = 0;
        try {
            resultado = daoAdministrador.modificar(administrador);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAdministrador")
    public int eliminarAdministrador(@WebParam(name = "idAdministrador") 
            int idAdministrador) {
        int resultado = 0;
        try {
            resultado = daoAdministrador.eliminar(idAdministrador);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosAdministradoresAcademicosPorNombreDNI")
    public ArrayList<AdministradorAcademico> 
        listarTodosAdministradoresAcademicosPorNombreDNI(@WebParam(name = "nombre")String nombreDNI) {
        ArrayList<AdministradorAcademico> administradores = new ArrayList<>();
        try {
            administradores = daoAdministrador.listarTodos(nombreDNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return administradores;
    }
    
        
    /////////ESTUDIANTE
    private EstudianteDAO daoEstudiante = new EstudianteMySQL();
    
    @WebMethod(operationName = "insertarEstudiante")
    public int insertarEstudiante(@WebParam(name = "estudiante")
            Estudiante estudiante){
        int resultado = 0;
        try{
            resultado = daoEstudiante.insertar(estudiante);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    } 
    
    @WebMethod(operationName = "modificarEstudiante")
    public int modificarEstudiante(@WebParam(name = "estudiante") 
            Estudiante estudiante) {
        int resultado = 0;
        try {
            resultado = daoEstudiante.modificar(estudiante);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarEstudiante")
    public int eliminarEstudiante(@WebParam(name = "idEstudiante") 
            int idEstudiante) {
        int resultado = 0;
        try {
            resultado = daoEstudiante.eliminar(idEstudiante);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosEstudiantesPorNombreDNI")
    public ArrayList<Estudiante> 
        listarTodosEstudiantesPorNombreDNI(@WebParam(name = "nombre")String nombreDNI) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            estudiantes = daoEstudiante.listarTodos(nombreDNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return estudiantes;
    }
        
    /////////DOCENTES
    private DocenteDAO daoDocente = new DocenteMySQL();
    
    @WebMethod(operationName = "insertarDocente")
    public int insertarDocente(@WebParam(name = "docente")
            Docente docente){
        int resultado = 0;
        try{
            resultado = daoDocente.insertar(docente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    } 
    
    @WebMethod(operationName = "insertarDocenteUsuarioExiste")
    public int insertarDocenteUsuarioExiste(@WebParam(name = "docente")
            Docente docente){
        int resultado = 0;
        try{
            resultado = daoDocente.insertarUsuarioExiste(docente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "modificarDocente")
    public int modificarDocente(@WebParam(name = "docente") 
            Docente docente) {
        int resultado = 0;
        try {
            resultado = daoDocente.modificar(docente);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarDocente")
    public int eliminarDocente(@WebParam(name = "idDocente") 
            int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.eliminar(idDocente);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosDocentesPorNombreDNI")
    public ArrayList<Docente> 
        listarTodosDocentesPorNombreDNI(@WebParam(name = "nombreDNI")String nombreDNI) {
        ArrayList<Docente> docentes = new ArrayList<>();
        try {
            docentes = daoDocente.listarTodos(nombreDNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return docentes;
    }  
	
	/***********************NUEVO******************************/ 
    @WebMethod(operationName = "listarTodosDocentesCursos")
    public ArrayList<Docente> 
        listarTodosDocentesCursos() {
        ArrayList<Docente> docentes = new ArrayList<>();
        try {
            docentes = daoDocente.listarTodosDocentesCursos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return docentes;
    }
    /**********************************************************/ 
        
    /////////PADREFAMILIA
    private PadreFamiliaDAO daoPadreFamilia = new PadreFamiliaMySQL();
    
    @WebMethod(operationName = "insertarPadreFamilia")
    public int insertarPadreFamilia(@WebParam(name = "padreFamilia")
            PadreFamilia padreFamilia){
        int resultado = 0;
        try{
            resultado = daoPadreFamilia.insertar(padreFamilia);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    } 
    
    @WebMethod(operationName = "insertarPadreFamiliaUsuarioExiste")
    public int insertarPadreFamiliaUsuarioExiste(@WebParam(name = "padreFamilia")
            PadreFamilia padreFamilia){
        int resultado = 0;
        try{
            resultado = daoPadreFamilia.insertarUsuarioExiste(padreFamilia);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "modificarPadreFamilia")
    public int modificarPadreFamilia(@WebParam(name = "padreFamilia") 
            PadreFamilia padreFamilia) {
        int resultado = 0;
        try {
            resultado = daoPadreFamilia.modificar(padreFamilia);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPadreFamilia")
    public int eliminarPadreFamilia(@WebParam(name = "idPadreFamilia") 
            int idPadreFamilia) {
        int resultado = 0;
        try {
            resultado = daoPadreFamilia.eliminar(idPadreFamilia);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosPadresFamiliaPorNombreDNI")
    public ArrayList<PadreFamilia> 
        listarTodosPadresFamiliaPorNombreDNI(@WebParam(name = "nombreDNI")String nombreDNI) {
        ArrayList<PadreFamilia> padresFamilia = new ArrayList<>();
        try {
            padresFamilia = daoPadreFamilia.listarTodos(nombreDNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return padresFamilia;
    } 
    
    //nuevo
    
    @WebMethod(operationName = "listarEstudiantesPorGrado")
    public ArrayList<Estudiante> 
        listarEstudiantesPorGrado(@WebParam(name = "idGrado")int idGrado) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            estudiantes = daoEstudiante.listarEstudianteXGrado(idGrado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return estudiantes;
    }    
        
    @WebMethod(operationName = "listarEstudiantesPorSeccion")
    public ArrayList<Estudiante> 
        listarEstudiantesPorSeccion(@WebParam(name = "idSeccion")int idSeccion) {
        ArrayList<Estudiante> estudiantes = new ArrayList<>();
        try {
            estudiantes = daoEstudiante.listarEstudiantesXSeccion(idSeccion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return estudiantes;
    }  
        
    @WebMethod(operationName = "asignarSeccionAEstudiante")
    public int asignarSeccionAEstudiante(@WebParam(name = "idEstudiante") int idEstudiante, 
                                         @WebParam(name = "idSeccion") int idSeccion) {
        
        int resultado = 0;
        try {
            resultado = daoEstudiante.asignarSeccionAEstudiante(idEstudiante, idSeccion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
        
    }
    
    @WebMethod(operationName = "quitarSeccionDeEstudiante")
    public int quitarSeccionDeEstudiante(@WebParam(name = "idEstudiante") int idEstudiante) {
        int resultado = 0;
        try {
            resultado = daoEstudiante.quitarSeccionDeEstudiante(idEstudiante);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEstudiantesPorPadreFamilia")
    public ArrayList<Estudiante> 
        listarEstudiantesXPadre(@WebParam(name = "padreFamilia")PadreFamilia padreFamilia) {
        ArrayList<Estudiante> hijos = new ArrayList<>();
        try {
            hijos = daoPadreFamilia.listarEstudiantesXPadre(padreFamilia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return hijos;
    } 
    
    
    //Lu
    @WebMethod(operationName = "asignarRolUsuario")
    public int asignarRolUsuario(@WebParam(name = "usuario")Usuario usuario) {
        int resultado = 0;
        try{
            resultado = daoUsuario.asignarRolUsuario(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }  
        
        
}
