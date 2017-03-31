using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._4_Class_Hierachy
{
    class AbstractClasses
    {
        //Abstract class is a class that cannot be instatiated, you cant use the new operator on it.
        //You can have code implementation for members but it.

        //the oppposite to an abstract class is a sealed class
        //You should mark your class as sealed so that others dont override it without you thinking about it first

    }


    abstract class MyBase
    {
        //method with implementation
        //use the virtual key word to make overidable
        public virtual void Run()
        {
            Console.WriteLine("Running");
        }

        /// <summary>
        /// Method declared as abstract (this cannot be private as it must be implemented in a base class)
        /// </summary>
        public abstract void Jump();

        public abstract string GetName();
    }

    class Derived : MyBase
    {

        public void Run()
        {

        }

        //All methods must use the key word override to override the abstract method
       public override string GetName()
        {
            return "derived";
        }

        public override void Jump()
        {
            Console.WriteLine("teset'");
        }
    }
}
