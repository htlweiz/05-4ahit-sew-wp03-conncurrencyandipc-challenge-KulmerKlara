using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    
    public static void Main(string[] args)
    {
        Thread threadA = new Thread(CountUpThreadA);
        Thread threadB = new Thread(CountDownThreadB);

        threadA.Start();
        threadB.Start();

        threadA.Join();
        threadB.Join();

        Console.WriteLine(countA);
        if (countA == 50)
        {
            Console.WriteLine("Unentschieden!");
        }
        else if (countA < 50)
        {
            Console.WriteLine("Thread A gewinnt!");
        }
        else if (countA > 50)
        {
            Console.WriteLine("Thread B gewinnt!");
        }
    }
    
    private static void CountUpThreadA()
    {
        int miliseconds = 100;
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"Thread A: {i}");
            Thread.Sleep(miliseconds);
        }   
    }
    
    private static void CountDownThreadB()
    {
        int miliseconds = 100;
        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine($"Thread B: {i}");
            Thread.Sleep(miliseconds);
        }               
    }
}

 