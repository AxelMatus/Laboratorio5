using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio5.Models
{
    public class PaisModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe de proporcionar un nombre")]
        [DisplayName("Nombre del país:")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe de seleccionar un Continente")]
        [DisplayName("Continente:")]
        public string Continente { get; set; }

        [Required(ErrorMessage = "Debe de ingresar un idioma")]
        [DisplayName("Idioma:")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "No puede ingresar numeros")]
        public string Idioma { get; set; }

    }
}
