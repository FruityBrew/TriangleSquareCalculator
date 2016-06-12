using System;

namespace XCompanyLib
{
    public static class XTriangleSquareCalculator
    {
        public static Double TriangleSqureCalculate(Double sideA, Double sideB, Double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) 
                throw new ArgumentOutOfRangeException("Values can not be less than or equal zero");

            var hypotenuse = sideA;
            var cathetusA = sideB;
            var cathetusB = sideC;

            if (sideB > hypotenuse)
                {
                    hypotenuse = sideB;
                    cathetusA = sideA;
                }

            if (sideC > hypotenuse)
                {
                    hypotenuse = sideC;
                    cathetusB = sideB;
                    cathetusA = sideA;  
                }            

            if ( hypotenuse * hypotenuse != cathetusA * cathetusA + cathetusB * cathetusB)
                throw new ArgumentException("A triangle which sides were inputted is not a right triangle");
            
            return cathetusA * cathetusB / 2;                    
        }

        public override string ToString()
        {
            return "A`m Triangle!";
        }
    }
}
