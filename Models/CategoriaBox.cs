using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkAr.Models
{
    public class CategoriaBox
    {

        public int CategoriaBoxId { get; set; }

        public string Descripcion { get; set; }
        
        public ICollection<ValorCategoria> ValorCategorias { get; set; }

        public CategoriaBox()
        {
            this.ValorCategorias = new List<ValorCategoria>();
        }

    }
}