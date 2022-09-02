using System.Runtime.InteropServices;
using System.IO;
using Math;

namespace Program
{
    public class Program
    {
        #region private methods

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int result;
            int op1;
            int op2;
            char oper;
            while (true)
            {
                op1 = AskUserForIntegerInput("Nombre 1: ");
                oper = AskUserForCharInput("Operateur: ");
                op2 = AskUserForIntegerInput("Nombre 2: ");

                result = PerformOperation(op1, oper, op2);

                DisplayResult(op1, oper, op2, result);
            }
        }

        /// <summary>
        /// ask user a char input 
        /// </summary>
        /// <param name="question">
        /// the question to ask to the user
        /// </param>
        /// <returns>char</returns>
        private static char AskUserForCharInput(string question)
        {
            while (true)
            {
                //TODO Use appropriate method instead of duplicate code Console.Write (DRY)
                Console.Write(question);
                string result = Console.ReadLine();
                char OutChar;
                char[] operateur = { '*', '/', '-', '+' };
                if (Char.TryParse(result,out OutChar) && operateur.Contains(OutChar))
                {
                    return OutChar;
                }
            }
        }
        /// <summary>
        /// ask user a int input
        /// </summary>
        /// <param name="question"></param>
        /// <returns>int</returns>
        private static int AskUserForIntegerInput(string question)
        {
            while (true)
            {
                //TODO Use appropriate method instead of duplicate code Console.Write (DRY)
                Console.Write(question);
                string result = Console.ReadLine();
                int OutInt;
                if (Int32.TryParse(result, out OutInt))
                {
                    return OutInt;
                }
            }
        }
        /// <summary>
        /// Display the result of the calculation
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="oper">operator (+, -, *, /)</param>
        /// <param name="op2">Number 2</param>
        /// <param name="res">resultat</param>
        private static void DisplayResult(int op1, char oper, int op2, int res)
        {
            DisplayMessage($"{op1.ToString()} {oper.ToString()} {op2.ToString()} = {res.ToString()}");
        }
        /// <summary>
        /// to display a message
        /// </summary>
        /// <param name="message">Message to display</param>
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// to perform a operation
        /// </summary>
        /// <param name="op1">Number 1</param>
        /// <param name="oper">Operator (+,-,*,/)</param>
        /// <param name="op2">Number 2</param>
        /// <returns></returns>
        private static int PerformOperation(int op1, char oper, int op2)
        {
            //TODO Remove unreacheable code
            switch (oper)
            {
                case '+':
                    return MathsBasicOperation.Add(op1, op2);
                    break;
                case '-':
                    return MathsBasicOperation.Substract(op1, op2);
                    break;
                case '*':
                    return MathsBasicOperation.Multiply(op1, op2);
                    break;
                case '/':
                    return MathsBasicOperation.Divide(op1, op2);
                    break;
                default:
                    return 0;
                    break;
            }
        }
        #endregion private methods
    }
}
