using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cript
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 64654;
            //Console.WriteLine("digite a chave global");
            //string chaveGlobal = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Criar arquivo");
                Console.WriteLine("2 - Ler arquivo");
                Console.WriteLine("3 - Fazer operação");
                Console.WriteLine("4 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Console.WriteLine("Quantos arquivos deseja gerar? ");
                        int Qtd = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < Qtd; i++)
                        {
                                                        
                            Console.WriteLine("digite a chave");
                            string chave = Console.ReadLine();
                            Console.WriteLine("digite o texto ");
                            string input = Console.ReadLine();
                            Console.WriteLine("digite o nome do arquivo");
                            string arquivo = Console.ReadLine();
                            if (Criptografia.Criptografar(chave, input, arquivo))
                            {
                                Console.WriteLine("Arquivo gerado com sucesso ! \n");
                            }
                            else
                            {
                                Console.WriteLine("Erro ao gerar aquivo");
                            }
                        }
                       
                        break;

                    case 2:
                        
                        Console.WriteLine("digite o nome do arquivo");
                        string arquivoLer = Console.ReadLine();
                        Console.WriteLine("digite a chave");
                        string DecScahve = Console.ReadLine();
                        Decriptografia.Decriptografar(DecScahve, arquivoLer);                        
                        break;

                    case 3:
                     
                        Console.WriteLine("digite o nome do arquivo 1 ");
                        string Ler1 = Console.ReadLine();
                        Console.WriteLine("digite a chave");
                        string cha1 = Console.ReadLine();
                        String num1 = Decriptografia.Decriptografar(cha1, Ler1);
                       
                        Console.WriteLine("digite o nome do arquivo 2 ");
                        string Ler2 = Console.ReadLine();
                        Console.WriteLine("digite a chave");
                        string cha2 = Console.ReadLine();
                        String num2 = Decriptografia.Decriptografar(cha2, Ler2);
                 
                        Console.WriteLine("digite o nome do arquivo 3 ");
                        string Ler3 = Console.ReadLine();
                        Console.WriteLine("digite a chave");
                        string cha3 = Console.ReadLine();
                        String oper = Decriptografia.Decriptografar(cha3, Ler3);

                        int operacao = Calculo.Calcular(num1, num2, oper);
                        string ResultOp = operacao.ToString();
                        string nom = "Resultado";
                        Console.WriteLine("digite a chave do arquivo de resultado");
                        string cha4 = Console.ReadLine();
                        if (Criptografia.Criptografar(cha4, ResultOp, nom))
                         {
                            Console.WriteLine("Arquivo com nome ---Resultado.txt--- gerado com sucesso !");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao gerar aquivo");
                        }

                        Console.WriteLine(operacao);                                       
                        Console.ReadKey();
                        break;
                    case 4:
                        op = 0;
                        break;

                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0); 
        }
    }
}
