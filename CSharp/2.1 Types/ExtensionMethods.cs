using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    public class ExtensionMethods
    {
        public static void Run()
        {
            String str = "String";
            str.WriteToConsole();

            var dog = new DogExtension();
            dog.Run();

            ///Note that jump is not implemented on the dog class but the IAnimal interface
            dog.Jump();

            //Now all animals can jump by extending the interface
            var cat = new CatExtension();
            cat.Jump();
        }
    }

    /// <summary>
    /// This extension class must be public, static and non generic
    /// </summary>
    public static class MyExtensions
    {
      //Method must be static
      //this is what declares it as an extension
        public static void WriteToConsole(this String str)
        {
            Console.WriteLine(str);
        }

        //Here we extend the interface IAnimal
        public static void Jump(this IAnimal str)
        {
            Console.WriteLine(str);
        }
    }

    public interface IAnimal
    {
        void Run();
    }

    public class AnimalExtension : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("Running....");
        }
    }


    public class DogExtension :AnimalExtension
    {

    }


    public class CatExtension : AnimalExtension
    {

    }
}
