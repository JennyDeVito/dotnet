using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProgramacaoOrientadaObjetos.Models
{
    public class VendaProp

    {
        public int Id { get; set; }

        // atributo para fazer a relação entre a key fora do padrão do C# do
        // arquivo de leitura com a propriedade da classe
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; } = "";
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}