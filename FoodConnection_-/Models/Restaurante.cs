using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodConnection__.Models
{
    public class Restaurante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor introduzca el nombre del restaurante")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor introduzca la direccion del restaurante")]
        public string Direccion { get; set; }
        public virtual ICollection<Puntaje> Puntajes { get; set; } = new List<Puntaje>();
        [Display(Name = "Foto del restaurante ")]
        public string? PathImagen { get; set; }

    }
}
