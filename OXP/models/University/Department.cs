using System.Collections.Generic;


namespace OXP.models.University
{
    class Department:IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        public Department(){
            
            Courses = new List<Course>();
            Students = new List<Student>();
       }

       

        public string GetBasicInformation()
        {
            return "Code: " + Code + " Name: " + Name + " Total students: " + Students.Count;
        }
    }
}
