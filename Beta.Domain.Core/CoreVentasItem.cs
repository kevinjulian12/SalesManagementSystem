using System.Data;
using Beta.Infrastructure.Repository;

namespace Domain
{
    public class CoreVentasItem
    {
        CD_VentasItems VentasItems = new CD_VentasItems();

        public int idVenta { get; set; }

        public void Eliminar(int idventa)
        {
            VentasItems.EliminarDetalllesVenta(idventa);  
        }

        public DataTable MostrarVentaItem(int idventa)
        {
           return VentasItems.MostrarDetVent(idventa);
        }

        public void InsertarItems(int idVenta,int idproducto,float precioUnitario,int cantidad,float subTotal)
        {
            VentasItems.Insertar(idVenta, idproducto, precioUnitario, cantidad, subTotal);
        }
    }
}
