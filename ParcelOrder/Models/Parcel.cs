using System;
using System.Linq;
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
		
		public int Volume()
		{
			return Dimensions.Aggregate((x, y) => x * y);
		}
		
		public int CostToShip()
		{
			double weightFactor = Math.Sqrt(Weight);
			double volumeFactor = Math.Sqrt(Volume());
			
			return (int)Math.Ceiling(Math.Pow(weightFactor + volumeFactor, 2));
		}
	}
}