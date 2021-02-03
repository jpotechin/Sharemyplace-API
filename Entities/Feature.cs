using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
	public class Feature
	{
		// [Key]
		public string Id {get; set;}
		public string Amenity { get; set; }
		public Location Location { get; set; }
		public int LocationId { get; set; }
	}
}