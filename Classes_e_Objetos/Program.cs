using System;
using ProgramaGerente;
namespace ProgramaPrincipal{
    class ProgramaPrincipal{
        public static void Main()
        {
            //Instanciando o gerente
            var objetoGerente = new Gerente();
            //Chamando propriedades e atributos de uma classe
            objetoGerente.CPF = "123456789";
            objetoGerente.Nome = "Nome de Gerente";
            objetoGerente.AprovarHoras();
            
        }
    }
}