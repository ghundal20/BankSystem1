using BankSystem;
using System.Security.Policy;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EverydayAccountDeposite_Successful()
        {
            double openingBalance = 1000;
            double depositeAmount = 500;
            double expected = 1500;

            EverydayAccount a1 = new EverydayAccount(openingBalance);

            a1.Deposite(depositeAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "deposite successful");
            
        }
        [TestMethod]
        public void EverydayAccountWithdraw_Successful()
        {
            double openingBalance = 1000;
            double WithdrawAmount = 500;
            double expected = 500;

            EverydayAccount a1 = new EverydayAccount(openingBalance);

            a1.Withdraw(WithdrawAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "Withdraw successful");
        }
        [TestMethod]
        public void InvestmentDeposite_Successful()
        {
            double openingBalance = 1000;
            double DepositeAmount = 215.50;
            double expected = 1215.50;

            Investment a1 = new Investment(openingBalance);
            

            a1.Deposite(DepositeAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "Investment Account Deposite successful");
        }
        [TestMethod]
        public void InvestmentWithdraw_Successful()
        {
            double openingBalance = 1000;
            double WithdrawAmount = 115.75;
            double expected = 884.25;

            Investment a1 = new Investment(openingBalance);

            a1.Withdraw(WithdrawAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "Investment Account Withdraw successful");
        }
        [TestMethod]
        public void OmniDeposite_Successful()
        {
            double openingBalance = 1000;
            double DepositeAmount = 2000;
            double expected = 3000;

            Omni a1 = new Omni(openingBalance);

            a1.Deposite(DepositeAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "Omni Account Deposite successful");
        }

        [TestMethod]
        public void OmniWithdraw_Successful()
        {
            double openingBalance = 1000;
            double WithdrawAmount = 517;
            double expected = 483;

            Omni a1 = new Omni(openingBalance);

            a1.Withdraw(WithdrawAmount);

            double actual = a1.balance;
            Assert.AreEqual(expected, actual, "Omni Account Withdraw successful");
        }
        [TestMethod]
        public void EverydayAccount_Withdraw_OverdraftNotAllowed()
        {
            // Arrange
            double OpeningBalance = 1000;
            double WithdrawAmount = 2000;
            
            EverydayAccount a1 = new EverydayAccount(OpeningBalance);

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() => a1.Withdraw(WithdrawAmount));
        }

        [TestMethod]

        public void Investment_GetInfo_SuccessfulInfo()
        {
            // Arrange
            double openingBalance = 1000;
            Investment a1 = new Investment(openingBalance);

            // Act
            string info = a1.GetInfo();

            // Assert
            string expectedInfo = "Investment Account 66  has $1000; Interest Rate is 2%, No Overdraft, Fees $20 ";

            Assert.AreEqual(expectedInfo, info);
        }

        [TestMethod]
        public void Omni_Interest_SuccessfulAboveMinimum()
        {
            // Arrange
            double openingBalance = 1500; 
            double interestRate = 2.5; 
            Omni omniAccount = new Omni(openingBalance);

            // Act
            omniAccount.Interest(interestRate);

            // Assert
            
            double expectedBalance = openingBalance + (openingBalance * (interestRate / 100));
            Assert.AreEqual(expectedBalance, omniAccount.balance);
        }

        [TestMethod]
        public void Omni_Interest_UnSuccessBelowMinimum()
        {
            // Arrange
            double openingBalance = 500; 
            double interestRate = 2.5; 
            Omni omniAccount = new Omni(openingBalance);

            // Act
            omniAccount.Interest(interestRate);

            // Assert
            Assert.AreEqual(openingBalance, omniAccount.balance);
        }

    }
}