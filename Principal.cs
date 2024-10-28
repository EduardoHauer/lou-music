using System;
using System.Data;
using System.Runtime;
using System.Security.Principal;
internal class Programa
{
    private static void Main(string[] args)
    { 
        
        List<String> listaBandas = new List<string>()
        {
            "Testament", "Megadeth", "Limp Bizkit", "Sepultura"
        };

        void ExibirMEnssagensDeBoasVindas()
        {
            string msgDeBoasVindas = "Boas vindas ao Lou music";
            Console.WriteLine(@"𝕷𝖔𝖚 𝖒𝖚𝖘𝖎𝖈");
            Console.WriteLine(msgDeBoasVindas);
        }

        void ExibirmenuDeOpcoes()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite 0 para sair");


            Console.Write("\nDigite sua opcao:");
            string opcaoEcolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEcolhida);
            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBandas();
                    break;
                case 2:
                    MostrarBanadasRegistradas();
                    break;
                case 3:
                    Console.WriteLine("Opcao escolhida " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Opcao escolhida " + opcaoEscolhidaNumerica);
                    break;
                case 0:
                    Console.WriteLine("Opcao escolhida  " + opcaoEscolhidaNumerica);
                    break;
                case 5:
                    Console.WriteLine("Escolha digitada é invalida " + opcaoEscolhidaNumerica);
                    break;
                default:
                    Console.WriteLine("Obrigado!");
                    break;

            }
        }

        void RegistrarBandas()
        {
            Console.Clear();
            Console.Write("Escolha uma banda: ");
            string nomeBanda = Console.ReadLine()!;
            listaBandas.Add(nomeBanda);
            Console.WriteLine($"A banda {nomeBanda} foi registrada");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirmenuDeOpcoes();
        }
        
        void MostrarBanadasRegistradas(){
            Console.Clear();
            Console.WriteLine("Bandas rgistradas:\n");
            foreach(string banda in listaBandas)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.Write($"\nO tota de banda é: {listaBandas.Count}\n");
            Console.WriteLine("\nPressione qualque tecla para volatr ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirmenuDeOpcoes();
        }

        ExibirMEnssagensDeBoasVindas();
        ExibirmenuDeOpcoes();
    }
}