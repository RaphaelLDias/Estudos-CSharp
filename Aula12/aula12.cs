using System;

class Aula12{

static void Main(){
    Console.Write("Digite o primeiro valor:");
    int v1=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor:");
    int v2=int.Parse(Console.ReadLine());
    
    
    Console.WriteLine("A soma de {0} com {1} é: {2}", v1, v2, soma(v1,v2));
}

static int soma(int n1, int n2){
    int res= n1+n2;
    return res;
    }
}