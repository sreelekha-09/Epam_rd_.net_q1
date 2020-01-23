using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorprogram
{
    /// <summary>
    /// This class performs calculator operations
    /// </summary>
    /// <remarks>
    /// This class performs addition, subtraction, multiplication, division
    /// </remarks>
    public class Calculatorclass
    {
        /// <summary>
        /// This method performs addition operation
        /// </summary>
        /// <param name="operand 1">this is operand 1</param>
        /// <param name="operand 2">this is operand 2</param>
        /// <returns>it returns the addition of two numbers</returns>
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

            return operand1 - operand2;
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

        public int Divide(int operand1, int operand2)
        {

            if (operand2 == 0)
            {
                throw new ArithmeticException("Arithmetic exception");
            }
            return operand1 / operand2;

        }
    }
}
