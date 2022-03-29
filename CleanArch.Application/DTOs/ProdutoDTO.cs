using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Preço é obrigatório")]
        public decimal Preco { get; set; }
    }
}
