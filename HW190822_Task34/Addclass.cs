using System;

namespace ThreeDigit
{
    class InitialSettings : Program34
    {
        public int arrayIndex;
        public int[] arrayThreeDigit;
        public InitialSettings()
        {
            this.arrayIndex = new Random().Next(this.arrayIndexStart, this.arrayIndexEnd);
            this.InitArray();
        }
        public void InitArray()
        {
            this.arrayThreeDigit = new int[this.arrayIndex];
            for (int i = 0; i < this.arrayIndex; i++)
            {
                this.arrayThreeDigit[i] = new Random().Next(this.arrayFirstNum, this.arrayUpperNum);
            }
        }
    }
    class ExecutEven 
    {
        public int[] array;
        public ExecutEven(int[] array)
        {
            this.array = array;
            this.CountEven();
        }
        public void CountEven()
        {
            int evenCounter = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if ((this.array[i] % 2) == 0) 
                {
                    evenCounter += 1;
                }
            }
            Console.WriteLine($"В вашем массиве \n[{String.Join(", ", this.array)}] - \n{evenCounter} четных чисел");
        }

    }
}