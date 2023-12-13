using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace calculatorUI
{
    public class calculator
    {
        //display string
        public string Expression = ""; //stat
        public string DigitExpression = "";
        //Update records
        public Action UpdateRecordUI;

        public List<RecordItem> Records { get; set; } = new List<RecordItem>();

        //status flag
        private bool resetDigitExpression = false;
        private bool suspendOperation = false;
        private bool suspendEqual = false;
        private bool divideZeroError = false;
        private Stack<string> operationStack = new Stack<string>();

        public void KeyIn(string keyInChar)
        {
            switch (keyInChar)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    if (!suspendOperation)
                    {
                        if (operationStack.Count == 0)
                        {
                            if (DigitExpression == "")
                            {
                                DigitExpression = "0";
                            }

                            //DigitExpress ion put in stack
                            operationStack.Push(DigitExpression);
                            // Operation put in stack
                            operationStack.Push(keyInChar);

                            Expression = DigitExpression.ToString() + keyInChar;

                        }

                        else if (operationStack.Count == 2 && (operationStack.Peek() == "+" || operationStack.Peek() == "-" || operationStack.Peek() == "*" || operationStack.Peek() == "/"))
                        {
                            operationStack.Push(DigitExpression);

                            decimal? backValue = Convert.ToDecimal(operationStack.Pop());
                            string calculateType = operationStack.Pop();
                            decimal? frontValue = Convert.ToDecimal(operationStack.Pop());

                            decimal? reuslt = calculateOperation(frontValue, backValue, calculateType);
                            Records.Add(new RecordItem(frontValue.ToString() + calculateType + backValue.ToString() + "=" + reuslt.ToString()));
                            UpdateRecordUI?.Invoke();

                            if (frontValue == null)
                            {
                                DigitExpression = "Divide zero errer";
                                return;
                            }

                            //push back to stack
                            operationStack.Push(reuslt.ToString());
                            operationStack.Push(keyInChar);
                            operationStack.Push(backValue.ToString());


                            //update expression
                            DigitExpression = reuslt.ToString();
                            Expression = reuslt.ToString() + keyInChar;
                        }

                        else if (operationStack.Count == 3 && (operationStack.ElementAt(1) == "+" || operationStack.ElementAt(1) == "-" || operationStack.ElementAt(1) == "*" || operationStack.ElementAt(1) == "/"))
                        {
                            decimal? backValue = Convert.ToDecimal(operationStack.Pop());
                            string calculateType = operationStack.Pop();
                            decimal? frontValue = Convert.ToDecimal(operationStack.Pop());

                            decimal? reuslt = calculateOperation(frontValue, backValue, calculateType);
                            Records.Add( new RecordItem(frontValue.ToString() + calculateType + backValue.ToString() + "=" + reuslt.ToString()));
                            UpdateRecordUI?.Invoke();

                            if (frontValue == null)
                            {
                                DigitExpression = "Divide zero errer";
                                return;
                            }
                            //push back to stack
                            operationStack.Push(reuslt.ToString());
                            operationStack.Push(keyInChar);
                            operationStack.Push(backValue.ToString());

                            //update expression
                            DigitExpression = reuslt.ToString();
                            Expression = reuslt.ToString() + keyInChar;
                        }
                        // update Status
                        suspendOperation = true;
                        resetDigitExpression = true;
                        suspendEqual = true;

                    }

                    else
                    {
                        decimal? backValue = Convert.ToDecimal(operationStack.Pop());
                        string calculateType = operationStack.Pop();
                        decimal? frontValue = Convert.ToDecimal(operationStack.Peek());

                        operationStack.Push(keyInChar);
                        operationStack.Push(backValue.ToString());

                        //update expression
                        Expression = frontValue.ToString() + keyInChar;

                        // update Status
                        resetDigitExpression = true;
                        suspendOperation = true;
                        suspendEqual = false;
                    }

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
                    if (divideZeroError)
                        return;

                    if (resetDigitExpression)
                    {
                        DigitExpression = "";
                    }

                    //Console.WriteLine(keyInChar);
                    DigitExpression += keyInChar;

                    if (DigitExpression == ".")
                    {
                        DigitExpression = "0.";
                    }

                    // update Status
                    resetDigitExpression = false;
                    suspendOperation = false;
                    suspendEqual = false;
                    break;

                case "<-":
                    if (divideZeroError)
                        return;
                    DigitExpression = DigitExpression.Substring(0, DigitExpression.Length - 1);
                    break;

                case "C":
                    #region bak
                    //Expression = "";
                    //               DigitExpression = "";
                    //               FrontValue = null;
                    //               BackValue = null;
                    #endregion
                    operationStack.Clear();
                    Expression = "";
                    DigitExpression = "";

                    resetDigitExpression = false;
                    suspendOperation = false;
                    suspendEqual = false;
                    divideZeroError = false;

                    break;

                case "=":
                    if (divideZeroError)
                        return;
                    if (!suspendEqual)
                    {
                        if (operationStack.Count == 3)
                        {
                            operationStack.Pop();
                        }

                        operationStack.Push(DigitExpression);

                        decimal? backValue = Convert.ToDecimal(operationStack.Pop());
                        string calculateType = operationStack.Pop();
                        decimal? frontValue = Convert.ToDecimal(operationStack.Pop());

                        decimal? reuslt = calculateOperation(frontValue, backValue, calculateType);
                        Records.Add(new RecordItem(frontValue.ToString() + calculateType + backValue.ToString() + "=" + reuslt.ToString()));
                        UpdateRecordUI?.Invoke();

                        if (reuslt == null)
                        {
                            DigitExpression = "Divide zero errer";
                            return;
                        }
                        //push back to stack
                        operationStack.Push(reuslt.ToString());
                        operationStack.Push(calculateType);
                        operationStack.Push(backValue.ToString());

                        //update expression
                        DigitExpression = reuslt.ToString();
                        Expression = frontValue.ToString() + calculateType + backValue + "=" + reuslt.ToString();

                        //update Status
                        resetDigitExpression = true;
                        suspendOperation = true;
                        suspendEqual = true;
                    }
                    break;
            }
        }

        public void DoubleClickEqual()
        {
            if (divideZeroError)
                return;

            decimal? backValue = Convert.ToDecimal(operationStack.Pop());
            string calculateType = operationStack.Pop();
            decimal? frontValue = Convert.ToDecimal(operationStack.Pop());

            decimal? reuslt = calculateOperation(frontValue, backValue, calculateType);
            Records.Add(new RecordItem(frontValue.ToString() + calculateType + backValue.ToString() + "=" + reuslt.ToString()));
            UpdateRecordUI?.Invoke();

            if (reuslt == null)
            {
                DigitExpression = "Divide zero errer";
                return;
            }
            //push back to stack
            operationStack.Push(reuslt.ToString());
            operationStack.Push(calculateType);
            operationStack.Push(backValue.ToString());

            //update expression
            DigitExpression = reuslt.ToString();
            Expression = frontValue.ToString() + calculateType + backValue + "=" + reuslt.ToString();

            //update Status
            suspendOperation = true;
            resetDigitExpression = true;
        }

        private decimal? calculateOperation(decimal? frontDigit, decimal? backDigit, string operationType)
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

        public class RecordItem
        {
            public string record { get; set; } = "";
            public RecordItem(string _record)
            {
                record = _record;
            }
            public RecordItem()
            {

            }
        }

    }
}
