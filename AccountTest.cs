using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class AccountTest
    {
        public static void Main(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);
            
            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);
            
            decimal depositAmount;
            
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());



        }
    }
}
