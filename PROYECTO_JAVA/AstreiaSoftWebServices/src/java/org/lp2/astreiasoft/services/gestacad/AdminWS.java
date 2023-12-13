/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.lp2.astreiasoft.services.gestacad;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.lp2.astreiasoft.admin.dao.AsistenciaDAO;
import org.lp2.astreiasoft.admin.dao.EventoDAO;
import org.lp2.astreiasoft.admin.dao.InscripcionDAO;
import org.lp2.astreiasoft.admin.dao.MatriculaDAO;
import org.lp2.astreiasoft.admin.model.Asistencia;
import org.lp2.astreiasoft.admin.model.Evento;
import org.lp2.astreiasoft.admin.model.Inscripcion;
import org.lp2.astreiasoft.admin.model.Matricula;
import org.lp2.astreiasoft.admin.mysql.AsistenciaMySQL;
import org.lp2.astreiasoft.admin.mysql.EventoMySQL;
import org.lp2.astreiasoft.admin.mysql.InscripcionMySQL;
import org.lp2.astreiasoft.admin.mysql.MatriculaMySQL;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.malla.model.Horario;
import org.lp2.astreiasoft.users.dao.EstudianteDAO;
import org.lp2.astreiasoft.users.model.Estudiante;
import org.lp2.astreiasoft.users.model.Usuario;
import org.lp2.astreiasoft.users.mysql.EstudianteMySQL;

/**
 *
 * @author adida
 */
@WebService(serviceName = "AdminWS")
public class AdminWS {

    private AsistenciaDAO daoAsistencia = new AsistenciaMySQL();
    private EventoDAO daoEvento = new EventoMySQL();
    private InscripcionDAO daoInscripcion = new InscripcionMySQL();
    private MatriculaDAO daoMatricula = new MatriculaMySQL();
    
    // Métodos para Asistencia
    @WebMethod(operationName = "insertarAsistencia")
    public int insertarAsistencia(@WebParam(name = "asistencia") Asistencia asistencia) {
        int resultado = 0;
        try {
            resultado = daoAsistencia.insertar(asistencia);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarAsistencia")
    public int modificarAsistencia(@WebParam(name = "asistencia") Asistencia asistencia) {
        int resultado = 0;
        try {
            resultado = daoAsistencia.modificar(asistencia);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "eliminarAsistencia")
    public int eliminarAsistencia(@WebParam(name = "idAsistencia") int idAsistencia) {
        int resultado = 0;
        try {
            resultado = daoAsistencia.eliminar(idAsistencia);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasAsistencias")
    public ArrayList<Asistencia> listarTodasAsistencias() {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        try {
            asistencias = daoAsistencia.listarTodas();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return asistencias;
    }
    
    // Métodos para Evento
    @WebMethod(operationName = "insertarEvento")
    public int insertarEvento(@WebParam(name = "evento") Evento evento) {
        int resultado = 0;
        try {
            resultado = daoEvento.insertar(evento);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarEvento")
    public int modificarEvento(@WebParam(name = "evento") Evento evento) {
        int resultado = 0;
        try {
            resultado = daoEvento.modificar(evento);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarEvento")
    public int eliminarEvento(@WebParam(name = "idEvento") int idEvento) {
        int resultado = 0;
        try {
            resultado = daoEvento.eliminar(idEvento);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodosEventos")
    public ArrayList<Evento> listarTodosEventos() {
        ArrayList<Evento> eventos = new ArrayList<>();
        try {
            eventos = daoEvento.listarTodas();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }
    
    @WebMethod(operationName = "listarEventosPorNombreYFecha")
    public ArrayList<Evento> listarEventosPorNombreYFecha(
        @WebParam(name = "nombre") String nombre, 
        @WebParam(name = "fecha") Date fecha) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try {
            eventos = daoEvento.listarEventosPorNombreYFecha(nombre, fecha);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }

    @WebMethod(operationName = "listarEventosPorNombre")
    public ArrayList<Evento> listarEventosPorNombre(
        @WebParam(name = "nombre") String nombre) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try {
            eventos = daoEvento.listarEventosPorNombre(nombre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }

    @WebMethod(operationName = "listarEventosInscritosPorEstudiante")
    public ArrayList<Evento> listarEventosInscritosPorEstudiante(
        @WebParam(name = "idEstudiante") int idEstudiante) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try {
            eventos = daoEvento.listarEventosInscritosPorEstudiante(idEstudiante);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return eventos;
    }

    @WebMethod(operationName = "inscribirEstudianteEnEvento")
    public int inscribirEstudianteEnEvento(
        @WebParam(name = "idEstudiante") int idEstudiante, 
        @WebParam(name = "idEvento") int idEvento) {
        int resultado = 0;
        try {
            resultado = daoEvento.inscribirEstudianteEnEvento(idEstudiante, idEvento);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "cancelarInscripcionEvento")
    public int cancelarInscripcionEvento(
        @WebParam(name = "idEstudiante") int idEstudiante, 
        @WebParam(name = "idEvento") int idEvento) {
        int resultado = 0;
        try {
            resultado = daoEvento.cancelarInscripcionEvento(idEstudiante, idEvento);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarMatricula")
    public int insertarMatricula(
        @WebParam(name = "matricula") Matricula matricula) {
        int resultado = 0;
        try {
            resultado = daoMatricula.insertar(matricula);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarMatricula")
    public int modificarMatricula(
        @WebParam(name = "matricula") Matricula matricula) {
        int resultado = 0;
        try {
            resultado = daoMatricula.modificar(matricula);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarMatricula")
    public int eliminarMatricula(
        @WebParam(name = "idMatricula") int idMatricula) {
        int resultado = 0;
        try {
            resultado = daoMatricula.eliminar(idMatricula);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasMatriculas")
    public ArrayList<Matricula> listarTodasMatriculas() {
        ArrayList<Matricula> resultado = null;
        try {
            resultado = daoMatricula.listarTodas();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarMatriculasPorAnho")
    public ArrayList<Matricula> listarMatriculasPorAnho(
        @WebParam(name = "inputAnho") int inputAnho) {
        ArrayList<Matricula> resultado = null;
        try {
            resultado = daoMatricula.listarMatriculaPorAnho(inputAnho);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAnhosMatriculacion")
    public ArrayList<Integer> listarAnhosMatriculacion() {
        return daoMatricula.listarAnhosMatriculacion();
    }
    
    @WebMethod(operationName = "insertarInscripcion")
    public int insertar(
        @WebParam(name = "inscripcion") Inscripcion inscripcion) {
        int resultado = -1;
        try {
            resultado = daoInscripcion.insertar(inscripcion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "modificarInscripcion")
    public int modificar(
        @WebParam(name = "inscripcion") Inscripcion inscripcion) {
        int resultado = -1;
        try {
            resultado = daoInscripcion.actualizarInscripcion(inscripcion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "decidirInscripcion")
    public int decidirInscripcion(
        @WebParam(name = "inscripcion") Inscripcion inscripcion) {
        int resultado = -1;
        try {
            resultado = daoInscripcion.modificar(inscripcion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarInscripcion")
    public int eliminar(
        @WebParam(name = "idInscripcion") int idInscripcion) {
        int resultado = -1;
        try {
            resultado = daoInscripcion.eliminar(idInscripcion);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarTodasInscripciones")
    public ArrayList<Inscripcion> listarTodas() {
        ArrayList<Inscripcion> resultado = null;
        try {
            resultado = daoInscripcion.listarTodas();
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarHijosDePadre")
    public ArrayList<Usuario> listarHijosDePadre(
        @WebParam(name = "idPadre") int idPadre) {
        ArrayList<Usuario> resultado = null;
        try {
            resultado = daoInscripcion.listarHijosDePadre(idPadre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarEstudiante")
    public int insertarEstudiante(@WebParam(name = "estudiante")
            Estudiante estudiante){
        int resultado = 0;
        try{
            resultado = daoInscripcion.insertarEstudiante(estudiante);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPorPadre")
    public ArrayList<Inscripcion> listarPorPadre(@WebParam(name = "idPadre")
            int idPadre){
        ArrayList<Inscripcion> resultado = null;
        try {
            resultado = daoInscripcion.listarPorPadre(idPadre);
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPorPadreEstudiante")
    public ArrayList<Inscripcion> listarPorPadreEstudiante(@WebParam(name = "idPadre") int idPadre, @WebParam(name = "idEstudiante") int idEstudiante)
    {
        ArrayList<Inscripcion> resultado = null;
        try {
            resultado = daoInscripcion.listarPorPadreEstudiante(idPadre, idEstudiante);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPreinscripciones")
    public ArrayList<Inscripcion> listarPreinscripciones()
    {
        ArrayList<Inscripcion> resultado = null;
        try {
            resultado = daoInscripcion.listarPreinscripciones();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPreinscripcionesPorEstado")
    public ArrayList<Inscripcion> listarPreinscripcionesPorEstado(@WebParam(name = "estado") String estado) {
        ArrayList<Inscripcion> resultado = null;
        try {
            resultado = daoInscripcion.listarPreinscripcionesPorEstado(estado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarGradosActivos")
    public ArrayList<Grado> listarGradosActivos() {
        ArrayList<Grado> resultado = null;
        try {
            resultado = daoInscripcion.listarGradosActivos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarHorariosDelCurso")
    public ArrayList<Horario> listarHorariosDelCurso(@WebParam(name = "idCurso") int idCurso,
            @WebParam(name = "idDocente") int idDocente,
            @WebParam(name = "dia") String dia) {
        ArrayList<Horario> resultado = null;
        try {
            resultado = daoAsistencia.listarHorariosDelCurso(idCurso, idDocente, dia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEstudiantesDelCursoProgramado")
    public ArrayList<Estudiante> listarEstudiantesDelCursoProgramado(@WebParam(name = "idCurso") int idCursoProgramado,
            @WebParam(name = "idHorario") int idHorario) {
        ArrayList<Estudiante> resultado = null;
        try {
            resultado = daoAsistencia.listarEstudiantesDelCursoProgramado(idCursoProgramado, idHorario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerOListarAsistencias")
    public ArrayList<Asistencia> obtenerOListarAsistencias(@WebParam(name = "idHorario") int idHorario,
            @WebParam(name = "fecha") Date fecha) {
        ArrayList<Asistencia> resultado = null;
        try {
            resultado = daoAsistencia.obtenerOListarAsistencias(idHorario, fecha);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarMatriculaParaPreinscripcion")
    public int verificarMatriculaParaPreinscripcion() {
        int resultado = 0;
        try {
            resultado = daoMatricula.verificarMatriculaParaPreinscripcion();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
