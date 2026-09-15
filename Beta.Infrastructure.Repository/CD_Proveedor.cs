using Beta.Domain.Entity;
using Beta.Infraestructura.Data;
using Beta.Infraestructura.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Beta.Infrastructure.Repository
{
    public class CD_Proveedor : IProveedorRepository
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insert(EntityProveedor proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"insert into Proveedor(Nombre , Razon_Social, Direccion ,Telefono ,Referencia ,Email) values ('{proveedor.Nombre}','{proveedor.Razon}','{proveedor.Direccion}','{proveedor.Telefon}','{proveedor.Referencia}','{proveedor.Email}')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Delete(EntityProveedor proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Proveedor where ID=" + proveedor.Id;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Update(EntityProveedor proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Proveedor set Nombre='"
                                  + proveedor.Nombre
                                  + "',Razon_Social='"
                                  + proveedor.Razon
                                  + "',Direccion='"
                                  + proveedor.Direccion
                                  + "',Telefono='"
                                  + proveedor.Telefon
                                  + "',Referencia='"
                                  + proveedor.Referencia
                                  + "',Email='"
                                  + proveedor.Email
                                  + "' where ID='"
                                  + proveedor.Id
                                  + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable Read()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
