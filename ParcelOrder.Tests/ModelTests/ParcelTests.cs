using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ParcelOrder.Models;

namespace ParcelOrder.Tests
{
	[TestClass]
	public class ParcelTests : IDisposable 
	{
		public void Dispose()
		{
			Parcel.ClearAll();
		}
		
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
			int expected = 24;
			Assert.AreEqual(expected, newParcel.CostToShip());
		}
		
		[TestMethod]
		public void GetAll_ReturnsAllParcelInstances_List()
		{
			Parcel parcel1 = new(new[] {2, 2, 9}, 12);
			Parcel parcel2 = new(new[] {21, 3, 9}, 30);
			Parcel parcel3 = new(new[] {1, 3, 9}, 100);
			List<Parcel> expected = new List<Parcel> { parcel1, parcel2, parcel3 };
			List<Parcel> actualResult = Parcel.GetAll();
			CollectionAssert.AreEqual(expected, actualResult);
		}
		
		[TestMethod]
		public void ClearAll_DeletesAllParcelInList_Void()
		{
			_ = new Parcel(new[] {2, 2, 9}, 12);
			_ = new Parcel(new[] {21, 3, 9}, 30);
			_ = new Parcel(new[] {1, 3, 9}, 100);
			List<Parcel> expected = new() { };
			Parcel.ClearAll();
			CollectionAssert.AreEqual(expected, Parcel.GetAll());
		}
	}
}