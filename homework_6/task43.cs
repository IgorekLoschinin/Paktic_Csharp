namespace Homework_6 {
    class EquationLine1 {
        public double k1;
        public double b1;
        public double x1;

        public double y1;
        public EquationLine1 (double k, double b) {
            k1 = k;
            b1 = b;
            x1 = 0;
            y1 = 0;
        }

        public void setX (double x) {
            x1 = x;
        }

        public void equationSolution () {
            if (x1 != 0) {
                y1 = (k1 * x1) + b1;
            }          
        }
    }

    class EquationLine2 {
        public double k2;
        public double b2;
        public double x2;
        public double y2;
        public EquationLine2 (double k, double b) {
            k2 = k;
            b2 = b;
            x2 = 0;
            y2 = 0;
        }

        public void setX (double x) {
            x2 = x;
        }

        public void equationSolution () {
            if (x2 != 0) {
                y2 = (k2 * x2) + b2;
            }          
        }
    }

    class Task43 {

        public double[] intersectionPoint (EquationLine1 eq1, EquationLine2 eq2) {           

            double[,] arr2D = {{eq1.k1, eq2.k2}, {eq1.b1, eq2.b2}};

            int sizeArr = arr2D.GetLength(0);

            double[] arrEq3 = new double[sizeArr];

            for (int i = 0; i < sizeArr; i++) {
                arrEq3[i] = arr2D[i, 0] - arr2D[i, 1];
            }

            double x = (arrEq3[1] / arrEq3[0]) * (-1);            

            eq1.setX(x);
            eq1.equationSolution();

            double[] pointSect = new double[2] {x, eq1.y1};

            return pointSect;
            
        }
    }

}