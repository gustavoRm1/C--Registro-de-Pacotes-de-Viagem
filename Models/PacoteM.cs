using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_login.Models
{
    public class PacoteM
    {
        //declaracao de variaveis
        public int id{get; set;}
        public string origem {get; set;}
        public string destino {get; set;}
        public string mes {get; set;}
        public string ida {get; set;}
        public string volta {get; set;}
        public string preco {get; set;}
    }
}