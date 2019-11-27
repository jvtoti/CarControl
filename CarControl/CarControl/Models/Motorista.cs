using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarControl.Models
{
    public class Motorista
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor insira um nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor insira o Rg")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Por favor insira a Cnh")]
        public string Cnh { get; set; }
        [Required(ErrorMessage = "Por favor insira o CPf")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Por favor insira a Categoria da Cnh")]
        public string CategoriaCnh { get; set; }
        [Required(ErrorMessage = "Por favor insira um Status")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Por favor insira um Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor insira a validade da Cnh")]
        public string ValidadeCnh { get; set; }
        [Required(ErrorMessage = "Por favor insira sua Data de nascimento")]
        public string DataNasc { get; set; }
        [Required(ErrorMessage = "Por favor insira o Seguro de vida")]
        public string SeguroDeVida { get; set; }
    }
}