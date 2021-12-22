using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.models.University
{
    interface IPrinter
    {
        void SetIpAddress(string IpAddress);
        void Print();
        void GeneratePdf();
        void GenerateExcel();
        string GetBasicInformation();
    }
}
