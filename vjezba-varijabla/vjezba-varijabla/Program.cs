using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_varijabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            float brojOcjena = 0;
            float zbrojOcjena = 0;
            string uputa = "Upiši ocjenu: ";
            string ispis = "Prosjek ocjena je: ";
            float prosjek;

            do
            {
                Console.Write(uputa);
                ocjena=Convert.ToInt32(Console.ReadLine());
                if (ocjena >= 1 && ocjena <= 5)
                {
                    
                    brojOcjena++;
                    zbrojOcjena += ocjena;

                }else if (ocjena == 0)
                {
                    prosjek = zbrojOcjena / brojOcjena;
                    Console.Write(ispis);
                    Console.WriteLine(prosjek);
                }
                else
                {
                    Console.WriteLine("Molimo unesite ispravnu ocjenu (1-5)");
                }

            }
            while (ocjena != 0);

            

            Console.ReadKey();
        }
    }
}
