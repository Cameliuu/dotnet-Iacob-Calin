using System;
using System.Collections.Generic;
using System.Text;

namespace Iacob_Calin
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string fullname;
        private int age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return LastName + " " + FirstName ; }
        }
        public int Age { get; set; }
    }
}
