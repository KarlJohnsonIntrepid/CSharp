using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    public class Enums
    {

        public static void Run()
        {

            Gender m = Gender.Male;

            if(m == Gender.Male)
            {
                Console.WriteLine(Gender.Male);
            }

            //Find the underlying type of the enum
            Type type = Enum.GetUnderlyingType(typeof(Days));
            Console.WriteLine(type);

            //I cant assign null to the enum
            // Gender g = null;

            //use the special constant None instead.
            Gender g = Gender.None;


            //Enum built in methods
            Console.WriteLine(Enum.GetName(typeof(Gender), Gender.None));
            Console.WriteLine(String.Join(",", Enum.GetNames(typeof(Gender))));
        }
    }

    public enum Gender
    {
        None,
        Male = 1,
        Female,
        Other
    }

    //Here we are changing the underlying type
    //By default this is int, we change this now to byte
    //This makes classes smaller and more efficent but is restrieced to 256 values.
    enum Days : byte
    {
        Sat,
        Sun,
        Mon, 
        Tue, 
        Wed,
        Thurs,
        Fri
    }

    [Flags]
    enum DaysFull
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40

    }
}
