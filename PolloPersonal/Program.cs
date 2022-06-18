using PolloPersonal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolloPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche auto1 = new Coche(23,"Peugeot","208",0,2370000);
            Console.WriteLine(auto1);

            Coche auto2 = new Coche();

            auto2.IdCoche = 367;
            auto2.MarcaCoche = "Wolksvagen";
            auto2.ModeloCoche = "Gol";
            auto2.KmCoche = 356455;
            auto2.PrecioCoche = 3777777.255F;

            string modeloAuto2 = auto2.ModeloCoche;
            Console.WriteLine(modeloAuto2 + "\n");           

            Console.WriteLine(auto2);
        }
    }
}
