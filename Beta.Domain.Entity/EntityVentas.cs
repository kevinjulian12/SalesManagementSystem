using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Domain
{
    public class EntityVentas
    {

        public int idVenta { get; set; }

        private string idCliente;

        public string IDCliente
        {
            get { return idCliente; }
            set { idCliente = value.ToString(); }
        }

  
    
    }
}
