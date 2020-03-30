using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrive one Address
        /// </summary>
        /// <returns></returns>
        public Address Retrive(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Frodo street";
                address.StreetLine2 = "str";
                address.City = "Porto";
                address.State = "Porto";
                address.Country = "Portugal";
                address.PostalCode = "4000-001";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "StreetLine 2",
                City = "Porto",
                State = "Shire",
                Country = "Portugal",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "StreetLine 1",
                StreetLine2 = "StreetLine 2",
                City = "Porto",
                State = "Shire",
                Country = "Portugal",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current Address
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // code that saves the passed in address

            return true;
        }
    }
}
