using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = {"1", "12", "123", "1234"};

            string[] outputArray = StringArrayFilter(inputArray);
            
            for (int i = 0; i < outputArray.Length; i++) Console.WriteLine(outputArray[i]);
        }

        static string[] StringArrayFilter(string[] inputArray, int maxLength = 3)
        {
            
            int counter = 0;
            
            for (int i = 0; i < inputArray.Length; i++) if (inputArray[i].Length <= maxLength) counter +=1;

            string[] outputArray = new string[counter];

            counter = 0;

            for (int i = 0; i < inputArray.Length; i++) if (inputArray[i].Length <= maxLength) outputArray[counter++] = inputArray[i];
            
            return outputArray;

        }
    }
}
