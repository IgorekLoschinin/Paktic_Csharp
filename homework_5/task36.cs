using System;


namespace Homework_5 {

    class Task36 {

        public int[] randomArray (int size) {

            int[] arr = new int[size];
            Random myRandom = new Random();
            for (int i = 0; i < size; i++) {
                arr[i] = myRandom.Next(0, 1000);
            }

            return arr;
        }

        public int sumElementsArr (int[] arr) {
            
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                if ((i % 2) == 1) {
                    sum += arr[i];
                }
            }

            return sum;
        }

    }

}