using Beta.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta.Infrastructure.Interface
{
    public interface IClienteRepository
    {
        DataTable Read();
        void Update(EntityClientes cliente);
        void Delete(int id);
        void Insert(EntityClientes cliente);
    }
}
