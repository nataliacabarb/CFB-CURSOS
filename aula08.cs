//lendo valores do teclado
using System;
class Aula08{
    static void Main(){
        int v1,v2,soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse (Console.ReadLine());
        soma = v1+v2;
        Console.WriteLine("os valores digitados foram {0} e {1} e o resultado da soma desses valores é: {2}",v1,v2, soma);
    }
}