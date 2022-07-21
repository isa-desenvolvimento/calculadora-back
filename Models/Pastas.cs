using System;
using System.ComponentModel.DataAnnotations;

namespace calculadora_api.Models

{
    public class Pastas
    {
        [Key]
        public int Id { get; set; }
        public string pasta { get; set; }
        public string contrato { get; set; }
        public string descricao { get; set; }
        public string cliente { get; set; }
        public string cnpj { get; set; }

    }
}