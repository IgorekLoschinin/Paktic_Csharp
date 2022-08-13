// See https://aka.ms/new-console-template for more information

using System;


namespace homework3 {

    class Point1 {
        public int x;
        public int y;
        public int z;
        public Point1 (int a, int b, int c) {
            x = a;
            y = b;
            z = c;
        }
    }

    class Point2 {
        public int x;
        public int y;
        public int z;
        public Point2 (int a, int b, int c) {
            x = a;
            y = b;
            z = c;
        }
    }

    class Task21
    {
        public void distancePoint3D(Point1 A, Point2 B) {

            double distance = Math.Sqrt(
                Math.Pow((B.x - A.x), 2) + 
                Math.Pow((B.y - A.y), 2) + 
                Math.Pow((B.z - A.z), 2)
            );
            distance = Math.Round(distance, 2);


            Console.WriteLine($"Distance in 3D space: {distance}");
        }
    }
    
}