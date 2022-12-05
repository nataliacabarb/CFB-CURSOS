using System;

class Aula20{

    static void Main(){

        int[] num=new int[10];

        //while 
        //montagem while(e1){} e utiliza só uma expressão lógica
        int i=0 ;      
        while(i<num.Length){
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do loop");

    }
}