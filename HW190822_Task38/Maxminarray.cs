using System;

namespace MaxMinArray
{
    class Program38
    {
        public int arrayFirstNum = 0;
        public int arrayUpperNum = 100;
        public int arrayIndexStart = 10;
        public int arrayIndexEnd = 30;
        static void Main(string[] args) 
        {
            Console.Clear();
            InitialSettings init = new InitialSettings();
            ExecutMaxMin exec = new ExecutMaxMin(init.arrayDigit);
            
        }

    }
}