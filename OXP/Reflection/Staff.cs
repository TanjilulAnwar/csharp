using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.Reflection
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string PassKey { get; set; }
        public string GetAddress()
        {
            return "Reg No: " + Address  ;
        }
        public string GetName()
        {
            return " Name: " + Name ;
        }
      


    }
}
