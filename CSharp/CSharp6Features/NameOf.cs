using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp6Features
{
	public class NameOf
	{
		public NameOf()
		{
			//Returns "TaskFactory"
			var s = nameof(TaskFactory);

			//var notAllowed = nameof(int);
		}
	}
}
