using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculator
    {
        private Queue<string> historyCalculator;
        private string date;

        public Calculator(string date)
        {
            historyCalculator = new();
            this.date = date;
        }
        
        public int sum(int n1, int n2)
        {
            int result = n1 + n2;
            AddHistory($"{n1} + {n2} = {result} date: {date}");
            return result;
        }

        public int subtract(int n1, int n2)
        {
            int result = n1 - n2;
            AddHistory($"{n1} - {n2} = {result} date: {date}");
            return result;
        }

        public int multiply(int n1, int n2)
        {
            int result = n1 * n2;
            AddHistory($"{n1} * {n2} = {result} date: {date}");
            return result;
        }

        public int divide(int n1, int n2)
        {
            int result = n1 / n2;
            AddHistory($"{n1} / {n2} = {result} date: {date}");
            return result;
        }

        private Queue<string> AddHistory(string operation)
        {
            historyCalculator.Enqueue(operation);
            if (historyCalculator.Count > 3) historyCalculator.Dequeue();
            return historyCalculator;
        }

        public Queue<string> GetHistory()
        {
            return historyCalculator;
        }
    }
}
