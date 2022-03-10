using System;

class Aula05{
    static void Main(){
        int tempo=0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Toledo-PR a Curitiba-PR");
        Console.WriteLine("Escolha seu transporte: [a] Avião, [o] ônibus, [c] Carro");

        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;
            
            case 'o':
            case 'O':
                tempo=660;
                break;
            
            case 'c':
            case 'C':
                tempo=480;
                break;
            
            default:
                tempo=-1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte Indisponível");
        } else{
            Console.WriteLine("O tempo para chegar ao destino é de {0} minutos", tempo);
        }
            Console.WriteLine("Selecionar outro meio de transporte?[s/n]");
            escolha=char.Parse(Console.ReadLine());
            if(escolha=='s' || escolha=='S'){
                goto inicio;
            } else{
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
    }
}