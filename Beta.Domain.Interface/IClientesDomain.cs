using Beta.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta.Domain.Interface
{
    public interface IClientesDomain
    {
        DataTable Read();
        void Update(EntityClientes cliente);
        void Delete(EntityClientes cliente);
        void Insert(EntityClientes cliente);
    }
}
