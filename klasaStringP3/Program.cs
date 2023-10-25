using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            string sVelika = "";
            string sMala = "";
            string sPrvaTri = "";
            string sZadnjihPet = "";
            string s8_11 = "";

            Console.WriteLine("Unesi niz znakova: ");
            tekst = Convert.ToString(Console.ReadLine());

            sVelika = tekst.ToUpper();
            sMala = tekst.ToLower();
            sPrvaTri = tekst.Substring(0, 3);

            int duz = tekst.Length - 5;

            sZadnjihPet = tekst.Substring(tekst.Length - 5, 5);

            if (tekst.Length > 11)
            {
                s8_11 = tekst.Substring(8, 11);
            }

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);

            Console.ReadKey();
        }
    }
}
