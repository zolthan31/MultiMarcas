using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiMarcas.API.Models
{
    public class Product
    {
        public int ProdutotId { get; set; }
        public string Peca { get; set; }
        public string Marca { get; set; }
        public string Valor { get; set; }
        public string Tamanhos { get; set; }
        public int Quantidade { get; set; }
        public string ImagemURL { get; set; }
    }
}