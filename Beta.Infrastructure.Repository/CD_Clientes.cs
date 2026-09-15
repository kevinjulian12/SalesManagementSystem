using System.Data;
using System.Data.SqlClient;
using Beta.Infraestructura.Data;
using Beta.Infrastructure.Interface;
using Beta.Domain.Entity;

namespace Beta.Infrastructure.Repository
{
    public class CD_Clientes: IClienteRepository
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Read()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insert(EntityClientes cliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes(Nombre , Apellido, Direccion ,Telefono,Localidad ) values ('" + cliente.Nombre + "','"+ cliente.Apellido + "','"+ cliente.Direccion +"','"+ cliente.Telefono + "','"+ cliente.Localidad + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Update(EntityClientes cliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Clientes set Nombre='"+cliente.Nombre+"',Apellido='"+ cliente.Apellido+"',Direccion='"+cliente.Direccion +"',Telefono='"+cliente.Telefono +"',Localidad='"+cliente.Localidad +"' where ID='"+ cliente.id+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Delete(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Clientes where ID="+ id;
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
