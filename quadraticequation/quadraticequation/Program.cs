using System;
class Kuadrat
{
    static void Main()
    {
        while (true)
        {
            int a;
            int b;
            int c;
            string pers = "";
            double x1;
            double x2;
            string ulang = "";
            Console.Write("Masukkan nilai a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai c : ");
            c = int.Parse(Console.ReadLine());
            x1 = (-b + Math.Sqrt(Rumus.Rumusabc(a, b, c))) / (2 * a);
            x2 = (-b - Math.Sqrt(Rumus.Rumusabc(a, b, c))) / (2 * a);
            Console.WriteLine();
            if ( a == 1)
            {
                if (b > 0)
                {
                    if (c >= 0)
                    {
                        pers = "x² " + "+ " + b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "x² " + "+ " + b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "x² " + "+ " + b + "x";
                    }
                }
                else if (b < 0)
                {
                    if (c >= 0)
                    {
                        pers = "x² " + "- " + -b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "x² " + "- " + -b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "x² " + "- " + -b + "x";
                    }
                }
                else if (b == 0)
                {
                    if (c >= 0)
                    {
                        pers = "x² " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "x² " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "x²";
                    }
                }
            }
            else if (a == -1)
            {
                if (b >= 0)
                {
                    if (c >= 0)
                    {
                        pers = "-x² " + "+ " + b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "-x² " + "+ " + b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "-x² " + "+ " + b + "x";
                    }
                }
                else if (b < 0)
                {
                    if (c >= 0)
                    {
                        pers = "-x² " + "- " + -b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "-x² " + "- " + -b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "-x² " + "- " + -b + "x";
                    }
                }
                else if (b == 0)
                {
                    if (c >= 0)
                    {
                        pers = "-x² " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = "-x² " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = "-x²";
                    }
                }
            }
            else
            {
                if (b >= 0)
                {
                    if (c >= 0)
                    {
                        pers = a + "x² " + "+ " + b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = a + "x² " + "+ " + b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = a + "x² " + "+ " + b + "x";
                    }
                }
                else if (b < 0)
                {
                    if (c >= 0)
                    {
                        pers = a + "x² " + "- " + -b + "x " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = a + "x² " + "- " + -b + "x " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = a + "x² " + "- " + -b + "x";
                    }
                }
                else if (b == 0)
                {
                    if (c >= 0)
                    {
                        pers = a + "x² " + "+ " + c;
                    }
                    else if (c < 0)
                    {
                        pers = a + "x² " + "- " + -c;
                    }
                    else if (c == 0)
                    {
                        pers = a + "x²";
                    }
                }
            }
            if (Rumus.Rumusabc(a, b, c) >= 0)
            {
                Console.WriteLine("Persamaan kuadrat yang Anda masukkan adalah : ");
                Console.WriteLine(pers);
                Console.WriteLine();
                Console.WriteLine("Dan penyelesaian dari persamaan tersebut adalah : ");
                Console.WriteLine("x1 = " + x1 + " dan " + "x2 = " + x2);
                Console.WriteLine();
                Console.Write("Ingin mengulang? (Y/N) ");
                ulang = Console.ReadLine();
                if (ulang == "Y" || ulang == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (ulang == "N" || ulang == "n")
                {
                    break;
                }
                else { Environment.Exit(0); }
            }
            else
            {
                Console.WriteLine("Persamaan kuadrat yang Anda masukkan adalah : ");
                Console.WriteLine(pers);
                Console.WriteLine();
                Console.WriteLine("Dan persamaan kuadrat tersebut tidak memiliki penyelesaian bilangan real");
                Console.WriteLine();
                Console.Write("Ingin mengulang (Y/N)? ");
                ulang = Console.ReadLine();
                if (ulang == "Y" || ulang == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (ulang == "N" || ulang == "n")
                {
                    break;
                }
                else { Environment.Exit(0); }
            }
        }

    }
}

class Rumus
{
    public static double Rumusabc(double a, double b, double c)
    {
        double D;
        D = (b * b) - (4 * a * c);
        return (D);
    }
}