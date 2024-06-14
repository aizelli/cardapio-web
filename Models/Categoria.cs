using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome da categoria")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Descrição da categoria")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }
    }
}
