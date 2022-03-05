using System;

class aula03{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse (Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32 (Console.ReadLine());
        soma = v1 + v2;

        Console.WriteLine("Seu nome é {0} e a soma de {1} mais {2} é igual a :{3}.", nome, v1, v2, soma);

    }
}