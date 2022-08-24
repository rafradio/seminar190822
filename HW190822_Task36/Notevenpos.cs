using System;

namespace NotEvenPosition
{
    class Program36
    {
        public int arrayFirstNum = -100;
        public int arrayUpperNum = 100;
        public int arrayIndexStart = 10;
        public int arrayIndexEnd = 30;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new InitialSettings();
            ExecutNotEven exec = new ExecutNotEven(init.arrayDigit);
            
        }
    }
}