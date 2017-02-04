using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ULatina.Topicos.Calculadora.Tests
{
    [TestClass]
    public class BusinessLogic
    {
        [TestMethod]
        public void SumarTodosLosElementosEnCero()
        {
            //preparacion del escenario
            List<double> miLista = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double elResultadoEsperado = 0.0;

            //invoque al metodo requerido
            var laAccion = new Dominio.Acciones.Sumar();
            var elResultadoObtenido = laAccion.RealizarOperacion(miLista);

            //realice las verificaciones de si la invocacion devolvio el resultado esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido); 
        }
    }
}
