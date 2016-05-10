using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase08
{
    class Producto
    {
        public int _codigo;
        //private solo lo puede ver la clase
        protected string _nombre;
        //protected solo lo pueden ver las clases e hijos

        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public Producto(int codigo)
        {
            this._codigo = codigo;
        }

        public Producto(int codigo, string nombre):this(codigo)
        {           
            this._nombre = nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("Codigo: " + this._codigo + "\nNombre: " + this._nombre);
        }
    }
}
