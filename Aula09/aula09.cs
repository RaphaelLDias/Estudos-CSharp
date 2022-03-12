using System;

class Aula09{
    static void Main(){

        int[] num=new int[10];

        int i=0;
        while(i<num.Length){
            num[i]=0;
            Console.WriteLine(num[1]);
            i++;
        }
        Console.WriteLine("Fim do loop");
    }
}