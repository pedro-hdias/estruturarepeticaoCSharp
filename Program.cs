using System;

public class Program
{
    public static void Main(string[] args)
    {
        for (int j = 0; j <= 10; j++)
            Console.WriteLine(j);

        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine("Agora o Do While");
        i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);
    }
}