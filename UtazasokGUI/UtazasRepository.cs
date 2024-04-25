using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtazasokGUI
{
    class UtazasRepository
    {
        public static string Path;
        public static char Delimiter = ',';
        public static bool SkipHeader = true;

        public static List<Utazas> FindAll()
        {
            StreamReader reader = new StreamReader(Path, true);
            List<Utazas> utazasLista = new List<Utazas> { };
            if (SkipHeader) { reader.ReadLine(); }
            while (!reader.EndOfStream)
            {
                utazasLista.Add(Utazas.CreateUtazasFromCsvLine(reader.ReadLine(), Delimiter));
            }
            reader.Close();

            return utazasLista;
        }

        public static void Save(Utazas utazas)
        {
            if (utazas.Id == 0)
            {
                try
                {
                    int lastId = FindAll().Last().Id;
                    utazas.Id = lastId+1;
                }
                catch { }
            }

            StreamWriter writer = new StreamWriter(Path, true);
            writer.WriteLine(utazas.ToCsvLine(Delimiter));
            writer.Close();
        }
    }
}
