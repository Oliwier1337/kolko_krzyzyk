using System;

using System.Threading;


namespace Kolko_i_Krzyzyk

{

    class Program

    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice; 

        static int flag = 0;
        static void Main(string[] args)

        {

            do
            {
                Console.Clear();
                Console.WriteLine("Gracz1: X , Gracz2: O");
                Console.WriteLine("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Tura Gracza 2");
                }

                else
                {
                    Console.WriteLine("Tura Gracza 1");
                }
                Console.WriteLine("\n");

                Board();

                choice = int.Parse(Console.ReadLine());  

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }

                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }

                else 
                {
                    Console.WriteLine("rząd {0} jest już zajęty przez: {1}", choice, arr[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Poczekaj sekundę, trwa ładowanie...");

                    Thread.Sleep(1000);
                }

                flag = CheckWin();

            } while (flag != 1 && flag != -1);


            Console.Clear();

            Board();


            if (flag == 1)  
            {
                Console.WriteLine("Gracz {0} wygrał", (player % 2) + 1);
            }

            else
            {
                Console.WriteLine("Remis");
            }

            Console.ReadLine();
        }
        
