using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme film = new Filme();
            Entrada entrad = new Entrada();
            // Declaração      =   Instânciação

            // Chamada dos métodos

            Console.Write("Digite o título do filme: ");
            film.SetTitulo(Console.ReadLine());          // "Set" é para receber um valor
            Console.Write("Digite a sinopse: ");
            film.SetSinopse(Console.ReadLine());
            Console.Write("Digite o gênero: ");
            film.SetGenero(Console.ReadLine());
            Console.Write("Digite a classificação: ");
            film.SetClassificacao(Console.ReadLine());

            Console.Write("Digite o valor do ingresso: ");
            entrad.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o número da poltrona: ");
            entrad.SetPoltrona(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o dia e a hora: ");
            entrad.SetDataehora(Console.ReadLine());

            Console.WriteLine("\nDados do Ingresso");
            Console.WriteLine("Título:" + film.GetTitulo() + "\nSinopse: " + film.GetSinopse() + "\nGênero: " + film.GetGenero() + "\nClassificação: " + film.GetClassificacao());
            Console.WriteLine("Valor do ingresso: " + entrad.GetValor() + "\nPoltrona: " + entrad.GetPoltrona() + "\nData e hora: " +entrad.GetDataehora());
           


            Console.ReadKey();
        }
    }
}

        