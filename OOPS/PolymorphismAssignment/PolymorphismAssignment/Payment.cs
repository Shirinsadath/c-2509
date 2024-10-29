using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing the payment ... ");
        }
    }
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Method of payment : Credit Card");
        }
    }
    public class PayPalPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Method of payment : PayPal");
        }
    }
}
