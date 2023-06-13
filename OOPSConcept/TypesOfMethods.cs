using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // -- Virtual method
    public class A
    {
        public virtual int Calculate(int a, int b)
        {
            return a + b;
        }
    }
    public class B : A
    {
        public override int Calculate(int a, int b)
        {
            return a + b + 1;
        }
    }

    // -- Abstract Method
    public abstract class C
    {
        public abstract int Calculate(int a, int b);
    }

    public class D : C
    {
        public override int Calculate(int a, int b)
        {
            return (a + b) + 1;
        }
    }

    // -- Partial Method
    partial class E
    {
        partial void PartialMethod(int a, int b);
    }

    // -- Static Method
    public static class StaticClass
    {
        public static string HelloMessage(string  message)
        {
            return message;
        }
    }

    // -- Non static method

    public class NonStaticClass
    {
        public string Greetings(string address)
        {
            return address;
        }
    }
}