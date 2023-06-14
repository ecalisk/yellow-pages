using System;
using System.Collections.Generic;
using System.Text;

namespace yellow_pages
{
    public class contact
    {
        //CONSTRUCTOR
        public contact(string firstName, string middleName, string lastName, int phoneNumber, string address, string gender, string photoLocation)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.gender = gender;
            this.photoLocation = photoLocation;
        }

        //PROPERTIES
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string photoLocation { get; set; }
    }
}
