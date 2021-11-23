using OXP.models;
using System;
using System.Collections.Generic;

namespace OXP
{
    class Program
    {
        static void Main(string[] args)
        {

            /*************************Association***********************************/

            ///one to many/////////////////////////////////////////////////////////////////////////

            Course course1 = new Course() { Code = "CSE-101", Title = "Algorithm", Credit = 3.0 };
            Course course2 = new Course() { Code = "CSE-102", Title = "DS", Credit = 2.0 };
            Course course3 = new Course() { Code = "CSE-121", Title = "DLD", Credit = 3.0 };

            //List<Course> courses = new List<Course>();
            //courses.Add(course1);
            //courses.Add(course2);
            //courses.Add(course3);




            Department department = new Department();
            department.Code = "01";
            department.Name= "CSE";
            // department.Courses = courses;
            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);


            foreach(Course course in department.Courses)
            {
                Console.WriteLine(course.GetInfo());
            }

            Console.ReadKey();

            ///one to one////////////////////////////////////////////////////////////////////////
            //Address address = new Address();
            //address.RoadNo = "102";
            //address.HouseNo = "H-121";
            //address.AreaNo = "125";
            //address.District = "Dhaka";


            //Person person1 = new Person();
            //person1.PresentAddress = address;
            //Console.WriteLine(person1.PresentAddress.HouseNo);

            /*************************Association***********************************/


            /*************************Constructor***********************************/

            //Person person1 = new Person("Sir","Isaac","Newton");
            //Person person2 = new Person("Sam","Saleh");
            //string fullName = person1.getfullname();
            //string fullName2 = person2.getfullname();
            //Console.WriteLine(fullName);
            //Console.WriteLine(fullName2);




            /*************************Constructor***********************************/








            /*************************Data Hiding***********************************/


            //string firstName = Console.ReadLine();
            //Person person1 = new Person();

            //person1.FirstName = firstName;
            //string fName = person1.FirstName;
            //Console.WriteLine(fName);

            //person1.SetFirstName("Habib");

            //Console.WriteLine(person1.GetFirstName());


            /*********Auto property***************/


            //person1.Phone = "0155575757"; // error if private set;
            //string phone = person1.Phone;






            /*************************Data Hiding***********************************/








            /*************************Reference Type***********************************/
            //Person person1 = new Person()
            //{
            //    firstName = "Mr",
            //    midName = "Johann",
            //    lastName ="Straus"

            //};
            //Person person2 = new Person()
            //{
            //    firstName = "Ms.",
            //    midName = "Selina",
            //    lastName = "Raskovitch"

            //};
            //Person person3;
            //person3 = new Person();
            //person3 = person1;
            //person1.lastName = "kyle";
            //person1 = person2;
            //person1.lastName = "Milton";
            //person2 = person3;

            //Console.WriteLine(person1.GetFullName());//prints "firstName midName lastName"
            //Console.WriteLine(person2.GetFullName());
            //Console.WriteLine(person3.GetFullName());
            /*************************Reference Type***********************************/
        }
    } 
}
