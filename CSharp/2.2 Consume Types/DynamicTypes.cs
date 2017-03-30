using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace CSharp
{
    class DynamicTypes
    {
        public static void UseDynamicClass()
        {

            //dynamic helps when working with legacy code and COM applications such as office

            //Create a dyncamic object removes compile time checking
            dynamic legacy = LegacyClass.Create();

            //Try write the firstname property
            Console.WriteLine(legacy.FirstName);

            //We can also write a property that does not exists.
            //No complile time error is generated but a run time error will occur
            //  Console.WriteLine(legacy.SpaceMan);

            //Call method
            legacy.DoWork();

            //Call no exist method will throw run time error
            //legacy.Break();
        }

        public static void UseExpandoObject()
        {
            //Expand object is sealed which enables you to get and set properties on the object
            //This is how ViewBag is created in MVC

            dynamic dyn = new ExpandoObject();
            dyn.FirstName = "Karl";
            dyn.Count = 0;

            //Not pasing Action here as a method
            dyn.Add = (Action)(() => { dyn.Count++; });

            dyn.Add();
            Console.WriteLine(dyn.Count);
        }
    }

    /// <summary>
    /// DynamicObject can be inherited.
    /// </summary>
    public class MyDynamic : DynamicObject
    {
        // The inner dictionary.
        Dictionary<string, object> dictionary
            = new Dictionary<string, object>();

        // This property returns the number of elements
        // in the inner dictionary.
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        // If you try to get a value of a property 
        // not defined in the class, this method is called.
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            // Converting the property name to lowercase
            // so that property names become case-insensitive.
            string name = binder.Name.ToLower();

            // If the property name is found in a dictionary,
            // set the result parameter to the property value and return true.
            // Otherwise, return false.
            return dictionary.TryGetValue(name, out result);
        }

        // If you try to set a value of a property that is
        // not defined in the class, this method is called.
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            // Converting the property name to lowercase
            // so that property names become case-insensitive.
            dictionary[binder.Name.ToLower()] = value;

            // You can always add a value to a dictionary,
            // so this method always returns true.
            return true;
        }
    }

    public class LegacyClass
    {
        public string FirstName { get; set; }

        public static LegacyClass Create()
        {
            return new LegacyClass() { FirstName = "Karl" };
        }

        public void DoWork()
        {
            Console.WriteLine("doing work....");
        }
    }
}
