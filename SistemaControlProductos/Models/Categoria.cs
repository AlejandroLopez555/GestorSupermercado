using System.ComponentModel.DataAnnotations;

namespace SistemaControlProductos.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}