
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data.SqlClient;
using Beta.Infraestructura.Data;
using Beta.Infrastructure.Interface;
using Domain;

namespace Beta.Infrastructure.Repository
{
    public class UsuarioDAO : IUserRepository
    {
        public DataTable Login(string user, string pass)
        {
            CD_Conexion connection = new CD_Conexion();
            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection.AbrirConexion();
            command.CommandText = "select * from Users where LoginName=@user COLLATE Latin1_General_CS_AS and password=@pass COLLATE Latin1_General_CS_AS";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.Text;
                tabla.Load(command.ExecuteReader());
                return tabla;
           
        }
        public void Update(EntityUsuario user)
        {
            CD_Conexion connection = new CD_Conexion();

            using (var command = new SqlCommand())
            {
                command.Connection = connection.AbrirConexion();
                command.CommandText = "update Users set LoginName=@userName, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail where UserID=@id";
                command.Parameters.AddWithValue("@userName", user.LoginName);
                command.Parameters.AddWithValue("@pass", user.Password);
                command.Parameters.AddWithValue("@name", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@mail", user.Email);
                command.Parameters.AddWithValue("@id", user.Email);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                
            }
        }
    }

}
