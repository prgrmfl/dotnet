using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Lesson3.Generics
{
    // Create a class that can print the concatenated ToString() value of two generic variables
    public class Exercise1
    {
        //public T1 First { get; set; }
        //public T2 Second { get; set; }

        // constructor:
        //public Exercise1(T1 val1, T2 val2)
        //{
        //    First = val1;
        //    Second = val2;
        //}

        public void Print<T1, T2>(T1 value1, T2 value2)
        {

            var value = value1.ToString() + value2.ToString();
            Console.WriteLine(value);
        }
    }
}
