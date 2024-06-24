using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodConnection__.Models
{
    public class Receta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Por favor introduzca el nombre de la receta")]
        [Display(Name = "Nombre de la receta")]
        public string Nombre { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Por favor introduzca la descripcion de la receta")]
        [Display(Name = "Descripcion de la receta")]
        public string Descripcion { get; set; }

        [EnumDataType(typeof(TipoDeCocina))]
        [Display(Name = "Tipo de cocina ")]
        public TipoDeCocina tipo { get; set; }
        [Display(Name = "Foto de la receta ")]
        public string? PathImagen { get; set; }

    }
}
