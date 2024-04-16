using Microsoft.AspNetCore.Http.Features;

namespace ParcelOrder.Models
{
	public class Parcel
	{
		public int[] Dimensions { get; set; }
		
		public Parcel(int[] dimensions)
		{
			Dimensions = dimensions;
		}
	}
}