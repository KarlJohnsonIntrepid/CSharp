using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class BoxingAndUnboxing
    {
        static void BoxingWithGetType()
        {
            int d = 2;

            //Automatically boxes
            Type t = d.GetType();

            //Does not box
            TypeCode t2 = d.GetTypeCode();
        }

        static void GenericListwithnoBoxing()
        {
            //uses generics so no boxing at all.
            var list = new List<int>();
            list.Add(10);
            int y = (int)list[0];
        }

        static void SlowBoxingAndUnboxing()
        {
            //Passing value type to any non generic collection
            var list = new ArrayList();

            //Boxing
            list.Add(10);

            //Unboxing
            int y = (int)list[0];
        }

        static void InvalidUnbox()
        {
            double d = 2.333333333;
            object d2 = d;

            //Tryes to uunbox a double object to integer - throws InvalidCastException
            int i = (int)d2;
            var s = 2;
        }

        static void BoxInteger()
        {
            //Int is now a value type
            int i = 34;

            //Boxing puts the int in a object on the heap and the reference to it is stored on the stack
            object z = i;

            //Unboxing - object is cast a value type and moved to the stack
            int x = (int)z;

            Console.WriteLine(z.ToString());
        }
    }
}
