using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOBJ
{
    public class Filme
    {
        public string nome; // atributos/propriedades:
        public string desc;
        public string ano;
        public string studio;
        public List<string> atores = new List<string>(); // lista de atores.

        public void Executar() // método:
        {   //ENTRADA DE DADOS
            Console.WriteLine(" DADOS DO FILME:");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o nome do filme: ");
            nome = Console.ReadLine();            
            Console.WriteLine("Digite o ano do filme: ");
            ano = Console.ReadLine();            
            Console.WriteLine("Digite o studio do filme: ");
            studio = Console.ReadLine();
            Console.WriteLine("Digite a descrição do filme: ");
            desc = Console.ReadLine();

            //VISUALIZAÇÃO DE DADOS INSERIDOS
            Console.WriteLine(" ");
            Console.WriteLine(" -----  CINE PROGRAMAÇÃO  -----");
            Console.WriteLine(" Filme:   " + nome);
            Console.WriteLine(" Ano:     " + ano);
            Console.WriteLine(" Estúdio: " + studio);
            Console.WriteLine(" Sinopse: " + desc);
            Console.WriteLine(" ");

            //OUTRA FORMA DE APRESENTAR OS DADOS INSERIDOS:
            //Console.WriteLine(" ");
            //Console.WriteLine(" -----  CINE PROGRAMAÇÃO  -----");
            //Console.WriteLine(" Filme: " + "     Ano: " + "     Estúdio: ");
            //Console.WriteLine(nome + "  " + ano + "     " + studio);
            //Console.WriteLine("");


        }

        public void Pausar() // método
        {
            //Console.WriteLine(" || ");
        }
    }


}
