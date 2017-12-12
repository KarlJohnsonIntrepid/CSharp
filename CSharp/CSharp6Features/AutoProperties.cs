using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp6Features
{
	public class AutoProperties
	{
		/// <summary>
		/// We can now declare the initial value of an auto property 
		/// </summary>
		public string MyFirstInitialisedAutoProperty { get; set; } = "Woo Hoo";

		/// <summary>
		/// we can do the same with a  read only auto property
		/// </summary>
		public string MyFirstReadOnlyAutoProperty { get; } = "Read Only!";

		/// <summary>
		/// Expression bodies can be used instead of a get
		/// </summary>
		/// <returns></returns>
		public string MyFirstExpressionBodyMethod() => "I Love C Charp";

		/// <summary>
		/// This is a candidate for an expression body
		/// </summary>
		public string MySecondExpressionBodyMethod
		{
			get { return "This COuld be an Expression Body method"; }
		}

		/// <summary>
		/// Exprssion body is usefull for concatanting properties
		/// </summary>
		public string ExBodyConcatProperties => MyFirstInitialisedAutoProperty + MySecondExpressionBodyMethod;


	}
}
