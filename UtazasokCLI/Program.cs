using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasokCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adatok:");
            UtazasRepository.Path = "utazasok.csv";
            UtazasRepository.SkipHeader = false;
            List<Utazas> utazasok = UtazasRepository.FindAll();
            foreach(var i in utazasok)
            {
                Console.WriteLine(i);
            }
            
            

            Console.ReadKey();

        }
    }
}
