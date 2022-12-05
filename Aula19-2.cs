using System;

class Aula19{

    static void Main(){

        int[] num=new int[10];

        // você prepara o for desse modo: for(e1;e2;e3) onded cada "e" é uma expressão
        for(int i=0;i<num.Length; i++){
            num[i]=0;
        }
         for(int i=0;i<num.Length; i++){
            Console.WriteLine("o valor de num na pos {0}: {1}", i, num[i]);
        }   

    }
}