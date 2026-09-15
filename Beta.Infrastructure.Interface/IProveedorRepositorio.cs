using Beta.Domain.Entity;
using System.Data;

namespace Beta.Infraestructura.Interface
{
    public interface IProveedorRepository
    {
        DataTable Read();
        void Update(EntityProveedor cliente);
        void Delete(EntityProveedor cliente);
        void Insert(EntityProveedor cliente);
    }
}