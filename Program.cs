using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar as notas
            float nota1, nota2, nota3, media;
            string nomeAluno;

            //Entrada de dados
            Console.Write("Digite o nome do aluno: ");
            nomeAluno = (Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado
            if(media>5) {
                //Valor verdadeiro
                Console.WriteLine("O aluno "+nomeAluno+" está aprovado com a média de "+media);
            }

            else {
                //Valor falso
                Console.WriteLine("O aluno "+nomeAluno+" está reprovado com média "+media);
            }
        }
    }
}
