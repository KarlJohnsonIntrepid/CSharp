using System;

namespace CSharp._2._1_Types
{
    public class OverrideMethods
    {
        public static void Run()
        {

            var book = new Book();
            book.Stop();

            PaperBack book2 = new PaperBack();
            book2.Stop();

            //Here the object is a paperback 
            //But we are getting the book implementation
            //As we are using method hiding
            //This should be avoided
            Book book3 = new PaperBack();
            book3.Stop();
        }
    }

    public class Book
    {
        public int PageNumber { get; set; }

        public Book()
        {
            PageNumber = 1;
        }

        //Use the virtual keyword to make the method overridable
        public virtual void TurnPage()
        {
            PageNumber++;
        }

        public void Stop()
        {
            Console.WriteLine("stop base");
        }
    }

    /// <summary>
    /// Use the sealed key word to stop inheritance on the class
    /// </summary>
    public class PaperBack : Book
    {
        public int Damage { get; set; }

        public PaperBack()
        {
            Damage = 1;
        }

        /// <summary>
        /// Her we cant use overide as base does not have virtual
        /// Using keyword new is method Hiding
        /// </summary>
        public new void Stop()
        {
            Console.WriteLine("stop derived");
        }

        //Use the override key word to turn the page;
        public sealed override void TurnPage()
        {
            Damage++;
            base.TurnPage();
        }

        /// <summary>
        public override string ToString()
        {
           Console.WriteLine("Paperback");
           return "PaperBack";
        }
    }

    /// <summary>
    /// The sealed  key word has made this a concrete subclass
    /// </summary>
    public sealed class SpecialPaperBack : PaperBack
    {
        //We now cannot overide this method as it is sealed in the super class

        //public override void TurnPage()
        //{

        //}
    }

    //We cannot implement Special paperback as it is sealed
    //public class SealedTest : SpecialPaperBack
    //{

    //}
}
