using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp6Features
{
	public class StringInterpolation
	{
		public void TestStringInterpolation()
		{
			//Declare
			var p = new Person();
			var output = p.ToString();
		}
	}

	public class Person
	{	public string Name { get; set; }
		public int Age { get; set; }

		public override string ToString()
		{
			return $"The person is called {Name}, they are {Age:D3} year {(Age == 1 ? "" : "s")} old";
		}
	}
}
