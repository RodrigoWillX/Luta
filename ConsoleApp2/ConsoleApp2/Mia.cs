using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Mia : Ninja
    {
        public void mia()
        {
            nome = "Mia";
            vida = 10;
            forca = 7;
            velocidade = 10;
            Socar();
            Chutar();
            Estrelas();            QuantidadeDeEstrelas = 5;

        }
        public int QuantidadeDeEstrelas;
        public void Estrelas()
        {
            Console.WriteLine("Lancando estrelas!");
        }
    }
}
