using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicacaoDeEstudoASPNETMVC.Models
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:(##) #####-####}", ApplyFormatInEditMode = true)]
        public string Telefone { get; set; }
    }
}