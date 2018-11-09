using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace capaEntidades
{
    public class Compra
    {
        public int idCompra{ get; set; }
        public string fecha { get; set; }
        public float precioC { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
        public int idcodigoC { get; set; }
    }
}
