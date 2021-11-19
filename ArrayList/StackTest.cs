using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ArrayList
{
    public class StackTest
    {
        [Test]
        public void UltimoEntradoPrimeroSalido()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Assert.That(stack.Pop(), Is.EqualTo(4));
            Assert.That(stack.Pop(), Is.EqualTo(3));
            Assert.That(stack.Pop(), Is.EqualTo(2));
            Assert.That(stack.Pop(), Is.EqualTo(1));
        }

        [Test]
        public void LanzaInvalidOperationExceptionAlSacarCuandoEstaVacio()
        {
            var stack = new Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void SeCreaVacio()
        {
            var stack = new Stack<int>();
            Assert.IsEmpty(stack);
        }
    }
}