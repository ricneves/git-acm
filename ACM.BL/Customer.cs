using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        //public string Log()
        //{
        //    var logString = CustomerId + ": " + FullName + " " + "Email: " + EmailAddress + " " + "Status: " + EntityState.ToString();
        //    return logString;
        //}
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;

        /*
        /// <summary>
        /// Save one customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrive one customer
        /// </summary>
        /// <returns></returns>
        public Customer Retrive(int customerId)
        {
            // cenas
            return new Customer();
        }
        */

        /// <summary>
        /// Retrive all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrive()
        {
            // code that retrieves all of the customers
            return new List<Customer>();
        }

        /// <summary>
        /// Validate the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
