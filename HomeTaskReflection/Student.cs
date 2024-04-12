using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskReflection
{
    internal class Student
    {
        public  byte  Age { get; set; }
        public static byte Count { get; set; }

        public Student()
        {
            Count++;
            Age=Count;
        }
    }
}
