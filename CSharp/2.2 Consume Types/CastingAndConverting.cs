using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CastingAndConverting
    {
        static void ConfirmConvertIsvalid()
        {
            //Is operator returns true if the conversion is allowed
            MemoryStream ms = new MemoryStream();
            Console.WriteLine(ms is Stream);

            if (ms is Stream)
            {
                //Can be cast to steam
            }

            //As operator returns the converted value as value or null

            MemoryStream ms2 = ms as MemoryStream;
            if (ms2 != null)
            {
                //Is  stream
            }

            //Both is and AS can be used on nullable types

        }

        static void ConvertAndParse()
        {
            //Here we convert values type is string to int, int to double
            //This is the slower way to do it.
            int p = Convert.ToInt32("1");

            //Int.parse is faster
            int i = Int32.Parse("1");

            //Old parse with
            int y;
            if (Int32.TryParse("1", out y))
            {
                //use y here
            }

            //Try parse in one single line
            if (int.TryParse("1", out int z))
            {
                //Is int
                var local = z;
            }

        }

        static void BitConvertor()
        {
            //Covert to bytes
            int value = 12345678;

            byte[] bytes = BitConverter.GetBytes(value);

            Console.WriteLine(BitConverter.ToString(bytes));

            //Converts bytes to int
            Console.WriteLine(BitConverter.ToInt32(bytes, 0));
        }

        static void UserDefinedConversions()
        {
            //User defined conversions can be defined in a class to convert it to a particular type
            Money m = new Money(42.42M);
            int amount = m;
        }

        static void ImplicitConversion()
        {
            //implicet , there is no loss or precision
            int i = 43;
            double d = i;

            //Implicet conversion of an object to is base types or interface
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d2 = client;
        }

        static void ExplicitConversion()
        {
            //Also called casting
            double d = 12.123;
            //Cast is explicet, we haev lost precsion here
            int x = (int)d;

            //Explicet asting a base type to derieved type;
            Object stream = new MemoryStream();
            MemoryStream m = (MemoryStream)stream;
        }
    }

    /// <summary>
    /// Adding explicit and explicit casting to class
    /// </summary>
    class Money
    {
        public Money(decimal amount)
        {
            Amount = amount;
        }
        public Decimal Amount { get; set; }

        public static explicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static implicit operator int(Money money)
        {
            return (int)money.Amount;
        }

    }
}
