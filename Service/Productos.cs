using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practApi4.Models;

namespace practApi4.Service
{
    public class Productos
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
               new Producto { ProductoId = 3, ProductoNombre = "Nueva Película Tendencia 1 (2008)" },
        new Producto { ProductoId = 7, ProductoNombre = "Nueva Película 7 (2010)" },
        new Producto { ProductoId = 6, ProductoNombre = "Nueva Película 6 (1994)" },
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                 new Producto { ProductoId = 1, ProductoNombre = "Nueva Película 1 (1994)" },
        new Producto { ProductoId = 2, ProductoNombre = "Nueva Película 2 (1972)" },
        new Producto { ProductoId = 3, ProductoNombre = "Nueva Película 3 (2008)" },
        new Producto { ProductoId = 4, ProductoNombre = "Nueva Película 4 (1994)" },
        new Producto { ProductoId = 5, ProductoNombre = "Nueva Película 5 (2003)" },
        new Producto { ProductoId = 6, ProductoNombre = "Nueva Película 6 (1994)" },
        new Producto { ProductoId = 7, ProductoNombre = "Nueva Película 7 (2010)" },
        new Producto { ProductoId = 8, ProductoNombre = "Nueva Película 8 (1999)" },
        new Producto { ProductoId = 9, ProductoNombre = "Nueva Película 9 (1999)" },
        new Producto { ProductoId = 10, ProductoNombre = "Nueva Película 10 (2014)" }
            };

            return result;
        }


    }
}