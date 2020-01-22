using System;

namespace Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            factorial obj = new factorial();
            Console.WriteLine(obj.fact(5));
        }
    }/// <summary>
    /// This class contains a method to find factorial.
    /// </summary>
    /// <remarks>this class is used to find factorial of a number</remarks>
    /// <example><code> 
    /// int f=1;
    /// int i;
    /// for(i=1;i<=5;i++)
     ///       {
     ///           f = f* i;
  ///            }
/// </code></example>
class factorial
    {
        int f = 1;
        int i;
        /// <summary>
        /// This method is to find factorial of a number
        /// </summary>
        /// <param name="a">It takes integer as a parameter
        /// </param>
        /// <returns> It returns factorial of a number
        ///</returns>
        public int fact(int a)
        {
            for(i=1;i<=a;i++)
            {
                f = f * i;
            }
            ///<value> f has the value of factorial</value>
            return f;
        }
    }
}
