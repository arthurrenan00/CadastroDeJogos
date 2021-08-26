using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroJogos.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome_Cli { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Insira um CPF válido")]
        [Required(ErrorMessage = "CPF obrigatório")]
        [Remote("Cpf_Cli_Uni", "cliente", ErrorMessage = "CPF já cadastrado")]
        public string Cpf_Cli { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data de Nascimento Obrigatória")]
        public DateTime DtNasc_Cli
        {
            get
            {
                return this.dtNasc_Cli.HasValue
                    ? this.dtNasc_Cli.Value
                    : DateTime.Now;
            }

            set
            {
                this.dtNasc_Cli = value;
            }
        }
        private DateTime? dtNasc_Cli = null;

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um Email Válido")]
        public string Email_Cli { get; set; }

        [Required(ErrorMessage = "Tel5efone obrigatório")]
        [RegularExpression(@"^\([1 - 9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0 - 9]{ 4}$)", ErrorMessage = "Celular válido:(xx)9xxxx-xxxx")]
        public string Cell_Cli { get; set; }

        [Required(ErrorMessage = "Celular obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 100")]
        public string Ende_Cli { get; set; }
    }
}
