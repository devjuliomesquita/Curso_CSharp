using System;
using static System.Console;

namespace Program{
    class MyProgram{
        public static void Main()
        {
            //Interpolação de strings
            WriteLine("===>Funções de strings.<===");

            //Declarando as variáveis do programa 
            string tam = "tamanho";
            string frase = "  Testando a função de texto.   ";
            string [] frases = {"C# para iniciantes.", "Testando a função de texto.", "Liberdade acima de tudo."};


            ///Contanto a quantidade de carcteres
            WriteLine($"A palavra contém: {tam.Length} caracteres."); //*saída um inteiro 
            ///Informa qual a primeira possição que se encontra essa letra. Sempre inicia a contagem pelo 0.
            WriteLine($"A letra está na posição: {tam.IndexOf("m")}."); //*saída um inteiro

            WriteLine($"Frase sem nenhum trim : {frase}\nCom {frase.Length} caracteres.");
            ///Manipulação com a função Trim(), TrimStart() e TrimEnd()
            WriteLine($"Frase com o trim : {frase.Trim()}\nCom {frase.Trim().Length} caracteres.");
            WriteLine($"Frase com o trimStart : {frase.TrimStart()}\nCom {frase.TrimStart().Length} caracteres.");
            WriteLine($"Frase com o trimEnd : {frase.TrimEnd()}\nCom {frase.TrimEnd().Length} caracteres.");

            ///Deixa a frase toda em Maiúsculo
            WriteLine($"Frase com a função ToUpper : {frase.ToUpper()}");
            ///Deixa a frase toda em Minúsculo
            WriteLine($"Frase com a função ToLower : {frase.ToLower()}");

            ///Extraindo da frase apenas a quantidade de caracteres desejada
            WriteLine($"Frase com a função Remove : {frase.Remove(10)}");
            ///Utilizando a função Remove com o Trim
            WriteLine($"Frase com a função Remove : {(frase.Trim()).Remove(10)}");
            ///Utilizando a função Remove com o IndexOf dentro de um loop
            foreach(var palavra in frases){
                WriteLine($"Palavra extraída  é: {palavra.Remove(palavra.IndexOf(" "))}");
            }
            
        }
    }
}
