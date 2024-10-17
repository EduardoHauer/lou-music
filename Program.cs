string msgDeBoasVindas = "Boas vindas ao Lou music";
 
void ExibirMEnssagensDeBoasVindas()
{
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
    int opcaoEscolhidaNumerica =  int.Parse(opcaoEcolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Opcao escolhida " + opcaoEscolhidaNumerica);
            break;
        case 2:
            Console.WriteLine("Opcao escolhida " + opcaoEscolhidaNumerica);
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
        default: Console.WriteLine("Obrigado!");
            break;

    }
}

ExibirMEnssagensDeBoasVindas();
ExibirmenuDeOpcoes();