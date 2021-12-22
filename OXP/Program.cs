using OXP.models;
using OXP.models.shapes;
using OXP.models.University;
using OXP.Other;
using OXP.Other.Delegates;
using OXP.Other.Generics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace OXP
{
    class Program
    {

       public static void Print(dynamic first, dynamic second)
        {
            Console.WriteLine(first + second);
        }
        public static void PrintGeneric<T,U>(Trainee<T,U> trainee)
        {
            Console.WriteLine(trainee.Name +" : "+trainee.success + " which means " +trainee.status);
        }
        static int Add(int firstNum , int secondNum)
        {
            return firstNum + secondNum;
        }
        static int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        static int Mul(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        public static void InvokeDelegate(CalculatorHandler calculatorHandler, int fNum,int sNum)
        {
          int result = calculatorHandler.Invoke(fNum,sNum);
            Console.WriteLine(result);
        }
        public delegate int CalculatorHandler(int fNum, int sNum);
        //public delegate void PrintHandler(string info);
        public delegate void PrintHandler<T,F>(T param,F param2);
        public delegate T PrintHandlerX<T, F>(T param, F param2);
        static void Hello(string fName, string lName)
        {
            Console.WriteLine("Hello " + fName +" "+lName);
        }

        static string HelloX(string fName, string lName)
        {
            return "Hello " + fName + " " + lName;
        }

        static void GoodBye(string fName, string lName)
        {
            Console.WriteLine("GoodBye " + fName + " " + lName);
        }

        static void WriteNumber(int num1, int num2)
        {
            int r = num1 + num2;
            Console.WriteLine("Sum is " + r);
        }
        static void Main(string[] args)
        {



            /*************************Generic Delegate***********************************/
            PrintHandler<string,string> printHandler = Hello;
            printHandler += GoodBye;
            printHandler("Rasul", "Kabir");
            PrintHandlerX<string, string> printHandlerX = HelloX;
          //  printHandlerX += GoodBye;
           Console.WriteLine( printHandlerX("Samsul", "Kabir"));
            PrintHandler<int,int> printHandler1 = WriteNumber;
            printHandler1(5,4);
            /*************************Generic Delegate***********************************/

            /*************************Multicast Delegate***********************************/
            //PrintHandler printHandler = Hello;
            //PrintHandler printHandler1 = GoodBye;
            //PrintHandler printHandler2 = printHandler+printHandler1;
            //printHandler2("Saju");
            //printHandler("Babul");
            //printHandler += GoodBye;
            //printHandler("Babul");
            //printHandler -= Hello;
            //printHandler("Babul");
            /*************************Multicast Delegate***********************************/
            /*************************Anonymous Type Method***********************************/
            //CalculatorHandler calculatorHandler = delegate(int fNum, int sNum) 
            //{
            //    return fNum + sNum;

            //};

            //InvokeDelegate(calculatorHandler, 45, 3);

            //CalculatorHandler calculatorHandler2 =  (int fNum, int sNum)=> fNum + sNum;

            //InvokeDelegate(calculatorHandler2, 45,66);




            //CalculatorHandler calculatorHandler3 = (fNum, sNum) => fNum + sNum;

            //InvokeDelegate(calculatorHandler3, 45, 66);

            //CalculatorHandler calculatorHandler4 = (fNum, sNum) => { return fNum + sNum; };

            //InvokeDelegate(calculatorHandler4, 45, 66);

            //CalculatorHandler calculatorHandler5 = (x, y) =>  x + y; 

            //InvokeDelegate(calculatorHandler5, 45, 66);

            /*************************Anonymous Type Method***********************************/






            /*************************Delegates***********************************/

            //Crate container = new Crate();
            //CalculatorHandler calculatorHandler = Add;

            //InvokeDelegate(calculatorHandler,45,12);


            //CalculatorHandler calculatorHandler2 = Sub;

            //InvokeDelegate(calculatorHandler2, 45, 12);

            //CalculatorHandler calculatorHandler3 = Mul;

            //InvokeDelegate(calculatorHandler3, 45, 12);


            //CalculatorHandler calculatorHandler2 = new CalculatorHandler(Add);

            //int a = calculatorHandler.Invoke(12, 45);
            //int b = calculatorHandler2(56, 45);
            //Console.WriteLine(a);
            //Console.WriteLine(b);





            /*************************Delegates***********************************/


            /*************************Generics***********************************/

            //Trainee<int,string> t1 = new Trainee<int,string>()
            //{
            //    Name = "Rasel",
            //    success = 1,
            //    status ="Valid"
            //};

            //Trainee<bool,int> t2 = new Trainee<bool,int>()
            //{
            //    Name = "Forhad",
            //    success = false,
            //    status = 0
            //};

            //Trainee<string,bool> t3 = new Trainee<string,bool>()
            //{
            //    Name = "Forhad",
            //    success = "Pass",
            //    status = false
            //};
            //PrintGeneric(t1);
            //PrintGeneric(t2);
            //PrintGeneric(t3);


            /*************************Generics***********************************/




            /*************************Static***********************************/



            //   Training.NumberOfTrainee = 30;
            //   Training tr1 = new Training();
            //   tr1.Id = 0;
            //   tr1.Name = "3503";
            //   tr1.SessionName = "Python";
            //   tr1.TotalHour = 72;
            //  // tr1.NumberOfTrainee = 30;


            //   Training tr2 = new Training();
            //   tr2.Id = 1;
            //   tr2.Name = "3506";
            //   tr2.SessionName = "JAVA";
            //   tr2.TotalHour = 89;
            //   //  tr2.NumberOfTrainee = 30;


            ////   Console.WriteLine(tr2.NumberOfTrainee);








            /*************************Static***********************************/
            /*************************Enum***********************************/


            //Console.WriteLine((int)OrderStatus.OrderPlace);
            //Console.WriteLine((int)OrderStatus.OrderConfirm);
            //Console.WriteLine((int)OrderStatus.Packaging);
            //Console.WriteLine((int)OrderStatus.Delivering);
            //Console.WriteLine((int)OrderStatus.Recieved);


            //int ProductOrderStatus = 1;

            //if(ProductOrderStatus == (int)OrderStatus.OrderPlace)
            //{

            //}
            //else if (ProductOrderStatus == (int)OrderStatus.Packaging)
            //{

            //}



            /*************************Enum***********************************/
            /*************************anonymous type obj/array***********************************/

            //    var student = new { Id = 0, Name = "Dipto", Roll = "12", Address = "Dhaka" };
            //    Console.WriteLine(student);

            //    var Person = new[] {
            //     new { Id = 1, Name = "Jhinuk", Roll = "12", Address = "Dhaka" },
            //      new { Id = 2, Name = "Hanuk", Roll = "34", Address = "Tika" },
            //        new { Id = 3, Name = "Grnuk", Roll = "34", Address = "Tika" },
            //};

            //    var PersonList = Person.Where(u => u.Name.StartsWith("H")).ToList();
            //    foreach (var p in Person)
            //    Console.WriteLine(p);
            /*************************anonymous type***********************************/

            /*************************Extensible dynamic***********************************/
            //dynamic obj = new ExpandoObject();
            //  Console.WriteLine(obj.GetType());


            //obj.Name = "Sukesh";
            //obj.Age = 25;
            //obj.Phone = "53453454";
            //obj.IsStudent = false;

            //Console.WriteLine(obj.Name +" " + obj.Phone);
            ////Console.WriteLine(obj.Name +" " + obj.Dob+ " "+ obj.Phone);//will throw error cause Dob is not declared



            /*************************Extensibl dynamic***********************************/

            /*************************dynamic***********************************/

            //   dynamic msg = 1;
            //   Console.WriteLine(msg.GetType());
            //   msg = "new";
            //   Console.WriteLine(msg.GetType());
            //   msg = true;
            //   Console.WriteLine(msg.GetType());
            //   msg = 4.4343;
            //   Console.WriteLine(msg.GetType());
            //   msg = new Student();
            //   msg.Name = "Dipto";

            ////   msg.Phone = "00435345";//will throw error in run time
            //   Console.WriteLine(msg.GetType());
            //   Console.WriteLine(msg.GetBasicInformation());

            //   Print(300, "12");




            /*************************dynamic***********************************/
            /*************************var***********************************/

            //var i = 100;
            //// var j;
            ////i = "j";
            //i = 333;

            //List<StudentInfo> studentInfos2 = new List<StudentInfo>()
            //    {
            //        new StudentInfo() {Id =1,Name = "Noman",Age = 34,Address = "Dhaka"},
            //    new StudentInfo() { Id = 2, Name = "Absar", Age = 18, Address = "Barishal" },
            //    new StudentInfo() { Id = 3, Name = "Shaon", Age = 24, Address = "Feni" },
            //    new StudentInfo() { Id = 4, Name = "Ikbal", Age = 34, Address = "Noakhali" },
            //    new StudentInfo() { Id = 5, Name = "Sunny", Age = 15, Address = "Savar" } };

            //    foreach(var stud in studentInfos2)// in case of parent/child   runtime polymorphism
            //{

            //}

            /*************************var***********************************/

            /*************************Object/Collection Initializer syntax***********************************/

            //    StudentInfo studentInfo1 = new StudentInfo() {Id =1,Name = "Noman",Age = 34,Address = "Dhaka"};
            //    StudentInfo studentInfo2 = new StudentInfo() { Id = 2, Name = "Absar", Age = 18, Address = "Barishal" };
            //    StudentInfo studentInfo3 = new StudentInfo() { Id = 3, Name = "Shaon", Age = 24, Address = "Feni" };
            //    StudentInfo studentInfo4 = new StudentInfo() { Id = 4, Name = "Ikbal", Age = 34, Address = "Noakhali" };
            //    StudentInfo studentInfo5 = new StudentInfo() { Id = 5, Name = "Sunny", Age = 15, Address = "Savar" };


            //    List<StudentInfo> studentInfos = new List<StudentInfo>()
            //    {

            //        studentInfo1,
            //        studentInfo2,
            //        studentInfo3,
            //        studentInfo4,
            //        studentInfo5

            //    };

            //    List<StudentInfo> studentInfos2 = new List<StudentInfo>()
            //    {
            //        new StudentInfo() {Id =1,Name = "Noman",Age = 34,Address = "Dhaka"},
            //    new StudentInfo() { Id = 2, Name = "Absar", Age = 18, Address = "Barishal" },
            //    new StudentInfo() { Id = 3, Name = "Shaon", Age = 24, Address = "Feni" },
            //    new StudentInfo() { Id = 4, Name = "Ikbal", Age = 34, Address = "Noakhali" },
            //    new StudentInfo() { Id = 5, Name = "Sunny", Age = 15, Address = "Savar" },

            //};

            /*************************Object Initializer syntax***********************************/

            /*************************Interface***********************************/

            //Student student = new Student() {
            //RegNo= "5434534",
            //Name ="Habib",
            //Roll = "545",
            //Email = "f@mail.com"

            //};
            //Course course = new Course()
            //{
            //    Title = "Algorithm",
            //    Code = "CSE101",
            //    Credit = 3

            //};
            ////  string info = student.GetBasicInformation();
            //IInformation info1 = student;
            //info1.GetBasicInformation();// calls string IInformation.GetBasicInformation()


            //IPrinter info2 = student;
            //info2.GetBasicInformation();// calls  string IPrinter.GetBasicInformation()


            //Department department = new Department()
            //{
            //    Code = "CSE",
            //    Name = "Computer Science"

            //};
            //department.Students.Add(student);
            //department.Students.Add(student);
            //department.Courses.Add(course);

            //IInformation information = department;
            //information = course;
            //information = student;



            //Console.WriteLine("Area of Cylinder = {0}", department.GetBasicInformation());


            //List<IInformation> informationList = new List<IInformation>();

            ////Runtime Polymorphism
            //informationList.Add(department);
            //informationList.Add(course);
            //informationList.Add(student);




            //Console.WriteLine("Info = {0}", department.GetBasicInformation());


            /*************************Interface***********************************/

            /*************************Method Overriding***********************************/

            //double r = 3.0, h = 5.0;
            //Shape c = new Circle(r);
            //Shape s = new Sphere(r);
            //Shape l = new Cylinder(r, h);
            //// Display results.
            //Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            //Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            //Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            /*************************Method Overriding***********************************/
            /*************************Casting****************************/

            // SavingAccount sa = new SavingAccount()
            // {
            //     AccountNo = "72137172561427156",
            //     CustomerName = "Charles Weakly",
            //     InterestAmount = 5
            // };

            // sa.Deposit(2000);
            // sa.Withdraw(500);

            // CheckingAccount ca = new CheckingAccount()
            // {
            //     AccountNo = "56137172561427300",
            //     CustomerName = "Staly Baroque",
            //     ServiceCharge = 25
            // };

            // ca.Deposit(5000);
            // ca.Withdraw(300);


            // BankAccount ba1 = new SavingAccount();//Upcasting
            // BankAccount ba2 = ca;//Upcasting

            // SavingAccount sa2 = (SavingAccount)ba1;//downcasting

            //Console.WriteLine(sa.Balance);
            // Console.WriteLine(ca.Balance);


            /*************************Casting***********************************/

            /*************************Inheritance***********************************/


            // SavingAccount sa = new SavingAccount()
            // {
            //     AccountNo = "72137172561427156",
            //     CustomerName = "Charles Weakly",
            //     InterestAmount = 5
            // };

            // sa.Deposit(2000);
            // sa.Withdraw(500);

            // CheckingAccount ca = new CheckingAccount()
            // {
            //     AccountNo = "56137172561427300",
            //     CustomerName = "Staly Baroque",
            //     ServiceCharge = 25
            // };

            // ca.Deposit(5000);
            //ca.Withdraw(300);


            // Console.WriteLine(sa.Balance);
            // Console.WriteLine(ca.Balance);









            /*************************Inheritance***********************************/











            /*************************Association***********************************/

            ///one to many/////////////////////////////////////////////////////////////////////////

            //Course course1 = new Course() { Code = "CSE-101", Title = "Algorithm", Credit = 3.0 };
            //Course course2 = new Course() { Code = "CSE-102", Title = "DS", Credit = 2.0 };
            //Course course3 = new Course() { Code = "CSE-121", Title = "DLD", Credit = 3.0 };

            //List<Course> courses = new List<Course>();
            //courses.Add(course1);
            //courses.Add(course2);
            //courses.Add(course3);




            //Department department = new Department();
            //department.Code = "01";
            //department.Name= "CSE";
            //// department.Courses = courses;
            //department.Courses.Add(course1);
            //department.Courses.Add(course2);
            //department.Courses.Add(course3);


            //foreach(Course course in department.Courses)
            //{
            //    Console.WriteLine(course.GetInfo());
            //}

            //Console.ReadKey();

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
