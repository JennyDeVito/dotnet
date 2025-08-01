using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaObjetos.Models
{
    public class VendaNew
    {
        public int Id { get; set; }
        public string Produto { get; set; } = "";
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}