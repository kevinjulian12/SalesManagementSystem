using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public interface IProveedor
    {
        DataTable MostrarTodos();
        void Editar(ModelProveedor proveedor);
        void Eliminar(ModelProveedor proveedor);
        void Insertar(ModelProveedor proveedor);
    }
}
