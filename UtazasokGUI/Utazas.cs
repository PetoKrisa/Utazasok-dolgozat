using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasokGUI
{
    class Utazas
    {
        public int Id { get; set; }
        public string Orszag { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Hossz { get; set; }
        public int Ar { get; set; }
        public string Ellatas { get; set; }

        public Utazas(int id, string orszag, int honap, int nap, int hossz, int ar, string ellatas)
        {
            this.Id = id;
            this.Orszag = orszag;
            this.Honap = honap;
            this.Nap = nap;
            this.Hossz = hossz;
            this.Ar = ar;
            this.Ellatas = ellatas;
        }
        public Utazas() { }

        public static Utazas CreateUtazasFromCsvLine(string line, char delimiter)
        {
            Utazas output = null;
            List<string> splitLine = line.Split(delimiter).ToList();
            output = new Utazas(
                Convert.ToInt32(splitLine[0]),
                splitLine[1],
                Convert.ToInt32(splitLine[2]),
                Convert.ToInt32(splitLine[3]),
                Convert.ToInt32(splitLine[4]),
                Convert.ToInt32(splitLine[5]),
                splitLine[6]
                );

            return output;
        }

        public string ToCsvLine(char delimiter)
        {
            return $"{Id}{delimiter}" +
                $"{Orszag}{delimiter}" +
                $"{Honap}{delimiter}" +
                $"{Nap}{delimiter}" +
                $"{Hossz}{delimiter}" +
                $"{Ar}{delimiter}" +
                $"{Ellatas}";
        }

        public override string ToString()
        {
            return $"{Id}," +
                $"{Orszag}," +
                $"{Honap}," +
                $"{Nap}," +
                $"{Hossz}," +
                $"{Ar}," +
                $"{Ellatas}";
        }
    }
}
