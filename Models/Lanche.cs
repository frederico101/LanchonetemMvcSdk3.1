using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(250)]
        public string DescricaoDetalhada { get; set; }
        
        [Column(TypeName="decimal(18,2)")]
        public Decimal Preco { get; set; }
        [StringLength(300)]
        public string ImagemUrl { get; set; }
        [StringLength(300)]
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}