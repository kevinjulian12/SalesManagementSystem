using Beta.Domain.Entity;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta.Domain.Interface
{
    public interface IUserDomain
    {
        bool Login(string user, string pass);
        string Update(EntityUsuario user);
    }
}
