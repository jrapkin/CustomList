using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTestCases
{
	[TestClass]
	public class CustomList
	{
		[TestMethod]
		//Tests for the creation of array/ to see if the capacity of the created array is correct for the programmed default
		public void Create_ArrayOfValues_ReturnCapacity()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expectedCapacity = 4;

			//act
			int actualCapacity = aCustomList.Capacity;
			//assert
			Assert.AreEqual(expectedCapacity, actualCapacity);


		}
		//Tests to make sure that the returned default value of the array is of the correct data type

		/// <summary>
		/// Tests for the Add Method
		/// </summary>
		//Tests to make sure an array is created when a new list is created

		//Tests to make sure that the list is incrementing the count as new elements get added to the list
		[TestMethod]
		public void Add_OneValue_IncrementCountOfList()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;

			//act
			aCustomList.Add(expected);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}
		//Tests to make sure that the index of the element added is correct when one value is added to the list
		[TestMethod]
		public void Add_OneValue_ReturnValueAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 10;

			//act
			aCustomList.Add(expected);

			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
		//Tests to make sure that the index of the element in index position two is correct when multiple elements are added to the list
		[TestMethod]
		public void Add_TwoValues_ReturnElementAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 15;
			int firstElement = 10;
			int secondElement = 15;

			//act
			aCustomList.Add(firstElement);
			aCustomList.Add(secondElement);

			//Assert
			Assert.AreEqual(expected, aCustomList[1]);
		}
		//Tests to make sure that the index of the element in index position two is correct when multiple elements are added to the list
		[TestMethod]
		public void Add_ThreeValues_CheckCapacityIsFour()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 4;
			int elementOne = 10;
			int elementTwo = 15;
			int elementThree = 20;

			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);

			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}
		[TestMethod]
		public void Add_SixValues_CheckCapacityIsEight()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 8;
			int elementOne = 1;
			int elementTwo = 2;
			int elementThree = 3;
			int elementFour = 4;
			int elementFive = 5;
			int elementSix = 6;

			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);
			aCustomList.Add(elementFour);
			aCustomList.Add(elementFive);
			aCustomList.Add(elementSix);


			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}

		//[testmethod]
		//public void add_checkifexceedingcapacity_createnewarray()
		//{

		//}
		////tests to make sure that the array and its elements at each index are properly copied to a new, larger array
		//[testmethod]
		//public void add_elementsoverdefaultarraysize_copyarraytonewarray()
		//{
		//	//arrange
		//	customlist<int> acustomlist = new customlist<int>();
		//	int expected = 5;
		//	int elementone = 1;
		//	int elementtwo = 2;
		//	int elementthree = 3;
		//	int elementfour = 4;
		//	int elementfive = 5;
		//	//act
		//	acustomlist.add(elementone);
		//	acustomlist.add(elementtwo);
		//	acustomlist.add(elementthree);
		//	acustomlist.add(elementfour);
		//	acustomlist.add(elementfive);

		//	//assert
		//	assert.areequal(expected, acustomlist[4]);

		//}






	}
}
