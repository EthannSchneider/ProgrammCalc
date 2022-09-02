using System.Runtime.InteropServices;
using System.IO;
using Math;

namespace Program
{
    public class Program
    {
        #region private methods
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
        private static char AskUserForCharInput(string question)
        {
            while (true)
            {
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
        private static int AskUserForIntegerInput(string question)
        {
            while (true)
            {
                Console.Write(question);
                string result = Console.ReadLine();
                int OutInt;
                if (Int32.TryParse(result, out OutInt))
                {
                    return OutInt;
                }
            }
        }
        private static void DisplayResult(int op1, char oper, int op2, int result)
        {
            DisplayMessage($"{op1.ToString()} {oper.ToString()} {op2.ToString()} = {result.ToString()}");
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static int PerformOperation(int op1, char oper, int op2)
        {
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
