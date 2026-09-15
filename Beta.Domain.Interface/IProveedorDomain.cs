using Beta.Domain.Entity;
using System.Data;

namespace Beta.Domain.Interface
{
    public interface IProveedor
    {
        DataTable Read();
        void Update(EntityProveedor proveedor);
        void Delete(EntityProveedor proveedor);
        void Insert(EntityProveedor proveedor);
    }
}