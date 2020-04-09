using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Carta
    {

        public string naipe { get; set; }
        public string nome { get; set; }


        public Carta(string nome, string naipe)
        {
            this.naipe = naipe;
            this.nome = nome;
        }


    }
}
