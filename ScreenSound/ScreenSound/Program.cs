﻿//Screen Sound

using System.Security;
using System.Xml.Serialization;

Dictionary<string,List<string>> dicionarioDeBandas = new Dictionary<string,List<string>>();

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
    ExibeTituloMenus("Boas vindas ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    string opcaoEscolhida;
    ExibirMensagemDeBoasVindas();
    ExibeTituloMenus("MENU");
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
            ListarBandas();
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

void ExibeTituloMenus(string titulo)
{
    Console.Write(string.Empty.PadRight(titulo.Length, '-') + titulo + string.Empty.PadLeft(titulo.Length, '-'));
    /*string separadores = string.Empty.PadLeft(titulo.Length, '-');
    Console.WriteLine(separadores);
    Console.WriteLine(titulo);
    Console.WriteLine(separadores);*/
}

void RegistrarBanda()
{
    string nomeBanda;
    Console.Clear();
    ExibeTituloMenus("Resgistro de Banda");
    Console.Write("Digite o nome da Banda: ");
    nomeBanda = Console.ReadLine()!;
    Cadastrar(nomeBanda, null, dicionarioDeBandas);
    Console.WriteLine("A banda {0} foi registrado com sucesso!", nomeBanda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistraAvaliacao()
{
    string avaliacao;
    string banda;
    Console.Clear();
    ExibeTituloMenus("Avaliar Banda");
    banda = VerificaBanda(dicionarioDeBandas);
    avaliacao = Console.ReadLine()!;
    Cadastrar(banda,avaliacao,dicionarioDeBandas);
    Console.WriteLine("Avaliação registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

string VerificaBanda(Dictionary<string,List<string>> dicionario)
{
    Console.Write("Digite o nome da Banda que deseja avaliar: ");
    string banda = Console.ReadLine()!;
    if (dicionario.ContainsKey(banda))
    {
        return banda;
    }
    else
    {
        Console.WriteLine($"Banda: {banda} - Não encontrada em nossa base, tente novamente ou digite 0 para retornar ao menu principal.");
        string valor = Console.ReadLine()!;
        if (valor == "0")
        {
            ExibirOpcoesDoMenu();
        }
        else
        {
            VerificaBanda(dicionario);
        }
    }
    return banda;
}

void ListarBandas()
{
    Console.Clear();
    ExibeTituloMenus("Lista das Bandas Cadastradas");
    Listar(dicionarioDeBandas);
    RetornarMenu();
}

void RetornarMenu()
{
    Console.WriteLine("Pressine qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void Cadastrar(string chave, string valor, Dictionary<string,List<string>> dicionario)
{
    if (chave != null && valor != null)
    {
        dicionario[chave].Add(valor);
        return;
    }
    else if (chave != null && valor == null)
    {
        dicionario.Add(chave, new List<string>());
        return;
    }
}


void Listar(Dictionary<string, List<string>> dicionario)
{
    foreach (string item in dicionario.Keys)
    {
        Console.WriteLine($"->{item}");
    }
}

ExibirOpcoesDoMenu();

