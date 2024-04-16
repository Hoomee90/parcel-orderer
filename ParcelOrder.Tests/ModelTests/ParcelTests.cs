using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelOrder.Models;

namespace ParcelOrder.Tests
{
	[TestClass]
	public class ClassNameTests
	{
		[TestMethod]
		public void ParcelConstructor_CreateInstanceOfParcel_Parcel()
		{
			Parcel newParcel = new(new[] {1, 1, 1}, 1);
			Assert.AreEqual(typeof(Parcel), newParcel.GetType());
		}
		
		[TestMethod]
		public void GetDimensions_ReturnsDimensions_IntArray()
		{
			int[] dimensions = {3, 5, 7};
			Parcel newParcel = new(dimensions, 1);
			int[] result = newParcel.Dimensions;
			CollectionAssert.AreEqual(dimensions, result);
		}
		
		[TestMethod]
		public void SetDimensions_SetsValueOfDimensions_Void()
		{
			Parcel newParcel = new(new[] {3, 5, 7}, 1);
			int[] newDimensions = {4, 13, 9};
			newParcel.Dimensions = newDimensions;
			CollectionAssert.AreEqual(newDimensions, newParcel.Dimensions);
		}
		
		[TestMethod]
		public void GetWeight_ReturnsWeight_Int()
		{
			int weight = 3;
			Parcel newParcel = new(new [] {1, 1, 1}, weight);
			int result = newParcel.Weight;
			Assert.AreEqual(weight, result);
		}
		
		[TestMethod]
		public void SetWeight_SetsValueOfWeight_Void()
		{
			Parcel newParcel = new(new [] {1, 1, 1}, 3);
			int newWeight = 6;
			newParcel.Weight = newWeight;
			Assert.AreEqual(newWeight, newParcel.Weight);
		}
		
		[TestMethod]
		public void Volume_CorrectlyCalculatesVolume_Int()
		{
			Parcel newParcel = new(new [] {3, 2, 10}, 3);
			int expected = 60;
			Assert.AreEqual(expected, newParcel.Volume());
		}
		
		[TestMethod]
		public void CostToShip_CorrectlyCalculatesCostToShip_Int()
		{
			Parcel newParcel = new(new [] {3, 2, 6}, 16);
			int expected = 100;
			Assert.AreEqual(expected, newParcel.CostToShip());
		}
	}
}