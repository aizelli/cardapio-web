namespace CardapioWeb.Models
{
    public class Categoria
    {
        //Propriedades (colunas) do objeto (tabela) Categorias 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; } 
    }
}
