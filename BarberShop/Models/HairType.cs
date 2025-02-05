using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.Models
{
    public class HairType
    {
        [Key]
        public int HairTypeId { get; set; }

        [Required]
        public string NameType { get; set; }

        [Required]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }
       
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(50, ErrorMessage = "O {0} Deve ter no máximo {1}")]
        [Display(Name = "Descrição do tipo escolhido")]
        public string Description { get; set; }
        public string ImageThumbnail {  get; set; }
    }
}
