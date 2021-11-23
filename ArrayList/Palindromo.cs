using System;

namespace EsPalindromo
{
    public class Palindromo
    {
        public static bool EsPalindromo(string palabra)
        {
            var palabraNormalizada = palabra.Replace(" ", string.Empty);
            var i = 0;
            var a = 0;

            var chr = palabraNormalizada.ToCharArray();
            foreach (var cr in chr)
            {
                Array.Reverse(chr);
                if (chr[i] == cr)
                {
                    if (a == palabraNormalizada.Length)
                    {
                        return true;
                    }

                    a++;
                    i++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}