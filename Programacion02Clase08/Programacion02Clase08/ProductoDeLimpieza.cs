using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase08
{
    public enum eTipoLimpieza
    {
        limpiza,
        desinfeccion,
        desinfeccionLimpieza
    }

    class ProductoDeLimpieza : Producto
    {

        public eTipoLimpieza _tipo;

        public ProductoDeLimpieza(ProductoDeLimpieza productoLimpieza):base(productoLimpieza._codigo, productoLimpieza.Nombre)
        {
            //this._nombre = "lalala";
        }
        
        
      
    }
}
