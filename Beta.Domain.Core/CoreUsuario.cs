
using Beta.Aplicacion.DTO;
using Beta.Infrastructure.Repository;
using Domain;
using Microsoft.SqlServer.Server;
using System;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace Beta.Domain.Core
{
    public class CoreUsuario: Interface.IUserDomain
    {
        EntityUsuario entity = new EntityUsuario();

        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public bool Login(string user, string pass)
        {
            try
            {
                Read(usuarioDAO.Login(user, pass));
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
        
        //Methods
        public string Update(EntityUsuario user)
        {
            usuarioDAO.Update(user);
                Login(user.LoginName, user.Password);
                return "Tú perfil ha sido actualizado satisfactoriamente";                    
        }

        public void Read(DataTable datatable)
        {
            foreach (DataRow row in datatable.Rows)
            {
                UsuarioDTO.IdUser = Convert.ToInt32(row[0]);
                UsuarioDTO.LoginName = Convert.ToString(row[1]);
                UsuarioDTO.Password = Convert.ToString(row[2]);
                UsuarioDTO.FirstName = Convert.ToString(row[3]);
                UsuarioDTO.LastName = Convert.ToString(row[4]);
                UsuarioDTO.Position = Convert.ToString(row[5]);
                UsuarioDTO.Email = Convert.ToString(row[6]);

                entity.IdUser = Convert.ToInt32(row[0]);
                entity.LoginName = Convert.ToString(row[1]);
                entity.Password = Convert.ToString(row[2]);
                entity.FirstName = Convert.ToString(row[3]);
                entity.LastName = Convert.ToString(row[4]);
                entity.Position = Convert.ToString(row[5]);
                entity.Email = Convert.ToString(row[6]);
            }
        }
    }
}
