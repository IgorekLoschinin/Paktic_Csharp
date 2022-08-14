using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4 {

    class Task29 {

        public void PrintArray1D (int[] array) {            
            Console.WriteLine($"[{string.Join(", ", array)}] \n");
        }

        public void PrintArray1DV2 (int size) {
            
            int[] array = new int[size];
            Random myRandom = new Random();
            
            for (int i = 0; i < size; i++)
            {
                array[i] = myRandom.Next(0, 100);
            }

            PrintArray1D(array);
        }

    }

}