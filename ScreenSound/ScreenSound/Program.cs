//Screen Sound

List<string> listaDeBandas = new List<string>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    string opcaoEscolhida;
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("---------------------MENU---------------------");
    Console.WriteLine("1 - Registrar Banda");
    Console.WriteLine("2 - Listar Bandas");
    Console.WriteLine("3 - Avaliar Banda");
    Console.WriteLine("4 - Exibir a média de avaliação de uma Banda");
    Console.WriteLine("0 - Sair");
    Console.Write("\nDigite a opção desejada: ");
    opcaoEscolhida = Console.ReadLine()!;
    switch (opcaoEscolhida)
    {
        case "1":
            RegistrarBanda();
            break;
        case "2":

            break;
        case "3":
            Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case "4":
            Console.WriteLine("Opção escolhida: " + opcaoEscolhida);
            break;
        case "0":
            Console.WriteLine("Programa encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente Novamente.");
            ExibirOpcoesDoMenu();
            break;

    }
}

void RegistrarBanda()
{
    string nomeBanda;
    Console.Clear();
    Console.WriteLine("Resgistro de Banda");
    Console.Write("Digite o nome da Banda: ");
    nomeBanda = Console.ReadLine()!;
    Cadastrar(listaDeBandas, nomeBanda);
    Console.WriteLine("A banda {0} foi registrado com sucesso!", nomeBanda);
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
    Console.Clear();
}

void ListarBandas()
{
    Console.Clear();
}


void Cadastrar(List<string> lista, string valor)
{
    lista.Add(valor);
}

void Listar(List<string> lista)
{
    foreach (string valor in lista)
    {

    }
}

ExibirOpcoesDoMenu();

