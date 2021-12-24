using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.Extension
{
   static class Extension
    {
        public static string GetInfo(this Worker worker) 
        {

            return "Id: " + worker.Id + " Name: " + worker.Name + " Address: " + worker.Address;

        }


        public static string GetInfo(this Schedule schedule)
        {

            return "Id: " + schedule.Id + " Title: " + schedule.Title + " Slot: " + schedule.Slot;

        }


        public static void ShowLength(this string str)
        {

            Console.WriteLine("The string has "+str.Length+" character" ) ;

        }
    }
}
