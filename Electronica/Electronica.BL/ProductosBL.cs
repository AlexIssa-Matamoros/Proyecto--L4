using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new BL.Contexto();
        }


        public List<Producto> ObtenerProductos()
        {

            return _contexto.Productos.ToList();
        }
    }
}
