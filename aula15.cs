using System;
class Aula15{
    static void Main(){
        int tempo=0;
        char escolha;
        int horas;

        Console.WriteLine("Belo Horizonte-MG a Vitória-ES");
        Console.WriteLine("Escolha o meio de transporte:[a] Avião, [c] Carro e [o] Ônibus");
        escolha=char.Parse(Console.ReadLine());

        
        switch(escolha){
            case 'a':
                tempo = 50;
                break;
            case 'c':
                tempo = 480;
                break;
            case 'o':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }
            horas=tempo/60;
        
            if(tempo<0){
                Console.WriteLine("Transporte indisponível");
            
            }else{
                Console.WriteLine("O tempo da viagem é: {0} minutos ou {1} horas", tempo, horas);
            }

        }
        
    }