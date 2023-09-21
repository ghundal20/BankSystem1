using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystem
{
    internal class Controller
    {
        public List<Customer> AllCustomer = new List<Customer>();
        private int selectedCustomerIndex;

        public void AddCustomer(string name, int contact, bool isStaff)

        {
            AllCustomer.Add(new Customer(name, contact, isStaff));
        }

        public Customer GetCustomer(int customerIndex)
        {
            if (customerIndex >= 0 && customerIndex < AllCustomer.Count)
            {
                return AllCustomer[customerIndex];
            }
            else
            {
                return null;
            }
        }

        public void UpdateCustomer(string newName, int newContact, bool newStaff)
        {
            if (selectedCustomerIndex >= 0 && selectedCustomerIndex < AllCustomer.Count)
            {
                Customer customerToUpdate = AllCustomer[selectedCustomerIndex];
                customerToUpdate.Name = newName;
                customerToUpdate.Phone = newContact;
                customerToUpdate.IsStaff = newStaff;
            }
            else
            {
                MessageBox.Show("please select a valid index");


            }
        }

        public void DeleteCustomer(int selectedCustomerIndex)
        {
            if (selectedCustomerIndex >= 0 && selectedCustomerIndex < AllCustomer.Count)
            {
                AllCustomer.RemoveAt(selectedCustomerIndex);
            }
        }
    }
        
}
