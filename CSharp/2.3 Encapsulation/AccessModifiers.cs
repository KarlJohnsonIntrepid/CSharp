using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._3_Encapsulation
{

    class AccessModifiers
    {

        //If you want to expose internal propertys to another assembly you can set this in the properties folder (Add to AssemblyInfo)
        // [assembly:InternalsVisibleTo("MyAssemblyName)]

        //Enum and Interface always have public Modifiers

        //Struct is limited to public, internal, private
   }



    //If no access modifier is set the class internal (only available in the current assembly)
    //Else we can use public modifer or internal explicitly

    internal class ClassModifiers
    {

       //1.Only nested classes can be declared private, protcted, interal or 
        private class Bike
        {

        }

        /// <summary>
        /// Lmited to the containing class and derived types
        /// </summary>
        protected class Boat
        {
            //Note that this method is essentialy protected as the outer class is protected
            public void Float()
            {
                Console.WriteLine("float");
            }
        }

        /// <summary>
        /// Limited to the current assembly
        /// </summary>
        internal class Plane
        {

        }
        /// <summary>
        /// Limited to the current assembly or derived types
        /// </summary>
        protected internal class Spaceship
        {

        }
    }
}




