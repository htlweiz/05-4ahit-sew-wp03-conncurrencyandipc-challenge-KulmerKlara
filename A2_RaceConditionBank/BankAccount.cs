using System;
using System.Threading;

namespace A2_RaceConditionBank;

    public class BankAccount
    {
        private int balance;

        public BankAccount(int initial)
        {
            balance = initial;
        }

        public void Deposit(int amount)
        {
            int depositAmount = balance + amount;
            balance = depositAmount;
        }

        public void Withdraw(int amount)
        {
            int withdrawAmount = balance - amount;
            balance = withdrawAmount;
        }

        public int GetBalance()
        {
            return balance;
        }
}

