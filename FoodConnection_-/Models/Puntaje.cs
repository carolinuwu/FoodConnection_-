using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FoodConnection__.Models
{
    public class Puntaje
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor introduzca el puntaje ")]
        [Range(1, 10, ErrorMessage = "El puntaje debe estar entre 1 y 10")]
        [Display(Name = "Puntaje numerico")]
        public int PuntajeNumerico { get; set; }
        [Required(ErrorMessage = "Por favor introduzca un comentario")]
        public string Comentario { get; set; }
        [Display(Name = "Restaurante")]
        public int RestauranteId { get; set; }
        public Restaurante? Restaurante { get; set; }

    }
}