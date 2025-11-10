using System;
using System.Threading;

namespace A2_RaceConditionBank;
class Program
{
        public static void Main(string[] args)
        {
            Console.WriteLine("Übung 2: Race Condition – Bankkonto");
            Console.WriteLine("==========================================\n");
            
            // Startwert
            BankAccount account = new BankAccount(1000);
            Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");

            Thread[] threads = new Thread[10];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => PerformBankOperations(account));
                threads[i].Start();
            }

            foreach (Thread t in threads)
                t.Join();

            Console.WriteLine($"\nEndkontostand: {account.GetBalance()} EUR");
        }
        
        private static void PerformBankOperations(BankAccount account)
        {
            for (int i = 0; i < 10; i++)
            {
                account.Withdraw(100);  
                account.Deposit(150);   
            }
        }
    }

