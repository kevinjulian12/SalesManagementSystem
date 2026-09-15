using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Views
{
    public interface IViewProveedor
    {
        //propiedades
        int Id { get; set; }
        string Nombre { get; set; }
        string Razon { get; set; }
        string Direccion { get; set; }
        string Telefon { get; set; }
        string Referencia { get; set; }
        string Email { get; set; }

        
        string Buscar { get; set; }
        bool esEditar { get; set; }
        bool esEliminar { get; set; }
        bool esGuardar { get; set; }
        bool EsExitoso { get; set; }
        string mensaje { get; set; }

        //eventos
        event EventHandler BuscarEvento;
        event EventHandler AgregarNuevoEvento;
        event EventHandler EditarEvento;
        event EventHandler EliminarEvento;
        event EventHandler GuargarEvento;
        event EventHandler CancelarEvent;

        //metodos
        void SetPetListBindingSource(BindingSource petList);
        void Show();

    }
}
