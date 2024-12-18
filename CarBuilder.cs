using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder2
{
	internal class CarBuilder : IBuilder<Car>
	{
		private Car _car;

		public CarBuilder()
		{
			Reset();
		}
		public Car Build()
		{
			return _car;
		}
		public Car BuildAndReset()
		{
			var car = _car;
			Reset();
			return car;
		}
		public void Reset()
		{
			_car = new Car();
		}
		public IBuilder<Car> IsConvertible(bool isConvertible)
		{
			_car.convertible = isConvertible;
			return this;
		}
		public IBuilder<Car> SetCarType(CarType carType)
		{
			_car.type = carType;
			return this; 
		}
		public IBuilder<Car> SetEngine(Engine engine)
		{
			_car.engine = engine;
			return this;
		}
	}
}
