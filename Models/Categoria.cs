using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        //Propriedades (colunas) do objeto (tabela) Categorias 
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome da categoria")]
        [Required(ErrorMessage ="Compo obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição da categoria")]
        [Required(ErrorMessage = "Compo obrigatório")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo 200 caracteres")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; } 
    }
}
