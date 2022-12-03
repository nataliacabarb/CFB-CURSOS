using System;
class Aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){
       // DiasSemana ds = (DiasSemana)3; //cast
        int ds = (int)DiasSemana.Sexta;     //aqui terei o valor do meu índice para sexta
        Console.WriteLine(ds);
        
    }
}
