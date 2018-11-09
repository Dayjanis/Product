using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioProveedors
    {
        accesoDatosProveedores ap = new accesoDatosProveedores();
        public int insertarProveedor(proveedores pv)
        {
            return ap.insertarProveedor(pv);
        }
        public List<proveedores> ListarProveedores()
        {
            return ap.ListarProveedores();
        }
        public int EditarProveedores(proveedores pv)
        {
            return ap.EditarProveedor(pv);
        }
        public int EliminarProveedor(int id_proveedor)
        {
            return ap.EliminarProveedor(id_proveedor);
        }
        public proveedores BuscarProveedorXcodigo(int idpro)
        {
            return ap.BuscarProveedorXcodigo(idpro);
        }
        public List<proveedores> BuscaProveedorDatos(String dato)
        {
            return ap.BuscaProveedorDatos(dato);
        }
        }
}
