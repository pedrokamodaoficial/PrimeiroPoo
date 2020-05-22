using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem batman = new Personagem();
            batman.nome = "Bruce Wayne";
            batman.idade = 40;

            Console.WriteLine( batman.Correr(20.5f) );
            Console.WriteLine( "Força : " + batman.Atacar(60f) );
            
            batman.pulando = true;
            Console.WriteLine( "Força : " + batman.Atacar(60f) );

        }
    }
}
