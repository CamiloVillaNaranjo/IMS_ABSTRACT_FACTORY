using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderModeling.BuilderScenario
{
    /// <summary>
    /// The 'Builder' Abstract Class
    /// </summary>
	public abstract class VehicleBuilder
	{
		protected Vehicle vehicle;
        
        //get vehicle instance
		public Vehicle Vehicle
		{
			get { return vehicle;}
		}

        //Abstract Build methods
		public abstract void BuildFrame();
		public abstract void BuildEngine();
		public abstract void BuildWheels();
		public abstract void BuildDoors();
	}
}
