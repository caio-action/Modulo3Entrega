using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaioCavalcante_atividadePratica.Models
{
    public class Destino
    {
        [Key]
        public int IdDestino { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeDestino { get; set; }
        [Required]
        [StringLength(10)]
        public string Preco { get; set; }
        [Required]
        public DateTime DataViagem { get; set; }
        public virtual List<Cliente> Clientes { get; set; }

    }
}
