using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Part2
{
    [DataContract]
    internal class PersonInput
    {
        // Declaring class variable to get the all the details from user
        [DataMember]
        public string First_Name { get; set; }
        [DataMember]
        public string Last_Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Zip { get; set; }
        [DataMember]
        public long PhoneNumber { get; set; }

        /// <summary>
        /// To string method to write details in Console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"First Name : {First_Name}\nLast Name : {Last_Name}\nAddress : {Address}\nCity : {City}\nState : {State}\nEmail : {Email}\nZip Code : {Zip}\nPhone Number : {PhoneNumber}";
        }
    }
}
