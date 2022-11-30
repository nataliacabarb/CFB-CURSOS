//aula de formatação de dados
using System;
class Aula06{
    static void Main(){
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "Patel";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Protudo...........: {0,15}", produto);
        Console.WriteLine("Valor da Compra....:{0,15:c}", valorCompra); //:c é a notação para a  de moeda
        Console.WriteLine("Lucro..............:{0,15:p}",lucro); //:p é a notação para a porcentagem
        Console.WriteLine("Valor de Venda.....:{0,15:c}", valorVenda);    
    }
}