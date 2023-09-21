using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {

        private static int currentID = 60;
        public int Id { get; private set; }

        public string AccountType { get; set; }


        public double balance;

        public override string ToString()
        {
            return AccountType;
        }

        public Account(double accountBalance)
        {
            Id = ++currentID;
            balance = accountBalance;

        }
        //deposite method 
        public virtual void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }

        //withdraw method
        public virtual void Withdraw(double withdrawAmount)
        {

        }

        public virtual void Interest(double interestRate)
        {

        }

        public virtual string GetInfo()
        {
            return $"{AccountType}  ${balance}";
        }
    }


    public class EverydayAccount : Account
    {
        public EverydayAccount(double accountBalance) : base(accountBalance)
        {
            AccountType = "Everyday Account";
            balance = accountBalance;

        }

        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;
        }

        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                if (balance <= withdrawAmount)
                {
                    throw new InvalidOperationException("No Overdraft allowed!!");
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public override string GetInfo()
        {

            return $"{AccountType} {Id}  has ${balance}; No Interest, No Overdraft, No Fees  ";
        }
    }
    public class Investment : Account
    {
        public double interest = 0.02;
        public double fee = 20;

        public Investment(double accountBalance) : base(accountBalance)
        {
            AccountType = "Investment Account";
            balance = accountBalance;

        }

        public override void Interest(double interestRate)
        {
            double interestAmount = balance * (interestRate / 100);
            balance += interestAmount;

        }

        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }
        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                if (balance <= withdrawAmount)
                {
                    throw new WithdrawalException(withdrawAmount, balance);
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (WithdrawalException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        public override string GetInfo()
        {
            return $"{AccountType} {Id}  has ${balance}; Interest Rate is 2%, No Overdraft, Fees $20 ";

        }

    }


    public class Omni : Account
    {

        public double minimumBalance = 1000;
        public double limit = -200;
        public double fee = 2.5;
        public Omni(double accountBalance) : base(accountBalance)
        {
            AccountType = "Omni Account";
            balance = accountBalance;

        }

        public override void Interest(double interestRate)
        {
            if (balance > minimumBalance)
            {
                double interestAmount = balance * (interestRate / 100);
                balance += interestAmount;
            }
        }
        public override void Deposite(double depositeAmount)
        {
            balance += depositeAmount;

        }
        public override void Withdraw(double withdrawAmount)
        {
            try
            {
                if (withdrawAmount >= limit + balance)
                {
                    throw new WithdrawalException(withdrawAmount, balance);
                }
                else
                {
                    balance -= withdrawAmount;
                }
            }
            catch (WithdrawalException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public override string GetInfo()
        {
            return $"{AccountType} {Id}  has ${balance}; Interest Rate is 2.5%, Overdraft limit $200, Fees $20 ";

        }

    }
}

