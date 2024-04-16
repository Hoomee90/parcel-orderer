using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelOrder.Models;

namespace ParcelOrder.Tests
{
	[TestClass]
	public class ClassNameTests
	{
		public void ParcelConstructor_CreateInstanceOfParcel_Parcel()
		{
			Parcel newParcel = new(new[] {1, 1, 1});
			Assert.AreEqual(typeof(Parcel), newParcel.GetType());
		}
		
		[TestMethod]
		public void GetDimensions_ReturnsDimensions_IntArray()
		{
			int[] dimensions = {3, 5, 7};
			Parcel newParcel = new(dimensions);
			int[] result = newParcel.Dimensions;
			CollectionAssert.AreEqual(dimensions, result);
		}
		
		[TestMethod]
		public void SetDimensions_SetsValueOfDimensions_Void()
		{
			Parcel newParcel = new(new[] {3, 5, 7});
			int[] newDimensions = {4, 13, 9};
			newParcel.Dimensions = newDimensions;
			CollectionAssert.AreEqual(newDimensions, newParcel.Dimensions);
		}
	}
}