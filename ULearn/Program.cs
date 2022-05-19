using System;

namespace Test1
{
	public class GeoLocation
	{
		public double Latitude;
		public double Longitude;
	}
	public class City
	{
		public string Name;
		public GeoLocation Location;
	}

	public class Program
	{
		static void Main()
		{
			var city = new City();
			city.Name = "Ekaterinburg";
			city.Location = new GeoLocation();
			city.Location.Latitude = 56.50;
			city.Location.Longitude = 60.35;
			Console.WriteLine("I love {0} located at ({1}, {2})",
				city.Name,
				Convert.ToString(city.Location.Longitude),
				Convert.ToString(city.Location.Latitude));
		}
	}
}
