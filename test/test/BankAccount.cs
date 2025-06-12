using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class BankAccount
    {
        private int id;
        private double balance;

        public int ID { get; set; }
        private double Balance { get; set; }

        public BankAccount()
        {
            this.id = ID;
            this.balance = Balance;
            Deposit(Balance);
            Withdraw(Balance);      
        }
        public string ToString()
        {
            
          return $"Balance: {Balance.ToString()}";

        }   
       public  void Deposit(double amount)
       {
            Balance = Balance + amount;
           
       }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
           
        }
    }
}
