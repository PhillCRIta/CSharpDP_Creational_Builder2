using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	internal interface IBuilder<T>
	{
		void Reset();//builder function
		T Build();
		T BuildAndReset();
		IBuilder<T> SetCarType(CarType carType);
		IBuilder<T> IsConvertible(bool isConvertible);
		IBuilder<T> SetEngine(Engine engine);

	}
}
