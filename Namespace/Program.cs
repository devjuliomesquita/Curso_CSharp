using System;
using Programa2;
namespace ProgramaPrincipal{
    //ClasseUm já está dentro do namespace Programa1
    class ClasseUm{
        public static void Main(string[] args)
        {
            //Chamando a classe de outro namespace por conta do using no início do código.
            ClasseDois classeDois = new ClasseDois();
            //Chamando a classe de outro namespace de um jeito mais verboso trazendo todo o caminho até a classe.
            Programa1.ClasseTres classeTres = new Programa1.ClasseTres();
            
        }
    }
}
