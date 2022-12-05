using System;
class Aula17{
    static void Main(){
        //int n1,n2,n3,n4,n5;
        int[] n=new int [5];
        //int[] num=new int[3]{55,77,99}; //uma forma de declarar e inicializar com valores
        int[] num = {55,77,99}; //assim é mais fácil


        n[0]=111;
        n[1]=222;
        n[2]=333;
        n[3]=444;
        n[4]=555;

        Console.WriteLine(num[2]);
    }
}