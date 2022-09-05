using System;

namespace Math
{
    public static class MathsBasicOperation
    {
        /// <summary>
        /// Add method to add two numbers
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="op2">Number 2</param>
        /// <returns></returns>
        public static int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        /// <summary>
        /// Substract method to substract two numbers
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="op2">Number 2</param>
        /// <returns></returns>
        public static int Substract(int op1, int op2)
        {
            return op1 - op2;
        }
        /// <summary>
        /// Multiply method to multiply two numbers
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="op2">Number 2</param>
        /// <returns></returns>
        public static int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }
        /// <summary>
        /// Divide method to divide two numbers
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="op2">Number 2</param>
        /// <returns></returns>
        public static int Divide(int op1, int op2)
        {
            if (op1 != 0 || op2 != 0)
            {
                return op1 / op2;
            }
            else
            {
                throw new Exception("Cannot divide by 0");
            }
        }
    }
}

