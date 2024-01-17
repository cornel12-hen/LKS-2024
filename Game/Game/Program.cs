using System;

class Game
{
    static void Main()
    {
        Random random = new Random();
        int myhp = 100;
        int enemyhp = 100;
        bool giliran = true;
        bool block = false;
        while (true)
        {
            int choice = 0;
            if (myhp == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Kamu Kalah!");
                Environment.Exit(0);
            }
            else if (enemyhp == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Kamu Menang!");
                Environment.Exit(0);
            }
            Console.WriteLine("HP Kamu : " + myhp);
            Console.WriteLine("HP Musuh : " + enemyhp);
            Console.WriteLine();
            if (giliran == true)
            {
                Console.WriteLine("Giliranmu : (ketik 1 atau 2)");
                Console.WriteLine("1. Serang (Berikan 10 Damage pada musuh)");
                Console.WriteLine("2. Blok (Blokir Serangan untuk 1 kali giliran berikutnya)");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    if (block == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Musuh memblokir seranganmu!");
                        Console.WriteLine();
                        Console.WriteLine("==================================");
                        Console.WriteLine();
                        giliran = false;
                        block = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Kamu menyerang!");
                        Console.WriteLine();
                        Console.WriteLine("==================================");
                        enemyhp = enemyhp - 10;
                        giliran = false;
                        Console.WriteLine();
                        continue;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Kamu bertahan!");
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    giliran = false;
                    block = true;
                    continue;
                }
            }
            else if (giliran == false)
            {
                choice = random.Next(1, 3);
                if (choice == 1)
                {
                    if (block == true)
                    {
                        giliran = true;
                        Console.WriteLine("Musuh Menyerang, tapi kamu memblokir serangannya!");
                        Console.WriteLine();
                        Console.WriteLine("==================================");
                        Console.WriteLine();
                        block = false;
                        continue;
                    }
                    else
                    {
                        myhp = myhp - 10;
                        giliran = true;
                        Console.WriteLine("Musuh menyerang!");
                        Console.WriteLine();
                        Console.WriteLine("==================================");
                        Console.WriteLine();
                        continue;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Musuh bertahan!");
                    Console.WriteLine("==================================");
                    Console.WriteLine();
                    giliran = true;
                    block = true;
                    continue;
                }

            }
        }

    }
}