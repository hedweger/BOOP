using System;
using System.Collections.Generic;
using System.Text;

namespace cv09
{
    public class Calculator
    {
        public string Display = "0";
        public string Memory;
        public void Button(string btn)
        {
            var number = "";
            switch (btn) {
                case "0":
                    number += "0";
                    break;
                case "1":
                    number += "1";
                    break;
                case "2":
                    number += "2";
                    break;
                case "3":
                    number += "3";
                    break;
                case "4":
                    number += "4";
                    break;
                case "5":
                    number += "5";
                    break;
                case "6":
                    number += "6";
                    break;
                case "7":
                    number += "7";
                    break;
                case "8":
                    number += "8";
                    break;
                case "9":
                    number += "9";
                    break;
                case ",":
                    number += ",";
                    break;
                case "+":
                    _state = State.Operation;
                    operation = Operation.Add;
                    break;
                case "-":
                    _state = State.Operation;
                    operation = Operation.Subtract;
                    break;
                case "*":
                    _state = State.Operation;
                    operation = Operation.Multiply;
                    break;
                case "/":
                    _state = State.Operation;
                    operation = Operation.Divide;
                    break;
                case "=":
                    _state = State.Result;
                    answer = FindAnswer();
                    Display = answer;
                    first = "";
                    second = "";
                    answer = "";
                    break;
                case "+-":
                    if (Display != "")
                    {
                        if (_state == State.FirstNumber)
                        {
                            var temp = Convert.ToDouble(first) * -1;
                            first = "" + temp;
                        }
                        if (_state == State.SecondNumber)
                        {
                            var temp = Convert.ToDouble(second) * -1;
                            second = "" + temp;
                        }
                    }
                    break;
                case "←":
                    if (_state == State.FirstNumber)
                    {
                        first = first.Substring(0, first.Length - 1);
                    }
                    if (_state == State.SecondNumber)
                    {
                        second = second.Substring(0,second.Length - 1);
                    }
                    break;
                case "C":
                    Display = "0";
                    _state = State.FirstNumber;
                    break;
                case "CE":
                    if (_state == State.FirstNumber)
                    {
                        first = "0";
                        Display = first;
                    }
                    if (_state == State.SecondNumber)
                    {
                        second = "0";
                        Display = second;
                    }
                    break;
                case "MC":
                    Memory = "";
                    break;
                case "MS":
                    Memory = Display;
                    break;
                case "MR":
                    if (_state == State.FirstNumber)
                        first = Memory;
                        
                    if (_state == State.SecondNumber)
                        second = Memory;
                       
                    Display = Memory;
                    break;
                default:
                    break;
            }
            switch(_state)
            {
                case State.FirstNumber:
                    first += number;
                    Display = first;
                    break;
                case State.SecondNumber:
                    second += number;
                    Display = second;
                    break;
                case State.Operation:
                    _state = State.SecondNumber;
                    break;
                case State.Result:
                    _state = State.FirstNumber;
                    break;
            }

        }
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        enum State
        {
            FirstNumber,
            Operation,
            SecondNumber,
            Result
        }
        private string first = "";
        private string second = "";
        private string answer = "";
        State _state;
        Operation operation;

        string FindAnswer()
        {
            var one = Convert.ToDouble(first);
            var two = Convert.ToDouble(second);
            double answer = 0;

            switch(operation)
            {
                case Operation.Add:
                    answer = one + two;
                    break;
                case Operation.Subtract:
                    answer = one - two;
                    break;
                case Operation.Multiply:
                    answer = one * two;
                    break;
                case Operation.Divide:
                    answer = one / two;
                    break;
            }
            return "" + answer;
        }
    }
}
