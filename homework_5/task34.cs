using System;


namespace Homework_5 {

    class Task34 {

        public int countEvenNum (int[] arr) {
            
            int count = 0;
            int evenNum;

            foreach(int item_num in arr) {
                
                evenNum = item_num % 2;

                if (evenNum == 0) {
                    count += 1;
                }

            }

            return count;

        }

    }

}