using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaLanchesWeb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Informe o nome da Categoria.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres.")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe a Descrição da categoria.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //Relacionamento entre as tabelas Categiria x Lanche
        public List<Lanche> Lanches { get; set;}
    }
}
