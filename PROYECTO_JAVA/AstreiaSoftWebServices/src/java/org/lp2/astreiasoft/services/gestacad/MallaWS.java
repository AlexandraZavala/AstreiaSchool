/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.lp2.astreiasoft.services.gestacad;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.lp2.astreiasoft.infra.dao.GradoDAO;
import org.lp2.astreiasoft.infra.dao.SeccionDAO;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.infra.mysql.GradoMySQL;
import org.lp2.astreiasoft.infra.mysql.SeccionMySQL;
import org.lp2.astreiasoft.malla.dao.AreaCurricularDAO;
import org.lp2.astreiasoft.malla.dao.CursoDAO;
import org.lp2.astreiasoft.malla.dao.CursoProgramadoDAO;
import org.lp2.astreiasoft.malla.dao.HorarioDAO;
import org.lp2.astreiasoft.malla.dao.MaterialDAO;
import org.lp2.astreiasoft.malla.model.AreaCurricular;
import org.lp2.astreiasoft.malla.model.Curso;
import org.lp2.astreiasoft.malla.model.CursoProgramado;
import org.lp2.astreiasoft.malla.model.Horario;
import org.lp2.astreiasoft.malla.model.Material;
import org.lp2.astreiasoft.malla.mysql.AreaCurricularMySQL;
import org.lp2.astreiasoft.malla.mysql.CursoMySQL;
import org.lp2.astreiasoft.malla.mysql.CursoProgramadoMySQL;
import org.lp2.astreiasoft.malla.mysql.HorarioMySQL;
import org.lp2.astreiasoft.malla.mysql.MaterialMySQL;

/**
 *
 * @author Alexandra
 */
@WebService(serviceName = "MallaWS")
public class MallaWS {

    //*****************************************************
    // Area Curricular
    //*****************************************************
    
    private AreaCurricularDAO daoAreaCurricular = new AreaCurricularMySQL();
    
    @WebMethod(operationName = "listarAreaCurricular")//nombre a nivel de los clientes, puede variar
    public ArrayList<AreaCurricular> listarAreaCurricular(){
        ArrayList<AreaCurricular> areas = new ArrayList<>();
        try{
                areas = daoAreaCurricular.listarTodas();
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return areas;
    }
    
    @WebMethod(operationName = "listarAreasNombre")//nombre a nivel de los clientes, puede variar
    public ArrayList<AreaCurricular> listarAreasNombre(@WebParam(name = "nombre") String nombre){
        ArrayList<AreaCurricular> areas = new ArrayList<>();
        try{
                areas = daoAreaCurricular.listarPorNombre(nombre);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return areas;
    }
    
    @WebMethod(operationName = "insertarAreaCurricular")
    public int insertarAreaCurricular(@WebParam(name = "areaCurricular")AreaCurricular area){
        int resultado = 0;
        try{
            resultado = daoAreaCurricular.insertar(area);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarAreaCurricular")
    public int eliminarAreaCurricular(@WebParam(name = "idAreaCurricular") int idAreaCurricular) {
        int resultado = 0;
        try {
            resultado = daoAreaCurricular.eliminar(idAreaCurricular);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAreaCurricular")
    public int modificarAreaCurricular(@WebParam(name = "areaCurricular") AreaCurricular areaCurricular) {
        int resultado = 0;
        try {
            resultado = daoAreaCurricular.modificar(areaCurricular);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerNombreArea")
    public String obtenerNombreArea(@WebParam(name = "idArea") int idArea) {
        String nombre= null;
        try {
            nombre = daoAreaCurricular.obtenerNombrePorId(idArea);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return nombre;
    }
    
    @WebMethod(operationName = "verificarArea")
    public int verificarArea(@WebParam(name = "nombre") String nombreArea) {
        int resultado = 0;
        try {
            resultado = daoAreaCurricular.verificar_area(nombreArea);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    
    //*****************************************************
    //CURSO PROGRAMADO
    //*****************************************************
    
    
    private CursoProgramadoDAO daoCursoProgramado = new CursoProgramadoMySQL();//importamos los correspondientes

    @WebMethod(operationName = "listarCursosPrograNombre")//nombre a nivel de los clientes, puede variar
    public ArrayList<CursoProgramado> listarCursosPrograNombre(@WebParam(name = "nombre") String nombre){
        ArrayList<CursoProgramado> cursosPro = new ArrayList<>();
        try{
                cursosPro = daoCursoProgramado.listarPorNombre(nombre);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursosPro;
    }
    
    @WebMethod(operationName = "listarCursosPrograTodos")//nombre a nivel de los clientes, puede variar
    public ArrayList<CursoProgramado> listarCursosPrograTodos(){
        ArrayList<CursoProgramado> cursosPro = new ArrayList<>();
        try{
                cursosPro = daoCursoProgramado.listarTodos();
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursosPro;
    }
    
    @WebMethod(operationName = "listarCursosPrograGrado")//nombre a nivel de los clientes, puede variar
    public ArrayList<CursoProgramado> listarCursosPrograGrado(@WebParam(name = "idGrado") int idGrado){
        ArrayList<CursoProgramado> cursosPro = new ArrayList<>();
        try{
                cursosPro = daoCursoProgramado.listarPorGrado(idGrado);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursosPro;
    }
    
    
    
    @WebMethod(operationName = "insertarCursoProgramado")
    public int insertarCursoProgramado(@WebParam(name = "cursoProgramado") CursoProgramado cursoProgramado) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.insertar(cursoProgramado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarCursoProgramado")
    public int modificarCursoProgramado(@WebParam(name = "cursoProgramado") CursoProgramado cursoProgramado) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.modificar(cursoProgramado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCursoProgramado")
    public int eliminarCursoProgramado(@WebParam(name = "idCursoProgramado") int idCursoProgramado) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.eliminar(idCursoProgramado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    
    @WebMethod(operationName = "verificarCursoProgramado")
    public int verificarCursoProgramado(@WebParam(name = "curso") CursoProgramado cursoPro) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.verificar_curso(cursoPro);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarCursoProgramadoEstudiantes")
    public int verificarCursoProgramadoEstudiantes(@WebParam(name = "idCurso") int idCursoPro,@WebParam(name = "idSeccion") int idSeccion) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.verificar_estudiantes(idCursoPro,idSeccion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "asignarEstudiantesCursoProgramado")
    public int asignarEstudiantesCursoProgramado(@WebParam(name = "idCursoPro") int idCursoPro,
           @WebParam(name = "idsEs") ArrayList<Integer> idsEstudiantes ) {
        int resultado = 0;
        try {
            resultado = daoCursoProgramado.asignarEstudiantesCursoProgramado(idCursoPro,idsEstudiantes);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarCursosProgramadosPorUsuario")//nombre a nivel de los clientes, puede variar
    public ArrayList<CursoProgramado> listarCursosProgramadosPorUsuario(
                @WebParam(name = "idUsuario") int idUsuario){
        ArrayList<CursoProgramado> cursosPro = new ArrayList<>();
        try{
                cursosPro = daoCursoProgramado.listarPorUsuario(idUsuario);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursosPro;
    }
    
    
    //*****************************************************
    //CURSO GENERAL
    //*****************************************************
    
    private CursoDAO daoCurso = new CursoMySQL();

    @WebMethod(operationName = "listarCursos")
    public ArrayList<Curso> listarCursos(){
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
                cursos = daoCurso.listarTodos();
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosNombre")
    public ArrayList<Curso> listarCursosNombre(@WebParam(name = "nombre") String nombre){
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
                cursos = daoCurso.listarPorNombre(nombre);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "insertarCurso")
    public int insertarCurso(@WebParam(name = "curso") Curso curso) {
        int resultado = 0;
        try {
            resultado = daoCurso.insertar(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarCurso")
    public int modificarCurso(@WebParam(name = "curso") Curso curso) {
        int resultado = 0;
        try {
            resultado = daoCurso.modificar(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCurso")
    public int eliminarCurso(@WebParam(name = "idCurso") int idCurso) {
        int resultado = 0;
        try {
            resultado = daoCurso.eliminar(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarCurso")
    public int verificarCurso(@WebParam(name = "curso") Curso curso) {
        int resultado = 0;
        try {
            resultado = daoCurso.verificar_curso(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerNombreCurso")
    public String obtenerNombreCurso(@WebParam(name = "idCurso") int idCurso) {
        String resultado =null;
        try {
            resultado = daoCurso.obtenerNombrePorId(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "encontrarCursoProgramadoPorCurso")
    public int encontrarCursoProgramadoPorCurso(@WebParam(name = "idCurso") int idCurso) {
        int resultado = 0;
        try {
            resultado = daoCurso.encontrarPorCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarCursosPorUsuarioYAnio")
    public ArrayList<Curso> listarCursosPorUsuarioYAnio(
            @WebParam(name = "idDocente") int idUsuario,
            @WebParam(name = "anio") int anio){
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
                cursos = daoCurso.listarPorUsuarioYAnio(idUsuario, anio);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    
    //*****************************************************
    //MATERIAL
    //*****************************************************
    
    private MaterialDAO daoMaterial = new MaterialMySQL();
    
    @WebMethod(operationName = "listarMateriales")//nombre a nivel de los clientes, puede variar
    public ArrayList<Material> listarMateriales(){
        ArrayList<Material> materiales = new ArrayList<>();
        try{
                materiales = daoMaterial.listarTodos();
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return materiales;
    }
    
    @WebMethod(operationName = "insertarMaterial")
    public int insertarMaterial(@WebParam(name = "material") Material material) {
        int resultado = 0;
        try {
            resultado = daoMaterial.insertar(material);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarMaterial")
    public int modificarMaterial(@WebParam(name = "material") Material material) {
        int resultado = 0;
        try {
            resultado = daoMaterial.modificar(material);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarMaterial")
    public int eliminarMaterial(@WebParam(name = "idMaterial") int idMaterial) {
        int resultado = 0;
        try {
            resultado = daoMaterial.eliminar(idMaterial);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "listarMaterialesPorCursoProgramado")//nombre a nivel de los clientes, puede variar
    public ArrayList<Material> listarMaterialesPorCursoProgramado(
                    @WebParam(name = "idCursoProgramado") int idCursoProgramado){
        ArrayList<Material> materiales = new ArrayList<>();
        try{
                materiales = daoMaterial.listarPorCursoProgramado(idCursoProgramado);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return materiales;
    }
    
    
    //*****************************************************
    //HORARIO
    //*****************************************************
    
    private HorarioDAO daoHorario = new HorarioMySQL();
    
    @WebMethod(operationName = "listarHorarioPorSeccion")//nombre a nivel de los clientes, puede variar
    public ArrayList<Horario> listarHorarioPorSeccion(@WebParam(name = "horario") int idSeccion){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
                horarios = daoHorario.listarTodosPorId(idSeccion);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "listarHorarioPorIdDocente")
    public ArrayList<Horario> listarHorarioPorIdDocente(@WebParam(name = "horario") int idDocente){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
                horarios = daoHorario.listarTodosPorIdDocente(idDocente);
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "insertarHorario")
    public int insertarHorario(@WebParam(name = "horario") Horario horario) {
        int resultado = 0;
        try {
            resultado = daoHorario.insertar(horario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarHorario")
    public int modificarHorario(@WebParam(name = "horario") Horario horario) {
        int resultado = 0;
        try {
            resultado = daoHorario.modificar(horario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarHorario")
    public int eliminarHorario(@WebParam(name = "idHorario") int idHorario) {
        int resultado = 0;
        try {
            resultado = daoHorario.eliminar(idHorario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerNombreDocenteHorario")
    public String obtenerNombreDocenteHorario(@WebParam(name = "idHorario") int idHorario) {
        String resultado =null;
        try {
            resultado = daoHorario.obtenerNombreDocente(idHorario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerNombreCursoHorario")
    public String obtenerNombreCursoHorario(@WebParam(name = "idHorario") int idHorario) {
        String resultado =null;
        try {
            resultado = daoHorario.obtenerNombreCurso(idHorario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    //EXTRAAAAAA
    
    private GradoDAO daoGrado = new GradoMySQL();

    @WebMethod(operationName = "listarGradosTodos")
    public ArrayList<Grado> listarGradosTodos() {
        ArrayList<Grado> grados = new ArrayList<>();
        try {
            grados = daoGrado.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return grados;
    }
    
}
