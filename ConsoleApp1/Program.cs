using System.Runtime.InteropServices;
using System.IO;

namespace Program
{
    public class Program
    {
        #region private attribute
        private int result;
        private int op1;
        private int op2;
        private char oper;
        #endregion private attribute

        #region private methods
        private void Main(string args)
        {
            while (true)
            {
                DisplayMessage("Nombre 1: ");
                AskUserForIntegerInput();
            }
        }
        private char AskUserForCharInput(string question)
        {
            Console.Write(question);
            result = Console.Read();
            
        }
        private int AskUserForIntegerInput(string question)
        {
            while (true)
            {
                Console.Write(question);
                string result = Console.ReadLine();
                if (Int32.TryParse(result))
                {
                    return Int32.Parse(result);
                }
            }
        }
        private void DisplayResult(int op1, char oper, int op2, int result)
        {
            throw new NotImplementedException();
        }
        private void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private int Add(int op1, int op2)
        {
            throw new NotImplementedException();
        }
        private int Substract(int op1, int op2)
        {
            throw new NotImplementedException();
        }
        private int Multiply(int op1, int op2)
        {
            throw new NotImplementedException();
        }
        private int Divide(int op1, int op2)
        {
            throw new NotImplementedException();
        }
        private Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        #endregion private methods
    }
}
