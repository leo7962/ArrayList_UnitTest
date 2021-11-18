using System.Collections.Generic;
using NUnit.Framework;

namespace ArrayList
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CuandoSeCreaCountEsCero()
        {
            var lista = new List<int>();
            Assert.AreEqual(0, lista.Count);
        }

        [Test]
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
        public void ContainsEsFalseNoContieneElItem()
        {
            var lista = new List<int>();
            lista.Add(0);
            Assert.IsFalse(lista.Contains(1));
        }
    }
}