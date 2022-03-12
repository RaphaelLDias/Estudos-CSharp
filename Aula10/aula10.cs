using System;

class Aula10{
    static void Main(){
        string senha="123";
        string senhaUser;
        int tentativa=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhaUser=Console.ReadLine();
            tentativa++;
        }while(senha != senhaUser);

        Console.Clear();

        Console.WriteLine("Senha correta! Tentativa:{0}", tentativa);

    }
}