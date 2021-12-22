using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXP.Other.Generics
{
    public class Trainee<T,U>
    {
        public string Name { get; set; }
        public T success { get; set; }
        public U status { get; set; }

    }
}
