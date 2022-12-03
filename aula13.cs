using System;
class Aula12{
    static void Main(){

      int n1,n2,n3,n4, media =0;
      string resultado;
      Console.WriteLine("Digite a nota 1 do aluno: ");    
      n1=int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a nota 2 do aluno: ");    
      n2=int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a nota 3 do aluno: ");    
      n3=int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a nota 4 do aluno: ");    
      n4=int.Parse(Console.ReadLine());
      media=(n1+n2+n3+n4)/4;

      if(media < 40){
        resultado= "Reprovado";
      }else if(media < 60){
        resultado= "Recuperação";
      }else {
         resultado="Aprovado";
      }
       
        
      Console.WriteLine("Resultado: {0}, o aluno está: {1}", media, resultado);
    }
}