using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models.University
{
    class Course:IInformation
    {
        public  string Code { get; set; }
        public string Title { get; set; }
        public double  Credit { get; set; }

        public string GetBasicInformation()
        {
            return "Code : "+Code + " Title: " + Title + " Credit: " + Credit;
        }

    
        public double GetResult(double mid, double final)
        {

            Calculator calculator = new Calculator();//USES Relationship
            double result = calculator.Add(mid,final);
            return result;

        }
    }
}
