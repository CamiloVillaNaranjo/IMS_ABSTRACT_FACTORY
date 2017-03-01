namespace BuilderModeling.BuilderScenario
{
    /// <summary>
    /// The 'Director' Class
    /// </summary>
	public class Shop
	{
        // Builder uses a complex series of steps.
		public void Construct(VehicleBuilder vehicleBuilder)
		{
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
		}
	}
}
