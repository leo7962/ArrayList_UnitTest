using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ArrayList
{
    [TestFixture]
    public class AssertTypes
    {
        [Test]
        public void ArrayListSeCreaVacio()
        {
            var array = new List<int>();
            if (array == null) throw new ArgumentNullException(nameof(array));
            Assert.IsEmpty(array);
        }

        [Test]
        public void ArrayListContineItem()
        {
            var array = new List<int>(new[] {1, 2});
            Assert.Contains(1, array);
        }

        [Test]
        public void StringHolaNoEsVacio()
        {
            var hola = "hola";
            Assert.That(hola, Is.Not.Empty);
        }

        [Test]
        public void StringHolaTieneLongitud4()
        {
            var hola = "hola";
            Assert.That(hola.Length, Is.EqualTo(4));
        }

        [Test]
        public void StringHolaContieneH()
        {
            var hola = "hola";
            Assert.That(hola.Contains('h'));
        }
    }
}