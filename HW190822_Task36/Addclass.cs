using System;

namespace NotEvenPosition
{
    class InitialSettings : Program36
    {
        public int arrayIndex;
        public int[] arrayDigit;
        public InitialSettings()
        {
            this.arrayIndex = new Random().Next(this.arrayIndexStart, this.arrayIndexEnd);
            this.InitArray();
        }
        public void InitArray()
        {
            this.arrayDigit = new int[this.arrayIndex];
            for (int i = 0; i < this.arrayIndex; i++)
            {
                this.arrayDigit[i] = new Random().Next(this.arrayFirstNum, this.arrayUpperNum);
            }
        }
    }
    class ExecutNotEven
    {
        
        public int[] array;
        public ExecutNotEven(int[] array)
        {
            this.array = array;
            this.CountSum();
        }
        public void CountSum()
        {
            int i = this.array.Length;
            if (i >= 2)
            {
                i = 3;
                int sum = this.array[1];
                while (i < this.array.Length)
                {
                    sum += this.array[i];
                    i +=2;
                }
                Console.WriteLine($"В вашем массиве \n[{String.Join(", ", this.array)}] - ");
                Console.WriteLine($"Сумма элементов с нечетными индексами равна: {sum}");
            }
            else
            {
                Console.WriteLine($"В вашем массиве \n[{String.Join(", ", this.array)}] - ");
                Console.WriteLine("нет элементов с нечетными индексами");
            }

        }
    }
}

    