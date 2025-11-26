using Prueba_XYZ.Datos;
using Prueba_XYZ.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_XYZ.Negocio
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL();
        //Metodo para listar todos los clientes
        public DataTable Listar()
        {
            return dal.Listar();
        }
        //metodo para insertar un nuevo cliente
        public int Guardar(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                throw new ArgumentException("El nombre del cliente no puede estar vacio.");
            if (c.Id == 0)
                return dal.Insertar(c);
            else
                dal.Actualizar(c);
            return c.Id;
        }
        /*public bool Actualizar(Cliente c)
        {
            return dal.Actualizar(c);
		}*/
        public bool Eliminar(int id)
        {
            return dal.Eliminar(id);
        }
        public DataTable Buscar(string nombre)
        {
            return dal.Buscar(nombre);
        }
    }
}
