using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._3_Encapsulation
{
    class ExplictInterfaceImplementation
    {
        public static void Run()
        {
            Implementation i = new Implementation();
            //I can only use
            i.MyMethodNormal();

            //I cant use the explicit implementaiton of the interface
            // i.MyMethodExplicit();

            //I must use the interface to find explicit methods
            var intface =  (IInterfaceA)i;
            intface.MyMethodExplicit();

            //This can be used to hide internal methods within the class

        }
    }

    class Implementation : IInterfaceA
    {
        ////This Method is implemented explicitly
        ////NOte the IInterfaceA. before the method signiture
        ////This method cannot be implemented by the class
        void IInterfaceA.MyMethodExplicit()
        {
            Console.WriteLine("Explicit");
        }

        //Note: this must be public
        public void MyMethodNormal()
        {
            Console.WriteLine("Normal");
        }

    }

    //Interface with two methods to implement
    interface IInterfaceA
    {
        void MyMethodExplicit();
        void MyMethodNormal();
    }

}
