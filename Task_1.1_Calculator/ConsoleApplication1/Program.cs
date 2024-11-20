using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Part_1
{


    public class MyCalculator
    {
        public const string PLUS = "+";
        public const string MINUS = "-";
        public const string MULTIPLICATION_SIGN = "*";
        public const string DIVISION_SIGN = "/";
        string operationSign;
        string firstNumber;
        string secondNumber;


        public static void Main(String[] args)
        {
            MyCalculator calc = new MyCalculator();
            calc.printMenu();
            calc.receiveExpression();
        }

        public void printMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print arithmetic expression.");
            Console.WriteLine("2. Use two numbers of integer type.");
            Console.WriteLine("3. The following arithmetic operations can be used: +  -  *  /.");
            Console.WriteLine("4. Use whitespaces.");
            Console.WriteLine("5. Click <Enter>.");
        }

        // checking that entered expression is valid and calculating the result
        public void receiveExpression()
        {
            while (true)
            {
                checkIfEmptyLine(Console.ReadLine());
            }
        }

        public void checkIfEmptyLine(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                Console.Error.WriteLine("Please enter an arithmetic expression.");
                return;
            }
            parseLine(line);
        }

        public void parseLine(string line)
        {
            string[] expression = line.Split();
            try
            {
                firstNumber = expression[0];
                operationSign = expression[1];
                secondNumber = expression[2];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Error.WriteLine("The expression is incorrect. Please try again.");
            }
            checkifNotInt(firstNumber);
        }

        public void checkifNotInt(string firstNumber)
        {
            int number;
            bool key = Int32.TryParse(firstNumber, out number);
            if (!key)
            {
                Console.Error.WriteLine("Only integer values should be used.");
                return;
            }
            else
            {
                checkIfNoOperation(operationSign);
            }
        }

        public void checkIfNoOperation(string operationSign)
        {

            if ((operationSign != "+") & (operationSign != "-") & (operationSign != "*") & (operationSign != "/"))
            {
                Console.Error.WriteLine("Please enter a correct operation sign.");
                return;
            }
            else
            {
                checkIfAnotherNotInt(secondNumber);
            }
        }

        public void checkIfAnotherNotInt(string secondNumber)
        {
            int number;
            bool key = Int32.TryParse(secondNumber, out number);
            if (!key)
            {
                Console.Error.WriteLine("Only integer values should be used.");
                return;
            }
            else
            {
                calculateResult(int.Parse(firstNumber), operationSign, int.Parse(this.secondNumber));
            }
        }

        public void calculateResult(int numberOne, String sign, int numberTwo)
        {
            switch (sign)
            {
                case PLUS:
                    add(numberOne, numberTwo);
                    break;
                case MINUS:
                    subtract(numberOne, numberTwo);
                    break;
                case MULTIPLICATION_SIGN:
                    multiply(numberOne, numberTwo);
                    break;
                case DIVISION_SIGN:
                    divide(numberOne, numberTwo);
                    break;
                default:
                    Console.Error.WriteLine("The expression is invalid.");
                    break;
            }
        }

        // methods for different arithmetic operations
        public void add(int numberOne, int numberTwo)
        {
            int result;
            result = numberOne + numberTwo;
            Console.WriteLine("= " + result);
        }

        public void subtract(int numberOne, int numberTwo)
        {
            int result;
            result = numberOne - numberTwo;
            Console.WriteLine("= " + result);
        }

        public void multiply(int numberOne, int numberTwo)
        {
            int result;
            result = numberOne * numberTwo;
            Console.WriteLine("= " + result);
        }

        public void divide(int numberOne, int numberTwo)
        {
            int result = 0;
            try
            {
                result = numberOne / numberTwo;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("The denominator can't be equal to 0");
            }
            if (numberTwo != 0)
            {
                Console.WriteLine("= " + result);
            }
        }
    }
}