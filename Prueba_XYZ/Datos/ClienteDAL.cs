using Prueba_XYZ.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_XYZ.Datos
{
    public class ClienteDAL
    {
        //Metodo para listar todos los clientes
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre, Dui, Telefono, Correo, Estado FROM Cliente";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
        //metodo para insertar un nuevo cliente
        public int Insertar(Cliente c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"INSERT INTO Cliente (Nombre, Dui, Telefono, Correo, Estado)
                               VALUES (@nombre, @dui,@telefono, @correo, @estado);
                               SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.Dui);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);

                    cn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public bool Actualizar(Cliente c)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"UPDATE Cliente SET Nombre=@nombre,
                               Telefono=@telefono,
                               Dui=@dui,
                               Correo=@correo,
                               Estado=@estado
                               WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@dui", c.Dui);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@correo", c.Correo);
                    cmd.Parameters.AddWithValue("@estado", c.Estado);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Cliente WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, Telefono, Dui, Correo, Estado
                               FROM Cliente
                               WHERE Nombre LIKE @filtro OR Telefono LIKE @filtro";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    cn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }
        // Metodo para listar clientes activos, Este método sirve para llenar el ComboBox de clientes.
        public static List<Cliente> ListarActivos()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT * FROM Cliente WHERE Estado = 1";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),
                                Dui = dr["Dui"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
