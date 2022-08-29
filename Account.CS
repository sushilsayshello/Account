using System;

namespace Account
{
    public class Account
    {
        private decimal balance;
        
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        
        public void Credit(decimal amount)
        {
            Balance = Balance + amount;
        }
        
        public decimal Balance
        {
            get
            {
                return balance;
            }

        }
    }
}
