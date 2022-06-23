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
            
            Coche auto2 = new Coche();

            Coche auto3 = new Coche();

            Coche auto4 = new Coche();

            Coche auto5 = new Coche();

            auto2.IdCoche = 367;
            auto2.MarcaCoche = "Ford";
            auto2.ModeloCoche = "Falcon";
            auto2.KmCoche = 356455;
            auto2.PrecioCoche = 5777777.255F;

            auto3.IdCoche = 27;
            auto3.MarcaCoche = "BMW";
            auto3.ModeloCoche = "Alpha 500";
            auto3.KmCoche = 120;
            auto3.PrecioCoche = 10777777.100F;

            auto4.IdCoche = 702;
            auto4.MarcaCoche = "Fiat";
            auto4.ModeloCoche = "Uno";
            auto4.KmCoche = 0;
            auto4.PrecioCoche = 2222769.115F;

            auto5.IdCoche = 11;
            auto5.MarcaCoche = "Alpha Roméo";
            auto5.ModeloCoche = "A1";
            auto5.KmCoche = 2013;
            auto5.PrecioCoche = 10999999.15F;

            Concesionario nuevaConce = new Concesionario(5);

            nuevaConce.AgregarCoche(auto1);
            nuevaConce.AgregarCoche(auto2);
            nuevaConce.AgregarCoche(auto3);
            nuevaConce.AgregarCoche(auto4);
            nuevaConce.AgregarCoche(auto5);
            //nuevaConce.mostrarCoches();
            //Console.ReadLine();
            nuevaConce.eliminarCoche(auto3);
            //nuevaConce.mostrarCoches();
            nuevaConce.AgregarCoche(auto3);
            nuevaConce.mostrarCoches();
            Console.ReadLine();
            nuevaConce.VaciarConches();
            Console.ReadLine();
            nuevaConce.mostrarCoches();
        }
    }
}
