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
    public class accesoDatosProducto
    {
        SqlConnection cnx;
        producto pr = new producto();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<producto> listaProd = null;


        public int insertarProducto(producto pr)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idproducto", "");
                cm.Parameters.AddWithValue("@descripcion", pr.descripcion);

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
        public List<producto> ListarProductos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@id_producto", "");
                cm.Parameters.AddWithValue("@descripcion", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProd = new List<producto>();
                while (dr.Read())
                {
                    producto pr = new producto();
                    pr.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    pr.descripcion= dr["descripcion"].ToString();
                   
                    listaProd.Add(pr);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProd = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaProd;
        }

        public int EliminarProducto(int idProducto)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idProducto", idProducto);
                cm.Parameters.AddWithValue("@descripcion", "");
                

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

        public int EditarProducto(producto pd)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idProducto", pd.idProducto);
                cm.Parameters.AddWithValue("@descripcion", pd.descripcion);
                

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

        public List<producto> BuscaProductoDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@idProductp", "");
                cm.Parameters.AddWithValue("@descripcion", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProd = new List<producto>();
                while (dr.Read())
                {
                    producto pr = new producto();
                    pr.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                    pr.descripcion = dr["descripcion"].ToString();
                    listaProd.Add(pr);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProd = null;
            }
            finally { cm.Connection.Close(); }
            return listaProd;
        }


        public producto BuscarProductoXcodigo(int idProd)
        {
            producto pr = new producto();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoProducto", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idProducto", idProd);
                cm.Parameters.AddWithValue("@descripcion", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                pr.idProducto = Convert.ToInt32(dr["idProducto"].ToString());
                pr.descripcion = dr["descripcion"].ToString();
                

            }
            catch (Exception e)
            {
                e.Message.ToString();
                pr = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return pr;
        }
    }
}