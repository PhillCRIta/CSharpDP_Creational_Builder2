using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	internal class CarManualBuilder : IBuilder<Manual>
	{
		private Manual _manual;

		public CarManualBuilder()
		{
			Reset();
		}
		public Manual Build()
		{
			return _manual;
		}
		public Manual BuildAndReset()
		{
			var manual = _manual;
			Reset();
			return manual;
		}
		public void Reset()
		{
			var manual = _manual;
		}
		public IBuilder<Manual> IsConvertible(bool isConvertible)
		{
			_manual.convertible = isConvertible;
			return this;
		}
		public IBuilder<Manual> SetCarType(CarType carType)
		{
			_manual.type = carType;
			return this;
		}
		public IBuilder<Manual> SetEngine(Engine engine)
		{
			_manual.engine = engine;
			return this;
		}
		//public Manual GetManual()
		//{
		//	var manual = _manual;
		//	Reset();
		//	return manual;
		//}


	}
}
