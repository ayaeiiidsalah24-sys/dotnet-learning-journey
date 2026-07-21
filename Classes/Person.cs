using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{


    
    internal class Person
    { 
        //variables
       string firstName;
        string lastName;
        DateOnly dateOfBirth;
        string country;
          public string moblieNumber;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }  
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public DateOnly DateOfBirth  { get; set; }
        public string Country { get; set; }




    }
}
