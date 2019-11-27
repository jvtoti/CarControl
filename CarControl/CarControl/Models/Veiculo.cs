using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarControl.Models
{
    public class Veiculo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Por favor insira o id do Motorista")]
        public int id_Motorista { get; set; }
        [Required(ErrorMessage = "Por favor insira a placa")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Por favor insira o modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Por favor insira a marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Por favor insira se o veiculo possui seguro(sim ou não)")]
        public string VeiculoSegurado { get; set; }
    }
}