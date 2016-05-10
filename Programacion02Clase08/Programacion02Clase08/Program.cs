using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase08
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto(10,"Escoba");
            ProductoComestible unProductoComestible = new ProductoComestible("Pan", 50);
            //REFERENCIA "ES UN" unProductoComestible es un Producto

            ProductoComestibleVencido productoVencido = new ProductoComestibleVencido(unProductoComestible);

            List<Producto> listado = new List<Producto>();

            listado.Add(productoVencido);
            listado.Add(unProductoComestible);
            listado.Add(producto);

            foreach (Producto item in listado)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
