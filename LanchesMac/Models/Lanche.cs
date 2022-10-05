using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table ("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe o nome do Lanche")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe a descrição do Lanche")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe a descrição detalhada do Lanche")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do Lanche")]
        [Display (Name = "Preço do Lanche")]
        [Column (TypeName = "Decimal(10,2)")]
        [Range (1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1}")]
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1}")]
        [Display(Name = "Caminho Thumbail")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque?")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
