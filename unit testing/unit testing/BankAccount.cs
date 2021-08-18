using System;
using System.Collections.Generic;
using System.Text;

namespace unit_testing
{
    public class BankAccount
    {
        string _customerName;
        double _balanace;

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balanace = balance;
        }

        public double balance { get { return _balanace; } }

        public void debit(double amount)
        {
            if (balance == 0)
            {
                throw new Exception("balance = 0");
            }
            if (amount <= 0 || amount > _balanace)
            
                throw new ArgumentOutOfRangeException("amount <=0 or amount > balance");
                _balanace -= amount;
            

        }
        public void credit(double amount)
        {
            if (amount <= 0)
            
                throw new ArgumentOutOfRangeException(" amount <= 0");
                _balanace += amount;
            
        }
    }
}
