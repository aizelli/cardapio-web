using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name ="Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao_Curta { get; set; }

        public string Descricao_Detalhada { get; set; }
        public decimal Preco { get; set; }
        public bool Produto_Preferido { get; set; }
        public bool Em_Estoque { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
