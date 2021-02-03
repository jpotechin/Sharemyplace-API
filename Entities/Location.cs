using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
	[Table("Location")]
	public class Location
	{
		// [Key]
		public string Id {get; set;}
		public string StreetNumber { get; set; }
		public string StreetName { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zipcode { get; set; }
		public string Description { get; set; }
		public IEnumerable<string> Features { get; set; }
		public bool IsFurnished {get; set;}
		public string MinPrice { get; set; }
		public string MaxPrice {get; set;}
		public AppUser AppUser { get; set; }
		public int AppUserId { get; set; }

	}
}