using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_ASSIGNMENT4_abstract__partial__interface
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false)]
    public class DeveloperAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string LastModified { get; }
        public DeveloperAttribute(string developerName, string lastModified)
        {
            DeveloperName = developerName;
            LastModified = lastModified;
        }
    }
    [Developer("Shirin", "2023-10-01")]
    public class Calculator
    {
        [Developer("Rehaan", "2023-10-05")]
        public int Add(int a, int b)
        {
            return a + b;

        }
    }
}
