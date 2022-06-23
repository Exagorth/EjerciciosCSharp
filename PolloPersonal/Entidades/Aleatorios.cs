using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolloPersonal.Entidades
{
    class Aleatorios
    {
        private int NumeroRandom;
        private int[] MisNumeros;

        
        public int GenerarNumeroAleatorio(int min, int max)
        {
            Random rnd = new Random();            
            this.NumeroRandom = rnd.Next(min, max);
            
            return NumeroRandom;
        }

        public int ObtenerNumeroRandom
        {
            get => NumeroRandom;
            set => NumeroRandom = value;
        }

        
    }
}
