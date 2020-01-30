using System;
using System.Collections.Generic;

namespace EnumeratorEnumerationExample
{
    /// <summary>
    /// An example Enumerator and enumeration
    /// </summary>
    class EnumeratorEnumerationExampleClass
    {
        static void Main(string[] args)
        {
            List<String> day = new List<String>();
            
            day.Add("Monday");
            day.Add("Tuesday");
            day.Add("Wednesday");
            day.Add("Thursday");
            day.Add("Friday");
            day.Add("Saturday");
            day.Add("Sunday");
            IEnumerator<string> ienumerator = day.GetEnumerator();
            IEnumeratormethod(ienumerator);
            
            IEnumerable<string> iEnumerableObj = (IEnumerable<string>)day;
            //foreach loop
            foreach (string i in iEnumerableObj)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Method illustrating Ienumerator
        /// </summary>
     
        static void IEnumeratormethod(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
                if (i.Current == "Friday")
                {
                    Console.WriteLine("Hey it's a weekend");
                    iEnumeratorMethodTwo(i);
                }
            }
        }
        /// <summary>
        /// Method illustrating Ienumerator
        /// </summary>
        static void iEnumeratorMethodTwo(IEnumerator<string> i)
        {
           
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
                Console.WriteLine("Holidays");
            }
        }
    }
}
