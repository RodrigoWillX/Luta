using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Scorpion : Ninja
    {
        public void scorpion()
        {
            nome = "Scorpion";
            vida = 10;
            forca = 9;
            velocidade = 8;
            Socar();
            Chutar();
            Arpao();
            Distancia = 5;

        }
        public int Distancia;
        public void Arpao()
        {
            Console.WriteLine("Lancando arpao!");
        }
    }
}
