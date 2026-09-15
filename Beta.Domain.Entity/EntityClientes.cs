using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta.Domain.Entity
{
    public class EntityClientes
    {
        private string _id;
        private String elApellido;
        private String elNombre;
        private String elTelefono;
        private String laDireccion;
        private String laLocalidad;

        public string id
        {
            get { return _id; }
            set { _id = value.ToString(); }
        }

        public String Apellido
        {
            get { return elApellido; }
            set { elApellido = value.ToString(); }
        }
        public String Nombre
        {
            get { return elNombre; }
            set { elNombre = value.ToString(); }
        }
        public String Telefono
        {
            get { return elTelefono; }
            set { elTelefono = value.ToString(); }
        }
        public String Direccion
        {
            get { return laDireccion; }
            set { laDireccion = value.ToString(); }
        }
        public String Localidad
        {
            get { return laLocalidad; }
            set { laLocalidad = value.ToString(); }
        }

    }
}
