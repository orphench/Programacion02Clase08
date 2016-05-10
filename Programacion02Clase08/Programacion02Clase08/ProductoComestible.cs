using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase08
{
    class ProductoComestible:Producto//HERENCIA
    {
        //Cundo llamo a un constructor
        //
        private DateTime _fechaDeVencimiento;

        public DateTime Fecha
        {
            get
            {
                return this._fechaDeVencimiento;
            }

            set
            {
                this._fechaDeVencimiento = value;
            }
        }

        public ProductoComestible(string nombre, int codigo):base(codigo, nombre)
        {
            //this._nombre = nombre;
            //this._codigo = codigo;
        }

        public ProductoComestible(string nombre, int codigo, DateTime fechaDeVencimiento):base(codigo,nombre)
        {
            //this._fechaDeVencimiento = new DateTime(2016, 05, 30);
            //this._fechaDeVencimiento = Convert.ToDateTime("09/05/2016");
            this._fechaDeVencimiento = fechaDeVencimiento;
            

        }
    }
}
