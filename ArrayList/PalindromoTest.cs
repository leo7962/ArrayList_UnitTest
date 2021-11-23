using EsPalindromo;
using NUnit.Framework;

namespace ArrayList
{
    public class PalindromoTest
    {
        [Test]
        [TestCase("ana")]
        [TestCase("yo soy")]
        [TestCase("amar da drama")]
        [TestCase("anita lava la tina")]
        public void EsPalindromo(string palabra)
        {
            Assert.True(Palindromo.EsPalindromo(palabra));
        }
    }
}