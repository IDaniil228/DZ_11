using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DZ_11
{
    public enum Account { Текущий, Сберегательный }
    internal class BankAccount
    {
        private static int numbOfAccount = 0;
        private double balance;
        private Account accountType;
        private string owner;
        private Queue<BankTransaction> typeOfBankTransaction = new Queue<BankTransaction>();
        private BankTransaction[] transactions = new BankTransaction[999];

        internal BankAccount(double balance, Account type)
        {
            numbOfAccount++;
            accountType = type;
            this.balance = balance;
        }

        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }
        /// <summary>
        /// возвращает номер счета 
        /// </summary>
        /// <returns></returns>
        public int Number
        {
            get { return numbOfAccount; }
        }
        /// <summary>
        /// возвращает тип счета
        /// </summary>
        /// <returns></returns>
        public Account GetAccountType
        {
            get { return accountType; }
        }
        public static bool operator ==(BankAccount a, BankAccount b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Выводит информацию о счете!
        /// </summary>
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер - {numbOfAccount}, баланс - {balance}, тип - {accountType}, владелец - {owner}");
        }
        /// <summary>
        /// Сравнивает счета
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is BankAccount account)
            {
                return numbOfAccount == account.Number;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return numbOfAccount.GetHashCode();
        }
        /// <summary>
        /// Выводит информацию о счете
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Номер счета - {Number}, баланс - {Balance}, тип счета - {GetAccountType}";
        }
        /// <summary>
        /// Положить деньги на баланс
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public double AddBalince(double balance)
        {
            BankTransaction transaction = new BankTransaction(balance);
            typeOfBankTransaction.Enqueue(transaction);
            transactions.Append(transaction);
            this.balance += balance;
            return balance;
        }
        /// <summary>
        /// Снять средства с баланса
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public double WithdrawFromBalance(double balance)
        {
            if (balance <= this.balance)
            {
                BankTransaction transaction = new BankTransaction(balance);
                typeOfBankTransaction.Enqueue(transaction);
                this.balance -= balance;
                return this.balance;
            }
            Console.WriteLine("Невозможно снять такую сумму");
            return this.balance;
        }
        public void Transfer(BankAccount account, double amount)
        {
            if (account != null && account.Balance > 0 && amount <= account.Balance)
            {
                account.balance -= amount;
                balance += amount;
            }
            else
            {
                Console.WriteLine("Невозможно снять деньги с этого счета");
            }
        }
        /// <summary>
        /// данные о переводах из очереди запишет в файл
        /// </summary>
        public void Dispose()
        {
            foreach (BankTransaction bt in typeOfBankTransaction)
            {
                string date = bt.Date.ToString();
                string amount = bt.Amount.ToString();
                using (var writer = new StreamWriter("Переводы.txt", true))
                {
                    writer.Write(amount + ' ');
                    writer.Write(date);
                    writer.WriteLine();
                }
                GC.SuppressFinalize(bt);
            }

        }
    }
}
