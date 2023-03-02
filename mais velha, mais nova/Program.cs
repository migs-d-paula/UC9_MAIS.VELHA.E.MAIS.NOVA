//CRIANDO AS VARIAVEIS
string[,] matriz = new string[10, 3];
string pergunta = "", letra = "";
int coluna, linha, homem, mulher, idademenor, idademenor2, idademaior, idademaior2;

//DANDO VALOR AS VARIAVEIS
homem = 0;
mulher = 0;
idademaior = 0;
idademenor = 999;

//CRIANDO A REPETIÇÃO DA MATRIZ
for (linha = 0; linha < 10; linha++)
{
    for (coluna = 0; coluna < 3; coluna++)
    {
        if (coluna == 0)
        {
            pergunta = "Qual o seu nome?";
        }
        if (coluna == 1)
        {
            pergunta = "Qual a sua idade?";
        }
        if (coluna == 2)
        {
            pergunta = "Qual o seu sexo?";
        }

        Console.WriteLine(pergunta);
        matriz[linha, coluna] = Console.ReadLine();

        if (matriz[linha, 2] == "masculino")
        {
            homem++;
        }
        if (matriz[linha, 2] == "feminino")
        {
            mulher++;
        }

        Console.Clear();
    }
    Console.WriteLine("");

    //FAZENDO A CONTA DE QUEM TEM A MENOR IDADE
    idademenor2 = int.Parse(matriz[linha, 1]);

    if (idademenor2 < idademenor)
    {
        idademenor = idademenor2;
    }
    //FAZENDO A CONTA DE QUEM TEM A MAIOR IDADE
    idademaior2 = int.Parse(matriz[linha, 1]);

    if (idademaior2 > idademaior)
    {
        idademaior = idademaior2;
    }
}


//VENDO A QUANTIDADE DE HOMENS E MULHERES
Console.WriteLine("Há " + homem + " pessoas do sexo masculino");
Console.WriteLine("\n\nHá " + mulher + " pessoas do sexo feminino");
Console.WriteLine("\n\nClique enter para continuar");
Console.ReadLine();
Console.WriteLine("A pessoa mais velha tem " + idademaior + " Anos");
Console.WriteLine("\n\nClique enter para continuar");
Console.ReadLine();
Console.WriteLine("A pessoa mais nova tem " + idademenor + " Anos");
Console.WriteLine("\n\nClique enter para mostrar a tabela");
Console.ReadLine();

//MOSTRANDO A TABELA COM NOMES, IDADES E SEXO
for (linha = 0; linha < 10; linha++)
{
    for (coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(" " + matriz[linha, coluna] + " ");
    }
    Console.WriteLine("");
}