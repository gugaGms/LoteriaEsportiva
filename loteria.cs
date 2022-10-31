using System;
					
public class LoteriaEsportiva
{
	public static void Main()
	{

		int[] apostas = new int [13];
          int[] sorteado = { 100, 110, 010, 001, 011, 100, 110, 010, 001, 011, 010, 110, 010};
            int apostar = 0, sorteio = 0, pontos = 0;
            
            Console.WriteLine("faca suas apostas:");
            Console.WriteLine("digite em sequencia: digite 100 para vitoria do time 1, 001 para vitoria do time 2, 010 para empate, e para apostas duplas 110/011");
            Console.WriteLine("\nTIME 1  | Empate | Time 2\n");
            
            for(int i =0; i < 13; i++)
            {
             apostas[i] = int.Parse(Console.ReadLine());
             
             apostar = apostas[i];
             sorteio = sorteado[i];
             
              if (apostar == sorteio)
              {
                 pontos ++;
              }
            }
            
            Console.WriteLine("-------------------------------");
            Console.WriteLine("O jogador apostou:");
            Console.WriteLine("{0} ", String.Join(",", apostas));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("O resultado oficial:");
            Console.WriteLine("{0} ", String.Join(",", sorteado));
            Console.WriteLine("------------------------------");
            Console.WriteLine("A pontuacao total foi:");
            Console.WriteLine(pontos);
			
	}
}
