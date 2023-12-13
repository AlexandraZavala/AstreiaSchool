/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.lp2.astreiasoft.eval.model;


public class EvaluacionConEntrega {
    private Evaluacion evaluacion;
    private Entrega entrega;
    private NotaEvaluacion notaEvaluacion; // Si también quieres incluir la nota más reciente

    // Constructor
    public EvaluacionConEntrega(Evaluacion evaluacion, Entrega entrega, NotaEvaluacion notaEvaluacion) {
        this.evaluacion = evaluacion;
        this.entrega = entrega;
        this.notaEvaluacion = notaEvaluacion;
    }

    // Getters y Setters
    public Evaluacion getEvaluacion() {
        return evaluacion;
    }

    public void setEvaluacion(Evaluacion evaluacion) {
        this.evaluacion = evaluacion;
    }

    public Entrega getEntrega() {
        return entrega;
    }

    public void setEntrega(Entrega entrega) {
        this.entrega = entrega;
    }

    public NotaEvaluacion getNotaEvaluacion() {
        return notaEvaluacion;
    }

    public void setNotaEvaluacion(NotaEvaluacion notaEvaluacion) {
        this.notaEvaluacion = notaEvaluacion;
    }

    // Puedes añadir otros métodos útiles aquí, como métodos para facilitar el acceso a campos específicos
}

