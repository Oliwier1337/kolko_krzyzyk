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
                Console.WriteLine("Podaj liczbę od 1 do 9: ");
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


        private static void Board()
        {
            Console.WriteLine("     |     |    ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
  
        private static int CheckWin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }

            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }





            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }

            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }

            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {
                return 1;
            }





            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }




            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }



            else
            {
                return 0;
            }

        }

    }

}
