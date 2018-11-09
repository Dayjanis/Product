using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
   public class logicaNegocioCliente
    {
        accesoDatosCliente ac = new accesoDatosCliente();
        public int insertarCliente(cliente cl)
        {
            return ac.insertarCliente(cl);
        }
        public List<cliente> ListarClientes()
        {
            return ac.ListarClientes();
        }
        public int EditarCliente(cliente cl)
        {
            return ac.EditarCliente(cl);
        }
        public int EliminarCliente(int idcliente)
        {
            return ac.EliminarCliente(idcliente);
        }
        public cliente BuscarClienteXcodigo(int idcli)
        {
            return ac.BuscarClienteXcodigo(idcli);
        }
        public List<cliente> BuscaClienteDatos(String dato)
        {
            return ac.BuscaClienteDatos(dato);
        }
    }
}
