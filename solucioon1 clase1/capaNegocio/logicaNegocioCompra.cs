using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioCompra
    {
        accesoDatosCompra aco = new accesoDatosCompra();
        public int insertarCompra(Compra co)
        {
            return aco.insertarCompra(co);
        }
        public List<Compra> ListarCompra()
        {
            return aco.ListarCompras();
        }
        public int EditarCompra(Compra co)
        {
            return aco.EditarCompra(co);
        }
        public int EliminarCompra(int id_compra)
        {
            return aco.EliminarCompra(id_compra);
        }
        public Compra BuscarCompraXcodigo(int idcom)
        {
            return aco.BuscarCompraXcodigo(idcom);
        }
        public List<Compra> BuscaCompraDatos(String dato)
        {
            return aco.BuscaCompraDatos(dato);
        }
    }
}

