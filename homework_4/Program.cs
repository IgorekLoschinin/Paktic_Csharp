using System;

namespace Homework4 {

    class Homework {
        static void Main (string[] args) {
            
            Console.WriteLine("--------===== Decision Task 25 =====--------\n");
            Console.WriteLine("\t--------===== customPow and customPowV2 =====--------\n");  
            Task25 task25 = new Task25();
            task25.customPow(3, 5);
            task25.customPow(2, 4);
            task25.customPowV2(3, 5);
            task25.customPowV2(2, 4);

            Console.WriteLine("--------===== Decision Task 27 =====--------\n");
            Console.WriteLine("\t--------===== SumDigitINNumber =====--------\n"); 
            Task27 task27 = new Task27();
            task27.SumDigitINNumber(452);
            task27.SumDigitINNumber(82);
            task27.SumDigitINNumber(9012);
            Console.WriteLine("\t--------===== SumDigitINNumberV2 =====--------\n"); 
            task27.SumDigitINNumberV2(452);
            task27.SumDigitINNumberV2(82);
            task27.SumDigitINNumberV2(9012);
            
            Console.WriteLine("--------===== Decision Task 29 =====--------\n");
            Console.WriteLine("\t--------===== PrintArray1D =====--------\n"); 
            Task29 task29 = new Task29();
            
            // Любой длинны
            int[] theArray = {1,2,3,4,5,6,7,8,1234,234,23,42,34,2,34,234,23};
            task29.PrintArray1D(theArray);
            task29.PrintArray1DV2(8);

            // Можно передать массив только из 8 элементов
            int[] Array = new int[8]{1,2,3,4,5,6,7,8};
            task29.PrintArray1D(Array);
        }
    }

}
