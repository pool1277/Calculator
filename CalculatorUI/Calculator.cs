using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI
{
    public static class Calculator
    {
        public static string Expression = ""; //stat
        public static string DigitExpression = "";
        public static string Result = "";
        public static decimal? FrontValue = null;
        public static decimal? BackValue = null;
        public static bool ResetDigitExpression = false;
        public static bool SuspendOperation = false;
        public static bool SuspendEqual = false;

        public static void KeyIn(string keyInChar)
        {
            switch (keyInChar)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    if (Expression.Contains("=")) // press "=" should update Expression First 
                    {
                        Expression = Expression = FrontValue.ToString() + keyInChar;
                    }

                    if (!SuspendOperation)
                    {
                        if (FrontValue == null) //First time Key in 
                        {
                            FrontValue = Convert.ToDecimal(DigitExpression);

                            //update expression
                            Expression = DigitExpression + keyInChar;
                        }
                        else
                        {
                            BackValue = Convert.ToDecimal(DigitExpression);

                            //calculate
                            string calculateType = Expression.Last().ToString();
                            FrontValue = calculateOperation(FrontValue, BackValue, calculateType);

                            if(FrontValue == null)
                            {
                                DigitExpression = "Divide zero errer";
                                return;
                            }

                            //update expression
                            DigitExpression = FrontValue.ToString();
                            Expression = FrontValue.ToString() + keyInChar;
                        }
                        SuspendOperation = true;
                    }
                    else //Check if different keyInChar
                    {
                        //calculate
                        string calculateType = Expression.Last().ToString();
                        if (calculateType != keyInChar)
                        {
                            //update expression
                            Expression = Expression.Substring(0, Expression.Length - 1) + keyInChar;
                        }
                    }
                    ResetDigitExpression = true;

                    break;

                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                    if (ResetDigitExpression)
                    {
                        DigitExpression = "";
                        ResetDigitExpression = false;
                    }
                    Console.WriteLine(keyInChar);
                    DigitExpression += keyInChar;
                    SuspendOperation = false;
                    break;

                case "<-":
     
                    DigitExpression = DigitExpression.Substring(0, DigitExpression.Length - 1);
                    break;

                case "C":
                    Expression = "";
                    DigitExpression = "";
                    FrontValue = null;
                    BackValue = null;
                    break;

                case "=":
                    if (!SuspendOperation)
                    {
                        if (FrontValue != null)
                        {
                            BackValue = Convert.ToDecimal(DigitExpression);

                            //calculate
                            string calculateType = Expression.Last().ToString();
                            decimal? Result = calculateOperation(FrontValue, BackValue, calculateType);

                            if (Result == null)
                            {
                                DigitExpression = "Divide zero errer";
                                return;
                            }

                            //update expression
                            DigitExpression = Result.ToString();
                            Expression = FrontValue.ToString() + calculateType + BackValue.ToString() + "=" + Result.ToString();

                            //update FrontValue;
                            FrontValue = Result;  
                        }
                        SuspendOperation = true;
                    }
                    break;
            }
        }


        public static void DoubleClickEqual()
        {
            if (DigitExpression != "")
            {
                BackValue = Convert.ToDecimal(DigitExpression);

                //calculate
                string calculateType = Expression.Last().ToString();
                FrontValue = calculateOperation(FrontValue, BackValue, calculateType);

                if (FrontValue == null)
                {
                    DigitExpression = "Divide zero errer";
                    return;
                }

                //update expression
                DigitExpression = FrontValue.ToString();
                Expression = FrontValue.ToString() + calculateType;
            }
        }

        private static decimal? calculateOperation(decimal? frontDigit, decimal? backDigit, string operationType)
        {
            decimal? result = 0;
            switch (operationType)
            {
                case "+":
                    result = frontDigit + backDigit;
                    break;
                case "-":
                    result = frontDigit - backDigit;
                    break;
                case "*":
                    result = frontDigit * backDigit;
                    break;
                case "/":
                    if (backDigit == 0) // divide zero error
                    {
                        result = null;
                    }
                    else
                    {
                        result = frontDigit / backDigit;
                    }
                    break;
            }
            return result;
        }
    }
}
