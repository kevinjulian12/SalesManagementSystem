using Beta.Domain.Entity;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta.Infrastructure.Interface
{
    public interface IUserRepository
    {
        DataTable Login(string user, string pass);
        void Update(EntityUsuario user);
    }
}
