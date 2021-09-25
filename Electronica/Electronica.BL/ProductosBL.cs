using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Computadora";
            producto1.Precio = 12000;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Play Station 5";
            producto2.Precio = 15000;

            var producto3= new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Iphone X";
            producto3.Precio = 10000;



            var listaProductos = new List<Producto>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);

            return listaProductos;
        }
    }
}
