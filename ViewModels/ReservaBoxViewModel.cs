using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParkAr.Models;
using System.ComponentModel.DataAnnotations;

namespace ParkAr.ViewModels
{
    public class ReservaBoxViewModel
    {
        [Display(Name = "Nombre Cliente")]
        public Cliente Cliente { get; set; }
        [Display(Name = "Numero Box")]
        public Box BoxSeleccionado { get; set; }
        [Display(Name = "Estacionamiento")]

        public Estacionamiento EstacionamientoSeleccionado { get; set; }
        [Display(Name = "Horas")]
        public List<String> Horas { get; set; }
        public byte CantidadHoras { set; get; }
        [Display(Name = "Estacionamientos")]
        public List<Estacionamiento> Estacionamientos { set; get; }

    }
}