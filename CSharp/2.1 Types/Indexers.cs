using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    public class Indexers
    {
        public static void Run()
        {
            var dogs = new MyDogs<string>();

            dogs[0] = "Bruce";
            dogs[1] = "Buster";

            Console.Write(dogs[0]);
            Console.Write(dogs[1]);

            var myCats = new MyCats();
            myCats[0] = "Bob";
            myCats[1] = "Joe";

            Console.WriteLine(myCats[0]);
        }
    }

    public class MyCats
    {
        string[] _Values = new string[100];

        /// <summary>
        /// Key word "this" is what we use to declare the indexer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string this[int i]
        {
            get
            {
                return _Values[i];
            }
            set
            {
                _Values[i] = value;
            }
        }
    }

    //Generic class with index
    public class MyDogs<T>
    {
        //My array 
        private T[] arr = new T[1000];


        //To declare the indexer use the key word this
        public T this[int index]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }


}
