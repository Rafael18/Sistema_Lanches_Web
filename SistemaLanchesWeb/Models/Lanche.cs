using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaLanchesWeb.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O Nome do lanche deve ser informado.")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Descrição Detalhada do lanche deve ser informado.")]
        [MinLength(20, ErrorMessage = "Descrição de ter no minimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres.")]
        [Display(Name = "Descrição  detalahada do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A Descrição do lanche deve ser informado.")]
        [MinLength(20, ErrorMessage = "Descrição de ter no minimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres.")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O Preço do lanche deve ser informado.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O Preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres.")]
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres.")]
        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //Relacionamento entre as tabelas Lanche x Gategoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
