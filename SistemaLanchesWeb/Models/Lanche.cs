namespace SistemaLanchesWeb.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //Relação entre as tabelas Lanche x Gategoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
