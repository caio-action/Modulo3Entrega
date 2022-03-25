using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaioCavalcante_atividadePratica.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [StringLength(100)]
        [Required]
        public string NomeCliente { get; set; }
        [StringLength(11)]
        [Required]
        public string CPF { get; set; }
        [StringLength(20)]
        public string CartaoDeCredito { get; set; }
        [StringLength(16)]
        public string Telefone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [ForeignKey("Destino")]
        [Required]
        public int IdDestino { get; set; }
        public virtual Destino Destino { get; set; }


    }
}
