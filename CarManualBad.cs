/*
 The Builder pattern provide a method to create step by an object
 provide flexibility and clarity about the building process
 */

internal class CarManualBad
{
	private CarType sPORT;
	private Engine engine;
	private readonly bool convertible;

	public CarManualBad(CarType sPORT, Engine engine, bool convertible)
	{
		this.sPORT = sPORT;
		this.engine = engine;
		this.convertible = convertible;
	}

	internal void Print()
	{
		Console.WriteLine("I'm printing the manual of car: " + sPORT);
	}
}