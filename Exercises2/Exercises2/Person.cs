using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    public class Person
    {        
        string firstName;
        string lastName;
        double payRate;
        int tax;
        string accountNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public double PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public Person (string _firstName, string _lastName, double _payRate, int _tax, string _accountNumber)
        {
            FirstName = _firstName;
            LastName = _lastName;
            PayRate = _payRate;
            Tax = _tax;
            AccountNumber = _accountNumber;
        }        
    }
}
    
