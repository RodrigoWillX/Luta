using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class SubZero : Ninja
    {
        public void subzero()
        {
            nome = "SubZero";
            vida = 10;
            forca = 8;
            velocidade = 9;
            Socar();
            Chutar();
            Gelo();            TempoDeCongelamento = 5;

        }

        public int TempoDeCongelamento;

        public void Gelo()
        {
            Console.WriteLine("Lancando gelo!");
        }
    }
}
