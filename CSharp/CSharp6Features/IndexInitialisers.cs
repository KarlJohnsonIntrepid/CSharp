using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp6Features
{
	class IndexInitialisers
	{
		public void Load()
		{

			//you can now load any positon in a collection
			var numbers = new List<int>
			{
				[1] = 11,
				[3] = 12
			};

		}
	}
}
