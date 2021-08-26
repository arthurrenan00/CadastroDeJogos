using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroJogos.Models
{
    public class Funcionario
    {
        [Remote("Cod_Func_Uni", "funcionario", ErrorMessage = "Funcionário já cadastrado")]
        [Required(ErrorMessage = "Código de funcionário obrigatório")]
        [RegularExpression(@"^[0-9]{8}", ErrorMessage = "Somente números. É necessário possuir 8 caracteres")]
        public int Cod_Func { get; set; }

        [Required(ErrorMessage = "Nome do funcionário é obrigatório")]
        public string Nome_Func { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Insira um CPF válido: xxx.xxx.xxx-xx")]
        [Required(ErrorMessage = "CPF obrigatório")]
        public string Cpf_Func { get; set; }

        [Required(ErrorMessage = "Rg obrigatório")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "Insira um Rg válido: xx.xxx.xxx-x")]
        public string Rg_Func { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data de Nascimento Obrigatória")]
        public DateTime DtNasc_Func
        {
            get
            {
                return this.dtNasc_Func.HasValue
                    ? this.dtNasc_Func.Value
                    : DateTime.Now;
            }

            set
            {
                this.dtNasc_Func = value;
            }
        }
        private DateTime? dtNasc_Func = null;

        [Required(ErrorMessage = "Endereço do funcionário obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 100")]
        public string Ende_Func { get; set; }

        [Required(ErrorMessage = "Celular do funcionário obrigatório")]
        [RegularExpression(@"^\([1 - 9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0 - 9]{ 4}$)", ErrorMessage = "Celular válido:(xx)9xxxx-xxxx")]
        public string Cell_Func { get; set; }

        [Required(ErrorMessage = "Email do funcionário obrigatório")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um E-mail Válido")]
        public string Email_Func { get; set; }

        [Required(ErrorMessage = "Cargo do funcionário obrigatório")]
        public string Cargo { get; set; }
    }
}