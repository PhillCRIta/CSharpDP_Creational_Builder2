/*
 The Builder pattern provide a method to create step by an object
 provide flexibility and clarity about the building process
 */
internal class CarBAD
{
	private CarType sPORT;
	private Engine engine;
	private readonly bool convertible;

	public int Fuel { get; set; }
	public CarBAD(CarType sPORT, Engine engine, bool convertible)
	{
		this.sPORT = sPORT;
		this.engine = engine;
		this.convertible = convertible;
	}
}