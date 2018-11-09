using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosCompra
    {
        SqlConnection cnx;
        Compra co = new Compra();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Compra> listaCompra = null;

        public int insertarCompra(Compra co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCompra", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcompra", "");
                cm.Parameters.AddWithValue("@fecha", co.fecha);
                cm.Parameters.AddWithValue("@precioC", co.precioC);
                cm.Parameters.AddWithValue("@cantidad", co.cantidad);
                cm.Parameters.AddWithValue("@id_producto", co.id_producto);
                cm.Parameters.AddWithValue("@idcodigoC", co.idcodigoC);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

             public List<Compra> ListarCompras()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevaCompra", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idCompra", "");
                cm.Parameters.AddWithValue("@fecha", "");
                cm.Parameters.AddWithValue("@precioC", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@idcodigoC", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCompra = new List<Compra>();
                while (dr.Read())
                {
                    Compra c = new Compra();
                    c.idCompra = Convert.ToInt32(dr["idCompra"].ToString());
                    c.fecha = dr["fecha"].ToString();
                    c.precioC = int .Parse(dr["direccion"].ToString());
                    c.cantidad = int.Parse(dr["telefono"].ToString());
                    c.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    c.idcodigoC = Convert.ToInt32(dr["idcodigoC"].ToString());
                    listaCompra.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCompra = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCompra;
        }

        
        public int EliminarCompra(int id_compra)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaCompra", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idCompra", id_compra);
                cm.Parameters.AddWithValue("@fecha", "");
                cm.Parameters.AddWithValue("@precioC", "");
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@idcodigoC", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }

        public int EditarCompra(Compra co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaCompra", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idCompra", co.idCompra);
                cm.Parameters.AddWithValue("@fecha", co.fecha);
                cm.Parameters.AddWithValue("@precioC", co.precioC);
                cm.Parameters.AddWithValue("@cantidad", co.cantidad);
                cm.Parameters.AddWithValue("@id_producto", co.id_producto);
                cm.Parameters.AddWithValue("@idcodigoC", co.idcodigoC);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

        public List<Compra> BuscaCompraDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevaCompra", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@idCompra", "");
                cm.Parameters.AddWithValue("@fecha", dato);
                cm.Parameters.AddWithValue("@precioC", dato);
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@idcodigoC", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCompra = new List<Compra>();
                while (dr.Read())
                {
                    Compra c = new Compra();
                    c.idCompra = Convert.ToInt32(dr["idCompra"].ToString());
                    c.fecha = dr["fecha"].ToString();
                    c.precioC = int.Parse(dr["precioC"].ToString());
                    c.cantidad = int.Parse(dr["cantidad"].ToString());
                    c.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                    c.idcodigoC= Convert.ToInt32( dr["idcodigoC"].ToString());
                    listaCompra.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCompra = null;
            }
            finally { cm.Connection.Close(); }
            return listaCompra;
        }

        public Compra BuscarCompraXcodigo(int idcom)
        {
            Compra co = new Compra();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaComprar",cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idCompra", idcom);
                cm.Parameters.AddWithValue("@fecha", "");
                cm.Parameters.AddWithValue("@precioC", "");
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@idcodigoC", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                
                co.idCompra = Convert.ToInt32(dr["idCompra"].ToString());
                co.fecha = dr["fecha"].ToString();
                co.precioC = int.Parse(dr["precioC"].ToString());
                co.cantidad = int.Parse(dr["cantidad"].ToString());
                co.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
                co.idcodigoC = Convert.ToInt32(dr["idcodigoC"].ToString());
                
                
            }
            catch(Exception e)
            {
                e.Message.ToString();
                co= null;
            }
            finally {
                cm.Connection.Close(); 
                
            }
            return co;
        }
        }
    }
