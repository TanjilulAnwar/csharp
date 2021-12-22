using OXP.models.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.Other
{
    class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SessionName { get; set; }

        public int TotalHour { get; set; }

        public static int NumberOfTrainee { get; set; }


        //public static int showNumber()
        //{
        //    return Name;
        //}
        public static int showNumber()
        {
            Course course = new Course();
            course.Code = "d";
            return NumberOfTrainee;
        }

    }
}
