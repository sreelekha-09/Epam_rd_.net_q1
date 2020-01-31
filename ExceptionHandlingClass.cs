using System;

namespace ExceptionHandlingExample
{/// <summary>
/// Tom implement an example on exception handling
/// </summary>
    class ExceptionHandlingClass
    {
        
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        /// <summary>

        /// This method performs subtraction operation

        /// </summary>

        /// <param name="operand 1">this is operand 1</param>

        /// <param name="operand 2">this is operand 2</param>

        /// <returns> it returns the difference of two numbers</returns>
        public int Subtract(int operand1, int operand2)
        {
            int result = 0;
            try
            {
                if (operand1 < 0 || operand2 < 0)
                {
                    throw (new CustomException("Cannot have negative numbers"));
                }
                result=operand1 - operand2;
            }
            catch(CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        /// <summary>

        /// This method performs multiplication operation

        /// </summary>

        /// <param name="operand 1">this is operand 1</param>

        /// <param name="operand 2">this is operand 2</param>

        /// <returns>it returns the product of two numbers</returns>
        public int Multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
        /// <summary>

        /// This method performs division operation

        /// </summary>

        /// <param name="operand 1">this is operand 1</param>

        /// <param name="operand 2">this is operand 2</param>

        /// <returns>it returns the division of two numbers</returns>
        public int Division(int operand1, int operand2)
        {
            int result=0;
            try
            {
                result= operand1 / operand2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            return result;
        }

        static void Main(string[] args)
        {
            ExceptionHandlingClass obj = new ExceptionHandlingClass();
            Console.WriteLine(obj.Division(3, 0));
            Console.WriteLine(obj.Subtract(-1, 2));
        }
    }
    /// <summary>
    /// To implement Custom Exception
    /// </summary>
    public class CustomException: ApplicationException
    {
        public CustomException() : base()
        {
        }
        public CustomException(String message) : base(message)
        {

        }
    }
}
