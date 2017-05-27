using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkAr.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }



    }
}