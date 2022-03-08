using System;

class Aula04{

enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};

static void Main(){

    DiasSemana ds = DiasSemana.Domingo;
    
    DiasSemana ds1 = (DiasSemana) 3;
    
    int ds2 = (int)DiasSemana.Sexta;

    Console.WriteLine(ds);
    Console.WriteLine(ds1);
    Console.WriteLine(ds2);
    }
}