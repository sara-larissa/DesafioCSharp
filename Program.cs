int x = 1;

Console.WriteLine(" ----> Você está usando a CALCULADORA DE MÉDIAS <----");
                Console.WriteLine("----> As notas deverão ser apresentadas de 0 a 10 <----");
                Console.WriteLine("Digite OK e ENTER para proceguir:");
                Console.ReadLine();

do
{
    int numValores = 0;
    float somaTotal = 0;
    float parcialN = 0;
    double notaFinal = 0;
    string mediaVisivel = "";

    Console.WriteLine("Digite a quantidade de notas a ser calculada:");
    numValores = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numValores; i++)
    {
        Console.WriteLine("Digite a nota " + i +":");
        parcialN = float.Parse(Console.ReadLine());
        somaTotal = somaTotal + parcialN;
    }
    
    notaFinal = somaTotal/numValores;
    mediaVisivel = notaFinal.ToString("0.00");

    Console.WriteLine("A média do aluno foi: " + mediaVisivel);

    if(notaFinal >= 6)
    {
        Console.WriteLine("Parabéns, aprovado");
    }
    else
    {
        Console.WriteLine("Você está de recuperação!");        
    }

    Console.WriteLine(@"Deseja calcular mais médias?
    Sim - Digite 1
    Não - Digite 0");
    x = int.Parse(Console.ReadLine());

} while (x == 1);

Console.WriteLine("Obrigado por utilizar a calculadora de médias!");

