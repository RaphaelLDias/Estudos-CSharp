using System;

class Aula06{
    static void Main(){
        
        int[] n=new int[5];
        int[] num=new int[3]{55,77,99};
        int[] num2={44,88,10};

        string[] veiculos=new string [3];

        veiculos[0]="Carro";
        veiculos[1]="moto";
        veiculos[2]="Avião";

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(n[0]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num2[1]);
        Console.WriteLine(veiculos[1]);
    }
}