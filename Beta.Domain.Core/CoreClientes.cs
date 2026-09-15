using Beta.Domain.Entity;
using Beta.Infrastructure.Repository;
using System;
using System.Data;


namespace Domain
{
    public class CoreClientes
    {                
        CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Read();
            return tabla;
        }

        public string InsertarCliente(EntityClientes entity)
        {
            try 
            {
                objetoCD.Insert(entity);
                return "se inserto correctamente";
            }
            catch (Exception ex)
            {
                return "no se pudo editar los datos por: " + ex;
            }
        }

        public string EditarCliente(EntityClientes entity)
        {
            try
            {
                objetoCD.Update(entity);
                return "se edito correctamente";
            }
            catch (Exception ex)
            {
                return "no se pudo editar los datos por: " + ex;
            }
        }

        public string EliminarCliente(int id)
        {
            try
            {
                objetoCD.Delete(id);
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "no se pudo editar los datos por: " + ex;
            }
            
        }

    }
}
