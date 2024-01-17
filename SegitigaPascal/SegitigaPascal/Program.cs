using System;
class Pascal
{
    static void Main()
    {
        fact factor = new fact();
        Console.Write("Masukkan banyak baris dari Segitiga Pascal yang kamu inginkan : ");
        int n = int.Parse(Console.ReadLine()) - 1;
        for (int i = 0; i <= n; i++)
        {
            int koef = 1;

            for (int k = n - i; k > 0; k--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i + 1; j++)
            {
                Console.Write(koef + " ");
                koef = factor.Rumus(i) / (factor.Rumus(i - j) * factor.Rumus(j));
            }
            Console.Write("\n");
        }
    }
}

public class fact
{

    public int Rumus(int factorial)
    {

        int result = 1;
        for (int i = factorial - 1; i > 0; i--)
        {
            result = factorial *= i;
        }
        return result;
    }

}