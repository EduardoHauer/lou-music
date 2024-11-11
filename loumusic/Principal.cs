using System;
using System.Data;
using System.Runtime;
using System.Security.Principal;
internal class Programa
{
    private static void Main(string[] args)
    { 
        
        Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        
       
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
                    AvaliarBanda();
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
            bandasRegistradas.Add(nomeBanda, new List<int>());
            Console.WriteLine($"A banda {nomeBanda} foi registrada");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirmenuDeOpcoes();
        }
        
        void MostrarBanadasRegistradas(){
            Console.Clear();
            Console.WriteLine("Bandas rgistradas:\n");
            foreach(string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.Write($"\n O tota de banda é: {bandasRegistradas.Count}\n");
            Console.WriteLine("\n Pressione qualque tecla para volatr ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirmenuDeOpcoes();
        }

        void AvaliarBanda()
        {
            Console.Clear();
            Console.Write("Digite o nome da banda que você quer avaliar: ");   
            string nomeBanda = Console.ReadLine()!;
            if(bandasRegistradas.ContainsKey(nomeBanda)){

                Console.WriteLine($"Qual nota você daria para a banda {nomeBanda}: ");
                int notaBanda = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomeBanda].Add(notaBanda);
                Console.WriteLine($"A banda {nomeBanda} recebeu a(s) nota(s): {notaBanda}");
                Thread.Sleep(4000);
                Console.Clear();
                ExibirmenuDeOpcoes();
            } else{
                Console.WriteLine("Banda escolhida não está registrada");
                Console.WriteLine("aperte qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                ExibirmenuDeOpcoes();

            }

        }

        ExibirMEnssagensDeBoasVindas();
        ExibirmenuDeOpcoes();
    }
}