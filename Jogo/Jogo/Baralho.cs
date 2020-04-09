using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Baralho
    {

        private Carta[] BaralhoEmbaralhado;
        //Todas as posições do array começam em -1 para que durante a verificão de numeros repetidos, nenhum objeto seja igual a null ou maior que 1
        private int[] PosicaoAletoria = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };


        /// <summary>
        /// Metodo que gera um pilha de cartas embaralhadas aleatoriamente
        /// </summary>

        public void Embaralhar()
        {
            Console.WriteLine("Embaralhando as cartas...");

            GerarPosicoes();


            BaralhoEmbaralhado = new Carta[54];


            BaralhoEmbaralhado[PosicaoAletoria[1]] = new Carta("A", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[2]] = new Carta("K", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[3]] = new Carta("Q", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[4]] = new Carta("J", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[5]] = new Carta("10", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[6]] = new Carta("9", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[7]] = new Carta("8", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[8]] = new Carta("7", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[9]] = new Carta("6", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[10]] = new Carta("5", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[11]] = new Carta("4", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[12]] = new Carta("3", "Espadas");
            BaralhoEmbaralhado[PosicaoAletoria[13]] = new Carta("2", "Espadas");

            BaralhoEmbaralhado[PosicaoAletoria[14]] = new Carta("A", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[15]] = new Carta("K", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[16]] = new Carta("Q", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[17]] = new Carta("J", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[18]] = new Carta("1", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[19]] = new Carta("9", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[20]] = new Carta("8", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[21]] = new Carta("7", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[22]] = new Carta("6", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[23]] = new Carta("5", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[24]] = new Carta("4", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[25]] = new Carta("3", "Copas");
            BaralhoEmbaralhado[PosicaoAletoria[26]] = new Carta("2", "Copas");

            BaralhoEmbaralhado[PosicaoAletoria[27]] = new Carta("A", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[28]] = new Carta("K", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[29]] = new Carta("Q", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[30]] = new Carta("J", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[31]] = new Carta("1", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[32]] = new Carta("9", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[33]] = new Carta("8", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[34]] = new Carta("7", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[35]] = new Carta("6", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[36]] = new Carta("5", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[37]] = new Carta("4", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[38]] = new Carta("3", "Ouros");
            BaralhoEmbaralhado[PosicaoAletoria[39]] = new Carta("2", "Ouros");

            BaralhoEmbaralhado[PosicaoAletoria[40]] = new Carta("A", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[41]] = new Carta("K", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[42]] = new Carta("Q", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[43]] = new Carta("J", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[44]] = new Carta("1", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[45]] = new Carta("9", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[46]] = new Carta("8", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[47]] = new Carta("7", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[48]] = new Carta("6", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[49]] = new Carta("5", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[50]] = new Carta("4", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[51]] = new Carta("3", "Paus");
            BaralhoEmbaralhado[PosicaoAletoria[52]] = new Carta("2", "Paus");

            BaralhoEmbaralhado[PosicaoAletoria[53]] = new Carta("coringa", "coringa");

            BaralhoEmbaralhado[PosicaoAletoria[0]] = new Carta("coringa", "coringa");



            for (int i = 0; i < BaralhoEmbaralhado.Length ; i++)

            {
                int num = i + 1;  
                
                Console.WriteLine($"Carta {num}º : nome--- {BaralhoEmbaralhado[i].nome} naipe----{BaralhoEmbaralhado[i].naipe}");
            }


        }

        private int NumeroAleatorio()
        {
            //Cria um numero aleatorio e verifica se ele ja foi usado no "PosicaoAletoria"
            //Caso o numero ja tenha sido usado, gera outro numero aleatorio na variavel "novatentativa"
            var randNum = new Random();
            var tentativa = randNum.Next(0, PosicaoAletoria.Length);
            bool Repetido = false;


            for (int i = 0; i < PosicaoAletoria.Length; i++)
            {
                if (tentativa == PosicaoAletoria[i])
                {
                    Repetido = true;
                    break;

                }

                Repetido = false;

            }

            if (Repetido == false)
            {
                return tentativa;
            }
            else
            {
                int novatentativa = NumeroAleatorio();
                return novatentativa;
            }


        }


        private void GerarPosicoes()
        {
            //altera os valores do array "PosicaoAletoria" para numeros aleatorios não repetidos

            for (int i = 0; i < PosicaoAletoria.Length; i++)
            {
                PosicaoAletoria[i] = NumeroAleatorio();

            }





        }



    }
}
