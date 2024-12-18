using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	internal class Car
	{
		public CarType type { get; set; }
		public Engine engine { get; set; }
		public bool convertible { get; set; }
		public override string ToString()
		{
			return $"The car has type: {type}, engine: {engine}, convertible: {convertible}";
		}
	}
}
