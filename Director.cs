using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	internal class Director
	{
		public void ConstructSportCar(IBuilder<Car> builder)
		{
			builder.SetCarType(CarType.SPORT).SetEngine(new Engine()).IsConvertible(true);
		}
		public void ConstructSUVCar(IBuilder<Car> builder)
		{
			builder.SetCarType(CarType.SUV).SetEngine(new Engine()).IsConvertible(false);
		}

		public void TransT(ref Test1 t)
		{
			t.SetStr("ciao");
		}
		public void TransI(ref int v)
		{
			v = 10;
		}
	}
}
