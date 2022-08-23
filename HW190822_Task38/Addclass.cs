using System;

namespace MaxMinArray
{
    class InitialSettings : Program38
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
    class ExecutMaxMin
    {
        
        public int[] array;
        public ExecutMaxMin(int[] array)
        {
            this.array = array;
            this.CountDiff();
        }
        public void CountDiff()
        {
            int max = this.array[0];
            int min = this.array[0];
            int diff;
            for (int i = 0; i < this.array.Length; i++) 
            {
                if (this.array[i] > max) max = this.array[i];
                if (this.array[i] < min) min = this.array[i];
            }
            diff = max - min;
            Console.WriteLine($"В вашем массиве \n[{String.Join(", ", this.array)}] - ");
            Console.WriteLine($"разница между максимумом и минимумом равна {diff}");
        }

    }
}