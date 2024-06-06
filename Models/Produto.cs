namespace CardapioWeb.Models
{
    public class Produto
    {
        //Propriedades (colunas) do objeto (tabela) Produtos 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao_Curta { get; set; }
        public string Descricao_Detalhada { get; set; }
        public decimal Preco { get; set; }
        public string Local_Imagem { get; set; }
        public string Minitura_Imagem { get; set; }
        public bool Produto_Preferido { get; set; }
        public bool Em_Estoque { get; set; }

        //Relacionamento com tabela Categoria
        public int Categoria_Id { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
