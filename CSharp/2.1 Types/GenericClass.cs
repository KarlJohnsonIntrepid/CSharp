using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    public class GenericClass
    {
        public static void Run()
        {
            //Now use our generic type

            var g = new Generic<string>("Karl");
            g.Write();

            var g2 = new Generic<int>(5);
            g2.Write();

            //Create our generic array

            var intArray = new GenericArray<int>(10);
            intArray.SetItem(0, 22);
            int item = intArray.GetItem(0);
            Console.WriteLine(item);

            var strArray = new GenericArray<string>(10);
            strArray.SetItem(0, "test");

            Console.WriteLine(strArray.GetItem(0));
        }
    }

    /// <summary>
    /// Class to make a generic array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericArray<T>
    {
        //Create an  array of type T
        private T[] _Array { get; set; }

        public GenericArray(int size)
        {
            _Array = new T[size];
        }

        public T GetItem(int index)
        {
            return _Array[index];
        }

        public void SetItem(int index, T item)
        {
            _Array[index] = item;
        }
    }

    class Generic<T>
    {
        T _value;

        public Generic(T t)
        {
            _value = t;
        }

        public void Write()
        {
            Console.WriteLine(_value);
        }
    }
}
