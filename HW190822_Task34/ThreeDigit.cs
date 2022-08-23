using System;

namespace ThreeDigit
{
    class Program34
    {
        public int arrayFirstNum = 100;
        public int arrayUpperNum = 1000;
        public int arrayIndexStart = 10;
        public int arrayIndexEnd = 30;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new InitialSettings();
            ExecutEven exec = new ExecutEven(init.arrayThreeDigit);   
        }
    }
}