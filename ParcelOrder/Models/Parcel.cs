using Microsoft.AspNetCore.Http.Features;

namespace ParcelOrder.Models
{
	public class Parcel
	{
		public int[] Dimensions { get; set; }
		public int Weight { get; set; }
		
		public Parcel(int[] dimensions, int weight)
		{
			Dimensions = dimensions;
			Weight = weight;
		}
	}
}