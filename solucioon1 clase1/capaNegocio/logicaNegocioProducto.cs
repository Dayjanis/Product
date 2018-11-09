using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioProducto
    {
        accesoDatosProducto apr = new accesoDatosProducto();
        public int insertarProducto(producto pr)
        {
            return apr.insertarProducto(pr);
        }

        public List<producto> ListarProducto()
        {
            return apr.ListarProductos();
        }
        public int EditarProducto(producto pd)
        {
            return apr.EditarProducto(pd);
        }
        public int EliminarProducto(int idProducto)
        {
            return apr.EliminarProducto(idProducto);
        }
        public producto BuscarProductoXcodigo(int idprod)
        {
            return apr.BuscarProductoXcodigo(idprod);
        }
        public List<producto> BuscaProductoDatos(String dato)
        {
            return apr.BuscaProductoDatos(dato);
        }
    }
}