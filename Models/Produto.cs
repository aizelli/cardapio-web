using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        //Propriedades (colunas) do objeto (tabela) Produtos 
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Nome do produto")]
        [Required(ErrorMessage = "Compo obrigatório")]
        [MinLength(10, ErrorMessage = "Nome do produto deve ter no mínimo {1} Caracteres")]
        [MaxLength(100, ErrorMessage = "Nome do produto deve ter no máximo {1} Caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição curta do produto")]
        [Required(ErrorMessage = "Compo obrigatório")]
        [MinLength(10, ErrorMessage = "A Descrição curta do produto deve ter no mínimo {1} Caracteres")]
        [MaxLength(150, ErrorMessage = "A Descrição curta do produto deve ter no máximo {1} Caracteres")]
        public string Descricao_Curta { get; set; }

        [Display(Name = "Descrição detalhada do produto")]
        [Required(ErrorMessage = "Compo obrigatório")]
        [MinLength(10, ErrorMessage = "A Descrição detalhada do produto deve ter no mínimo {1} Caracteres")]
        [MaxLength(500, ErrorMessage = "A Descrição detalhada do produto deve ter no máximo {1} Caracteres")]
        public string Descricao_Detalhada { get; set; }

        [Display(Name = "Preço do produto")]
        [Required(ErrorMessage = "Compo obrigatório")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Endereço da imagem do produto")]
        public string Local_Imagem { get; set; }

        [Display(Name = "Produto preferido?")]
        public bool Produto_Preferido { get; set; }

        [Display(Name = "Estoque do produto")]
        public bool Em_Estoque { get; set; }

        //Relacionamento com tabela Categoria
        public virtual Categoria Categoria { get; set; }
    }
}
