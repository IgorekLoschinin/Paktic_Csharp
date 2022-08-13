using System;


namespace homework3 {

    class Task23 {

        public void cubeNum (int n) {

            for (int i=1; i<=n; i++) {
                Console.Write($"{Math.Pow(i, 3)} ");
            }
            Console.Write("\n");

        }

    }

}