using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	
	internal class Test1
	{
		private string str = "";

		public Test1(string str)
		{
			this.str = str;
		}

		public void SetStr(string str)
		{
			this.str = str;
		}
	}
}
