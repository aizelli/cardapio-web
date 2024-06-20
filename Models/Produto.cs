using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(100, ErrorMessage = "Limite de até {0} caracteres")]
        public string Nome { get; set; }

        [Display(Name ="Descrição curta do produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao_Curta { get; set; }

        [Display(Name = "Descrição detalhada do produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao_Detalhada { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public decimal Preco { get; set; }

        [Display(Name = "Produto preferido")]
        public bool Produto_Preferido { get; set; }

        [Display(Name = "Produto em estoque")]
        public bool Em_Estoque { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
