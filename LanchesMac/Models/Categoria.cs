using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table ("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength (100,ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o Nome da Categoria")]
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
