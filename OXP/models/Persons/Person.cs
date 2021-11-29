using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public string Phone { get;  set; }
        public Address PresentAddress { get; set; }


        public Person()
        {
           


        }


        //public Person(string firstName, string lastName, string midName):this(firstName,lastName)
        //{
        //  //  FirstName = firstName;
        //  //   LastName = lastName;
        //    MidName = midName;

        //}

        //public Person(string firstName, string lastName):this()
        //{
        //    FirstName = firstName;
        //    LastName = lastName;


        //}

        public string getfullname()
        {
            return FirstName + " " + MidName + " " + LastName;
        }


        //public string FirstName
        //{
        //    set 
        //    { 
        //        if(value.Length >= 2)
        //        {
        //            firstName = value;
        //        }

        //    }
        //    get { return firstName; }
        //}


        //public void SetFirstName(string firstName)
        //{
        //    if (firstName.Length >= 2)
        //    {
        //        this.firstName = firstName;
        //    }
        //    else
        //    {
        //        throw new Exception("firstName must contain more than 1 character !");
        //    }
        //}


        //public string GetFirstName()
        //{

        //    return firstName;
        //}



    }
}
