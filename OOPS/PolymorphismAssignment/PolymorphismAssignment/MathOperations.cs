using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{

    class MathOperations
    {
        // Method Overloading: Same method name, different parameters
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        // Virtual method for overriding
        public virtual void Calculate()
        {
            Console.WriteLine("Performing calculation.");
        }
    }
    class AdvancedMathOperations : MathOperations
    { 
        // Method Overriding
        public override void Calculate() 
        {
            Console.WriteLine("Performing advanced calculation."); 
        }
        // Overloaded method
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    }