using System;
using System.Collections;
namespace GarbageCollection
{
    /// <summary>
///  Implementing IDisposable Interface
/// </summary>
    public class Program: IDisposable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program(); //Object is created
            obj.Dispose(); //Manually dispose method is called
            // Demonstration of using keyword
            using (Program obj1 = new Program())
            {

            }
            Console.WriteLine("before    {0:N0}", GC.GetTotalMemory(false)); //To get total memory before GC.Collect
            GC.Collect(0);
            Console.WriteLine("after      {0:N0}", GC.GetTotalMemory(true));//To get total memory after GC.Collect
            Program obj2 = new Program(); // Object is created and at last destructor is called
           
               
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        /// <summary>
        /// Parameterized dispose method
        /// </summary>
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Managed Objects are disposed
                    Console.WriteLine("Managed Resources are disposed here");
                }
                //Unmanaged Objects are disposed
                Console.WriteLine("UnManaged Resources are disposed here");
               

                disposedValue = true;
            }
        }

       /// <summary>
       /// Destructor
       /// </summary>
         ~Program()
         {
            Console.WriteLine("Finalize");
           Dispose(false);
         }

        // This code added to correctly implement the disposable pattern.
        /// <summary>
        /// Dispose method which is called manually or by using keyword
        /// </summary>
        public void Dispose()
        {
      
            Dispose(true);
             GC.SuppressFinalize(this); // To supress finalize
        }
        #endregion
    }
}
