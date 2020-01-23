using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_d
{
    public class calcu_d
    {
        public int add(int operand_1, int operand_2)
        {
            return operand_1 + operand_2;
        }



        public int subtract(int operand_1, int operand_2)
        {

            return operand_1 - operand_2;
        }



        public int multiply(int operand_1, int operand_2)
        {

       return operand_1 * operand_2;

        }



        public int divide(int operand_1, int operand_2)
        {

            if (operand_2 == 0)
            {
                throw new ArithmeticException("00000");
            }
            return operand_1 / operand_2;

        }
    }
}
