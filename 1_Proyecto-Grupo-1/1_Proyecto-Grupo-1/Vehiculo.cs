using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Proyecto_Grupo_1
{
    internal class Vehiculo
    {
        private string _dueño;
        private string _año;
        private string _marca;
        private int _precio;


        public Vehiculo(string dueño, string año,string marca, int precio)
        {
            _dueño = dueño;
            _año = año;
            _marca = marca;
            _precio = precio;

        }

        public string Dueño
        {

            get { return _dueño; }
            set
            {
                if (value != String.Empty)
                {
                    _dueño = value;
                }
            }

        }

        public string Año
        {

            get { return _año; }
            set
            {
                if (value != String.Empty)
                {
                    _año = value;
                }
            }

        }

        public string Marca
        {

            get { return _marca; }
            set
            {
                if (value != String.Empty)
                {
                    _marca = value;
                }
            }

        }


        public int Precio
        {

            get { return _precio; }
            set
            {
                if (value > 0)
                {
                    _precio = value;
                }
            }

        }

        public override string ToString()
        {
            return $"Dueño: {Dueño},Año: {Año},Marca: {Marca}, Precio: {Precio}";
        }



    }
}
