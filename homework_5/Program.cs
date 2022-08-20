using System;


namespace Homework_5 {
    class HW5 {

        static void Main() {
            
            Console.WriteLine("--------===== Decision Task 34 =====--------\n");
            Console.WriteLine("--------===== countEvenNum =====--------\n");
            
            int[] testArray = new int[] {345, 897, 568, 234};
            Task34 task34 = new Task34();

            Console.WriteLine($"Count even number: {task34.countEvenNum(testArray)}\n");


            Console.WriteLine("--------===== Decision Task 36 =====--------\n");
            Console.WriteLine("--------===== sumElementsArr =====--------\n");            

            Task36 task36 = new Task36();
            int[] testArray1 = new int[] {3, 7, 23, 12};
            int[] testArray2 = new int[] {-4, -6, 89, 6};
            int[] testArray3 = task36.randomArray(15);

            Console.WriteLine($"Count even number: {task36.sumElementsArr(testArray1)}\n");
            Console.WriteLine($"Count even number: {task36.sumElementsArr(testArray2)}\n");

            Console.WriteLine($"Random Array: [{string.Join(", ", testArray3)}] \n");
            Console.WriteLine($"Count even number: {task36.sumElementsArr(testArray3)}\n");


            Console.WriteLine("--------===== Decision Task 38 =====--------\n");
            Console.WriteLine("--------===== diffMaxAndMin =====--------\n");  
            Task38 task38 = new Task38();
            int[] testArray4 = new int[] {3, 7, 22, 2, 78};

            Console.WriteLine($"Count even number: {task38.diffMaxAndMin(testArray4)}\n");
            Console.WriteLine("--------===== diffMaxAndMinV1 =====--------\n");  
            Console.WriteLine($"Count even number: {task38.diffMaxAndMinV1(testArray4)}\n");
        }

    }
}