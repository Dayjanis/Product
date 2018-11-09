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
       public class accesoDatosCliente
    {
           SqlConnection cnx;
           cliente cl = new cliente();
           Conexion cn = new Conexion();
           SqlCommand cm = null;
           int indicador = 0;
           SqlDataReader dr = null;
           List<cliente> listaClien = null;

           public int insertarCliente(cliente cl)
           {
               try
               {
                   SqlConnection cnx = cn.conectar();

                   cm = new SqlCommand("nuevoCliente", cnx);
                   cm.Parameters.AddWithValue("@b", 1);
                   cm.Parameters.AddWithValue("@idcliente", "");
                   cm.Parameters.AddWithValue("@nombres", cl.nombres);
                   cm.Parameters.AddWithValue("@direccion", cl.direccion);
                   cm.Parameters.AddWithValue("@telefono", cl.telefono);

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
            public List<cliente> ListarClientes()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoCliente", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcliente", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<cliente>();
                while (dr.Read())
                {
                    cliente c = new cliente();
                    c.idcliente = Convert.ToInt32(dr["idcliente"].ToString());
                    c.nombres = dr["nombres"].ToString();
                    c.direccion = dr["direccion"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    listaClien.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaClien;
        }

        
        public int EliminarCliente(int idcliente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCliente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcliente", idcliente);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");

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

        public int EditarCliente(cliente cl)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCliente", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcliente", cl.idcliente);
                cm.Parameters.AddWithValue("@nombre", cl.nombres);
                cm.Parameters.AddWithValue("@direccion", cl.direccion);
                cm.Parameters.AddWithValue("@telefono", cl.telefono);

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

        public List<cliente> BuscaClienteDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoCliente", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@idcliente", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@direccion", dato);
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<cliente>();
                while (dr.Read())
                {
                    cliente c = new cliente();
                    c.idcliente = Convert.ToInt32(dr["idcliente"].ToString());
                    c.nombres = dr["nombres"].ToString();
                    c.direccion = dr["direccion"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    listaClien.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally { cm.Connection.Close(); }
            return listaClien;
        }

        public cliente BuscarClienteXcodigo(int idcli)
        {
            cliente cl = new cliente();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoCliente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcliente", idcli);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                cl.idcliente = Convert.ToInt32(dr["idcliente"].ToString());
                cl.nombres = dr["nombres"].ToString();
                cl.direccion = dr["direccion"].ToString();
                cl.telefono = dr["telefono"].ToString();

            }
            catch (Exception e)
            {
                e.Message.ToString();
                cl = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return cl;
        }
    }
}
