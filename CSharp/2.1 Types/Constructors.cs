using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    class Constructors
    {
        public static void Run()
        {
            var animal = new Animal(5);
            var bear = new Bear("Brown", 10);
            var cub = new Cub(1);
        }
    }

    public class Animal
    {
        private int _Size { get; set; }
        public Animal(int size)
        {
            _Size = size;
        }
    }

    public class Bear : Animal
    {
        private string _Color { get; set; }

        public Bear(string color, int size) : base(size)
        {
            _Color = color;
        }
    }

    public class Cub : Bear
    {
        private int _Age { get; set; }

        public Cub(int age) : base("light brown", 1)
        {
            _Age = age;
        }
    }

    public class Dog
    {
        private string _Color { get; set; }

        //Basic constructor
        public Dog(string color)
        {
            _Color = color;
        }
    }

    public class Cat
    {
        private string _Color { get; set; }

        //Inline constructor
        public Cat(string color) => _Color = color;

    }

    public class Sheep
    {
        private string _Color { get; set; }

        //Private constructor cannot be called forces the class into the pattern
        //All sheeps are white.
        private Sheep()
        {
            _Color = "White";
        }
    }
}
