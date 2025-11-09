using System.ComponentModel.DataAnnotations;

namespace SistemaControlProductos.Models
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }

        public string Contacto { get; set; }

        public string Telefono { get; set; }
    }
}