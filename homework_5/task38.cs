using System;


namespace Homework_5 {

    class Task38 {

        public int diffMaxAndMin (int[] arr) {

            int difference = arr.Max() - arr.Min();

            return difference;

        }

        public int diffMaxAndMinV1 (int[] arr) {

            int min = arr[0];
            int max = 0;

            foreach (int item in arr) {
                if (item > max) {

                    max = item;

                } else if (item < min) {

                    min = item;

                }
            }

            return max - min;

        }

    }

}