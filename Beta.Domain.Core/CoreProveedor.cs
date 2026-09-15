using Beta.Domain.Entity;
using Beta.Infrastructure.Repository;
using System.Data;

namespace Beta.Domain.Core
{
    public class CoreProveedor : Interface.IProveedor
    {
        CD_Proveedor CD_Proveedor = new CD_Proveedor();
        public void Delete(EntityProveedor proveedor)
        {
            CD_Proveedor.Delete(proveedor);
        }

        public void Insert(EntityProveedor proveedor)
        {
            CD_Proveedor.Insert(proveedor);
        }

        public DataTable Read()
        {
           return CD_Proveedor.Read();
        }

        public void Update(EntityProveedor proveedor)
        {
            CD_Proveedor.Update(proveedor);
        }
    }
}