using System.Data;
using Beta.Infrastructure.Repository;

namespace Domain
{
    public class CoreComprasItem
    {
        CD_ComprasItems comprasItems = new CD_ComprasItems();


        public void Eliminar(int idcompra)
        {
            comprasItems.EliminarDetalllesCompra(idcompra);
        }

        public DataTable MostrarCompraItem(int idcompra)
        {
            return comprasItems.MostrarDetallesCompras(idcompra);
        }

        public void InsertarItems(int idCompra, int idproducto, float precioCompra, float precioVenta, int cantidad, float subTotal)
        {
            comprasItems.Insertar(idCompra, idproducto, precioCompra,precioVenta, cantidad, subTotal);
        }
    }
}
