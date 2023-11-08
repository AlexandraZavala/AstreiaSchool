package org.lp2.astreiasoft.services.gestadmin;

import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.lp2.astreiasoft.infra.dao.AulaDAO;
import org.lp2.astreiasoft.infra.dao.GradoDAO;
import org.lp2.astreiasoft.infra.dao.SeccionDAO;
import org.lp2.astreiasoft.infra.model.Aula;
import org.lp2.astreiasoft.infra.model.Grado;
import org.lp2.astreiasoft.infra.model.NivelEducativo;
import org.lp2.astreiasoft.infra.model.Seccion;
import org.lp2.astreiasoft.infra.mysql.AulaMySQL;
import org.lp2.astreiasoft.infra.mysql.GradoMySQL;
import org.lp2.astreiasoft.infra.mysql.SeccionMySQL;

/**
 *
 * @author mezav
 */
@WebService(serviceName = "InfraWS")
public class InfraWS {

    // GRADO
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

    @WebMethod(operationName = "listarNivelesEducativos")
    public List<NivelEducativo> listarNivelesEducativos() {
        return daoGrado.listarNivelesEducativos();
    }

   

    //SECCION
    private SeccionDAO daoSeccion = new SeccionMySQL();

    @WebMethod(operationName = "insertarSeccion")
    public int insertarSeccion(@WebParam(name = "medicamento") Seccion seccion) {
        int resultado = 0;

        try {
            resultado = daoSeccion.insertar(seccion);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarSeccionesTodos")
    public ArrayList<Seccion> listarSeccionesTodos() {
        ArrayList<Seccion> secciones = new ArrayList<>();
        
        try {
            secciones = daoSeccion.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return secciones;
    }
    
    @WebMethod(operationName = "modificarSeccion")
    public int modificarSeccion(@WebParam(name = "seccion") Seccion seccion) {
        int resultado = 0;

        try {
            resultado = daoSeccion.modificar(seccion);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
     @WebMethod(operationName = "eliminarSeccion")
    public int eliminarSeccion(@WebParam(name = "idSeccion") int idSeccion) {
        int resultado = 0;
        try {
            resultado = daoSeccion.eliminar(idSeccion);
            
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

     @WebMethod(operationName = "listarSeccionPorIdGrado")
    public ArrayList<Seccion> listarSeccionPorIdGrado(int idGrado) {
        ArrayList<Seccion> secciones = new ArrayList<>();
        try {
            secciones = daoSeccion.listarSeccionesPorGrado(idGrado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return secciones;
    }
    
    @WebMethod(operationName = "listarEstPorSeccion")
    public ArrayList<Integer> listarEstPorSeccion(@WebParam(name = "idSeccion") int idSeccion) {
        ArrayList<Integer> idsEstudiantes = new ArrayList<Integer>(); // Inicializa el ArrayList

        try {
            idsEstudiantes = daoSeccion.listarEstPorSeccion(idSeccion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }

        return idsEstudiantes;
    }
    
     @WebMethod(operationName = "vericarAulaEnSecciones")
    public int vericarAulaEnSecciones(@WebParam(name = "idAula") int idAula) {
        int resultado = 0;
        try {
            resultado = daoSeccion.verificarAula(idAula);
            
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
     @WebMethod(operationName = "asignarAulaXSeccion")
    public int asignarAulaXSeccion(@WebParam(name = "idSeccion") int idSeccion, 
                                   @WebParam(name = "idAula") int idAula) {
        int resultado = 0;

        try {
            resultado = daoSeccion.asignarAulaXSeccion(idSeccion, idAula);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAulasDetalle")
    public ArrayList<Seccion> listarAulasDetalle() {
        ArrayList<Seccion> secciones = new ArrayList<>();
        try {
            secciones = daoSeccion.listarAulasDetalle();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return secciones;
    }
    
    
    //AULA
    private AulaDAO daoAula = new AulaMySQL();

    @WebMethod(operationName = "insertarAula")
    public int insertarAula(@WebParam(name = "aula") Aula aula) {
        int resultado = 0;

        try {
            resultado = daoAula.insertar(aula);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAulaTodas")
    public ArrayList<Aula> listarAulaTodas() {
        ArrayList<Aula> aulas = new ArrayList<>();
        
        try {
            aulas = daoAula.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return aulas;
    }
    
    @WebMethod(operationName = "modificarAula")
    public int modificarAula(@WebParam(name = "aula") Aula aula) {
        int resultado = 0;

        try {
            resultado = daoAula.modificar(aula);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
     @WebMethod(operationName = "eliminarAula")
    public int eliminarAula(@WebParam(name = "idAula") int idAula) {
        int resultado = 0;
        try {
            resultado = daoAula.eliminar(idAula);
            
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    
    
}
