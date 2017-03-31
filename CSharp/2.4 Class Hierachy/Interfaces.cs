using CSharp._2._1_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._4_Class_Hierachy
{
    public class Interfaces
    {
        static void Run()
        {
            //You cant instaticate an interface
            // IAnimal animal = new IAnimal();

            //But you can create a concrete class which implements an interface
            IAnimal animal = new Dog();

            //I can however call bark as its not part of the interface
            //animal.Bark();

            //To call bark you need to cast it
            var dog = (Dog)animal;
            dog.Bark();

            //NOTE: multiple interface inheritance is supported, but multiple class inheritance is not

        }

        //Pass in interface as parameter to work with all implementations
        //Programming against a contract
        void MoveAnimimal(IAnimal animal)
        {
            animal.Move();
        }
    }


    interface IAnimal
    {
        void Move();
    }
    class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }

    /// <summary>
    /// Example interface with the types which can be declared
    /// </summary>
    public interface IExample
    {
        //Declare a method
        //Notice that the modifier can not be added
        string MyMethod();

        //Declare a property
        int myInt { get; set; }

        //Declare an Event
        event EventHandler ResultRetireved;

        //Declare an indexer
        int this[string index] { get; set; }

    }

    public class ImplementInterface : IExample
    {
        public event EventHandler ResultRetireved;

        public string MyMethod()
        {
            return "Something";
        }

        public int myInt { get; set; }

        public int this[string index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

    }

    public interface IGetAccessor
    {
        //Property with only a get
        int Get { get; }
    }

    public class GetAccessorImplementation : IGetAccessor
    {
        //Note that in the class implementation we can also add a set property
        public int Get
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    //Generic Repository to be shared between type of different class
    interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> All();
    }

    //concrete implementation of generic repository
    //concrete class is just a normal class that does not contain abstract methods.
    class DogRepository : IRepository<Dog>
    {
        public IEnumerable<Dog> All()
        {
            throw new NotImplementedException();
        }

        public Dog Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    sealed class CatRepository : IRepository<Cat>
    {
        public IEnumerable<Cat> All()
        {
            throw new NotImplementedException();
        }

        public Cat Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
