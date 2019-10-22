using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1._5
{
    class Program
    {
        public static int NOD(int a, int b)
        {
            if (a == b)
                return a;
            else
                if (a > b)
                return NOD(a - b, b);
            else
                return NOD(b - a, a);
        }
        static void Main(string[] args)
        {
            int p = 31;
            int q = 29;
            int modulus = p * q;
            int f = (p - 1) * (q - 1);
            int e = 0;
            for (int i = 2; i < f; i++)
            {
                if (NOD(i , f) == 1)
                {
                    e = i;
                    break;
                }
            }
            // ------------------ РСА шифр
            //string word = "ВЖЕ ВЕЧЕР";
            //Cipher.RSACipher(p, q, e, word);
            //Console.WriteLine();
            //Console.WriteLine(Cipher.RSADecipher(p * q, f, e, Cipher.RSACipher(p, q, e, word)));
            // ------------------ РСА шифр


            //System.Numerics.BigInteger t1 = System.Numerics.BigInteger.Pow(17, 31);
            //Console.WriteLine((19 * t1) % 37);

            Cipher.ElgamalCipher(37, "завтра тебе повезёт");
            Cipher.ElgamalDecipher(new List<KeyValuePair<double, double>> { new KeyValuePair<double, double>(6, 9) }, 8, 11);

            //Cipher.Knapsack("пошли в кафе", new int[] { 1, 2, 5, 9, 20, 60, 100, 213 });
            Console.ReadKey();
        }
    }
}
