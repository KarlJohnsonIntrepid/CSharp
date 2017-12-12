using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharp._2._4_Class_Hierachy;
using Microsoft.SqlServer.Server;

namespace CSharp.CSharp6Features
{
	public class NullConditionals
	{
		public void Test()
		{
			var c = new Cat();

			var lives = c.Lives?.Count;

			//Use with null coalesce operator to return 0 instead of null

			lives = c.Lives?.Count ?? "0";

		}

	public class Cat
	{
		public Lives Lives { get; set; }
	}

	public class Lives
	{
		public string Count { get; set; }
	}
}
