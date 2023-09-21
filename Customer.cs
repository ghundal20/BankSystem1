using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Customer
    {
        private static int CustomerNumber = 2000;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public bool IsStaff { get; set; }


        //constructor
        public Customer(string name, int contact, bool isStaff)
        {
            Id = ++CustomerNumber;
            Name = name;
            Phone = contact;
            IsStaff = isStaff;
            
        }

        public double CalculateFee(double fee)
        {
            if ( IsStaff == IsStaff)
            {
                return fee * 0.5;
            }
            else
            {
                return fee;
            }
        }

    }
}
