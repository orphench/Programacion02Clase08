using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase08
{
    public sealed class ProductoComestibleVencido:ProductoComestible
    {       

        public ProductoComestibleVencido(ProductoComestible producto)
            : base(producto.Nombre, producto.Codigo, producto.Fecha)
        {
            this._nombre = "lalala";
            
        }
    }
}
