namespace API.Entities
{
	public class Location
	{
		public int StreetNumber { get; set; }
		public string StreetName { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int Zipcode { get; set; }
		public string Description { get; set; }
		public string[] Features { get; set; }
		public int[] Price { get; set; }
	}
}