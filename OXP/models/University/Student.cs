using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models.University
{
   public class Student:IInformation,IPrinter
    {

        public string RegNo { get; set; }

        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }

        public void GenerateExcel()
        {
            throw new NotImplementedException();
        }

        public void GeneratePdf()
        {
            throw new NotImplementedException();
        }

        public string GetBasicInformation()
        {
            return "Reg No: " + RegNo + " Name: " + Name + " Roll: " + Roll;
        }

        //Explicit implementation
        string IInformation.GetBasicInformation()
        {
            return "Info : Reg No: " + RegNo + " Name: " + Name + " Roll: " + Roll;
        }

         string IPrinter.GetBasicInformation()
        {
            return "Print: Reg No: " + RegNo + " Name: " + Name + " Roll: " + Roll;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIpAddress(string IpAddress)
        {
            throw new NotImplementedException();
        }
    }
}
