using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite niz znakova: ");
            string s1 = Console.ReadLine();
            if (s1.Length <= 11)
            {
                Console.WriteLine("Upisite recenicu sa 11+ znakova!!");

            }
            else
            {
                string sVelika = s1.ToUpper();
                string sMala = s1.ToLower();
                string sPrvaTri = s1.Substring(0, 3);
                string sZadnjihPet = s1.Substring(s1.Length - 5);
                string s8_11 = s1.Substring(8, 11);

                Console.WriteLine(sVelika);
                Console.WriteLine(sMala);
                Console.WriteLine(sPrvaTri);
                Console.WriteLine(sZadnjihPet);
                Console.WriteLine(s8_11);
            }

            Console.ReadKey();
        }
    }
}
