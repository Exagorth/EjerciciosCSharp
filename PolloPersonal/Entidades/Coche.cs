using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolloPersonal.Entidades
{
    class Coche
    {
        private int Id;
        private string Marca;
        private string Modelo;
        private int Km;
        private float Precio;

        public Coche(int idCoche,string marcaCoche,string modeloCoche,int kmCoche,float precioCoche)
        {
            this.Id = idCoche;
            this.Marca = marcaCoche;
            this.Modelo = modeloCoche;
            this.Km = kmCoche;
            this.Precio = precioCoche;
        }

        public Coche() //constructor vacio para setearle valores por teclado
        {

        }

        public int IdCoche
        {
            get => Id;
            set => Id = value;
        }

        public string MarcaCoche
        {
            get => Marca;
            set => Marca = value;
        }

        public string ModeloCoche
        {
            get => Modelo;
            set => Modelo = value;
        }

        public int KmCoche
        {
            get => Km;
            set => Km = value;
        }

        public float PrecioCoche
        {
            get => Precio;
            set => Precio = value;
        }

        public override String ToString()
        {
            return "ID_Coche: " + Id + "\nMarca: " + Marca + "\nModelo: " + Modelo + "\nKm_Coche: " + Km + "kms.\n" + "Precio: " + Precio + "$\n";
        }
    }
}
