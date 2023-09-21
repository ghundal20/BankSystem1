using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public class WithdrawalException : Exception
    {
        public WithdrawalException() : base("Withdrawal failed due to insufficient funds.")
        {
        }

        public WithdrawalException(double withdrawalAmount, double balance)
            : base($"Withdrawal of ${withdrawalAmount} failed. Current balance: ${balance}")
        {
        }
    }
}