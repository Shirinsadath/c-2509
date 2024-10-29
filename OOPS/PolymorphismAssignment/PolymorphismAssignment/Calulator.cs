using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Calculator
    {
        
        public int Multiply(int Number1, int Number2)
        {
            int Result= Number1*Number2;
            return Result;
        }
        public int Multiply(int Number1, int Number2, int Number3)
        {
            int Result= Number1*Number2*Number3;
            return Result;
        }
        public double Multiply(double Number1, double Number2)
        {
            double Result= Number1*Number2;
            return Result;
        }
        public double Multiply(int Number1, double Number2)
        {
            double result= Number1*Number2;
            return result;
        }

    }
}
