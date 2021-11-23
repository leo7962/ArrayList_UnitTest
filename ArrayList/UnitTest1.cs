using System.Collections.Generic;
using NUnit.Framework;

namespace ArrayList
{
    /// <summary>
    /// TEST DRIVEN DEVELOPMENT - TDD
    /// Consideraciones a tener en cuenta con las pruebas unitarias:
    /// 
    /// *Deben ser simples de escribir
    /// *simples de entender
    /// *De rápida ejecución ya que no dependen de acceso a disco, red o base de datos
    /// --Pero son Exhaustivas y costosas de hacer
    /// 
    ///  Los casos tipicos de una prueba unitaria pueden tener diferentes variantes
    /// *Camino "Feliz" es el valor esperado y la expectativa a tener
    /// *El camino de excepción, si he de crear excepciones a tener en cuenta la ejecución de la prueba
    /// *Condiciones de borde, si tengo que probar ciertas funcionalidades ante determinados valores he de probar con situaciones
    /// *Camino alternativo, Situaciones en las que debo ejercitar con valores alternativos para pasar por el camino feliz
    /// 
    /// Convenciones de nombres: Situacion - Resultado Esperado
    /// -AcreditarMontoPositivo - IncrementaSaldo
    /// -AcreditarunMontoNegativo - NoEsValido
    ///
    /// Sobre los asserts Poner uno o varios asserts por métodos?
    /// Si es posible, hacer un método por cada situación a verificar, es decir, mantener un assert por cada prueba
    /// y realizar varias pruebas
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("Ejemplos")]
        public void CuandoSeCreaCountEsCero()
        {
            var lista = new List<int>();
            Assert.AreEqual(0, lista.Count);
        }

        [Test]
        [Category("Ejemplos")]
        public void CuandoSeAgregaUnItemCountEsUno()
        {
            var lista = new List<int>();
            lista.Add(1);
            Assert.AreEqual(1, lista.Count);
        }

        [Test]
        public void ContainsEsTrueCuandoContieneElItem()
        {
            var lista = new List<int>();
            lista.Add(1);
            Assert.IsTrue(lista.Contains(1));
        }

        [Test]
        [Category("Ejemplos")]
        public void ContainsEsFalseNoContieneElItem()
        {
            var lista = new List<int>();
            lista.Add(0);
            Assert.IsFalse(lista.Contains(1));
        }
    }
}