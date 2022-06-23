using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolloPersonal.Entidades
{
    class Concesionario
    {
        private Coche[] MisCoches;
        private int Cantidad;
        private int numeroCoches;

        public Concesionario(int cantidadCoches) //constructor al cual le paso como parametro la dimension del arreglo
        {
            this.MisCoches = new Coche[cantidadCoches];
            Cantidad = cantidadCoches;
            numeroCoches = 0;                       
        }

        public void AgregarCoche(Coche coche)
        //verifico que el objeto coche no este vacio y que el numero de conche que voy a meter no supere la dimension del array.
        {
            if (coche != null && numeroCoches < MisCoches.Length)
            {
                for (int i = 0; i < MisCoches.Length; i++)
                {
                    if (MisCoches[i] == null)
                    {
                        MisCoches[i] = coche;
                        numeroCoches++;
                        break;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Concesionario lleno!");
            }
        }
        public void mostrarCoches()
        {
            for (int i = 0; i < MisCoches.Length; i++)
            {
                Console.WriteLine(MisCoches[i]);
            }
        }

        public void VaciarConches() 
        {
            this.MisCoches = new Coche[Cantidad];
            numeroCoches = 0;
        }

        public void eliminarCoche(Coche coche)
        {
            if (coche != null && numeroCoches != 0) 
            {
                int posicion = -1;
                
                for(int i = 0; i < numeroCoches; i++)
                {
                    if(coche.IdCoche == MisCoches[i].IdCoche)
                    {
                        posicion = i;
                        break;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No se encuentra Coche");
                }

                else
                {
                    MisCoches[posicion] = null;
                    numeroCoches--;
                }
            }
        }
    }
}
