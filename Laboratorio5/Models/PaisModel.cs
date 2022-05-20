using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Models
{
    public class PaisModel : Controller
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Continente { get; set; }
        public string Idioma { get; set; }

    }
}
