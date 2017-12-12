using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CSharp6Features
{
	public class ExceptionFilters
	{
		public void Load()
		{
			try
			{
				var s = 0/1;
			}
			catch (Exception ex) when (ex.Message.Contains("Error"))
			{

			}
			catch (Exception ex)
			{
				
			}
		}
	}
}
