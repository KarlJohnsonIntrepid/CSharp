using static System.Math;

namespace CSharp.CSharp6Features
{
	/// <summary>
	/// Here we only import the static methods of a class
	/// </summary>
	public class StaticImport
	{

		public void UseStaticMethod()
		{
			var result = Sqrt(9);

			//The compiler will convert this to System.Math.Sqrt(9);
		}
		
	}
}
