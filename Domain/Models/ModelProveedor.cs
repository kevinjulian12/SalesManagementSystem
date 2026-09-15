using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Domain
{
    public class ModelProveedor 
    {
        private int id;
        private string nombre;
        private string razon;
        private string direccion;
        private string telefon;
        private string referencia;
        private string email;

        [DisplayName("ID")]
        [Required(ErrorMessage ="Requiere un ID ")]
        public int Id { get => id; set => id = value; }
        [DisplayName("NOMBRE")]
        [Required(ErrorMessage = "Requiere un nombre ")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DisplayName("RAZON SOCIAL")]
        [Required(ErrorMessage = "Requiere una razon social ")]
        public string Razon { get => razon; set => razon = value; }
        [DisplayName("DIRECCION")]
        [Required(ErrorMessage = "Requiere una direccion ")]
        public string Direccion { get => direccion; set => direccion = value; }
        [DisplayName("TELEFONO")]
        [Required(ErrorMessage = "Requiere un telefono ")]
        [StringLength(11,ErrorMessage ="el telefono requiere minimo 8 y maximo 11 carecteres",MinimumLength =8)]
        public string Telefon { get => telefon; set => telefon = value; }
        [DisplayName("REFERENCIA")]
        [Required(ErrorMessage = "Requiere una referencia ")]
        public string Referencia { get => referencia; set => referencia = value; }
        [DisplayName("EMAIL")]
        [Required(ErrorMessage = "Requiere un email ")]
        public string Email { get => email; set => email = value; }
        
    }
}
