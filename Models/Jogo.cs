using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroJogos.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        [RegularExpression(@"^[0-9]{8}", ErrorMessage = "Somente números/Necessário ter 8 caracteres")]
        [Remote("Cod_J_Unico", "jogo", ErrorMessage = "Este código de jogo já existe")]
        public int Cod_Jogo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome_Jogo { get; set; }

        public string Versao_Jogo { get; set; }

        [Required(ErrorMessage = "O desenvolvedor é obrigatório")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Insira o desenvolvedor de 2 a 20 caracteres")]
        public string Desenvolvedor { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Insira o gênero de 4 a 20 caracteres")]
        public string Genero_Jogo { get; set; }

        [Required(ErrorMessage = "A faixa etária é obrigatória")]
        public string Faixa_Etaria { get; set; }

        [Required(ErrorMessage = "A plataforma é obrigatória")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 20")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "Ano de lançamento é obriagtório")]
        [RegularExpression(@"^[0-9]{4}", ErrorMessage = "Somente números e necessário ter 4 caracteres")]
        public int Ano_Lanc { get; set; }

        [Required(ErrorMessage = "A sinopse é obrigatória")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Insira no mínimo 20 caracteres e no máximo 500")]
        public string Sinopse { get; set; }

    }
}