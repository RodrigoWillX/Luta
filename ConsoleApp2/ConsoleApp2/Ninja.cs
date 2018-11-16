using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Ninja
    {
        public string nome;
        protected int vida, forca, velocidade;

        
        public void Socar()
        {
            Console.WriteLine( nome  + "socando!");
        }
        public void Chutar()
        {
            Console.WriteLine( nome + "chutando!");
        }
    }
}