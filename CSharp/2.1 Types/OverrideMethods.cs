using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    public class OverrideMethods
    {
        public static void Run()
        {

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
