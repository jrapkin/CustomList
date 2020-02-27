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

		//ADD METHOD TESTS
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


		//REMOVE METHOD TESTS
		[TestMethod]
		public void Remove_OneValue_DecrementCountOfList()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;
			int removeValue = 1;
			aCustomList.Add(1);
			aCustomList.Add(2);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}
		[TestMethod]
		public void Remove_OneValue_ReturnValueAtIndexZero()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;
			int removeValue = 2;
			aCustomList.Add(1);
			aCustomList.Add(2);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
		[TestMethod]
		public void Remove_TwoValues_ReturnValueAtIndexZero()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 3;
			int removeValueOne = 2;
			int removeValueTwo = 1;
			aCustomList.Add(1);
			aCustomList.Add(2);
			aCustomList.Add(3);
			//act
			aCustomList.Remove(removeValueOne);
			aCustomList.Remove(removeValueTwo);
			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
		[TestMethod]
		public void Remove_ValueAtIndiceZero_ReturnUpdatedIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 2;
			int removeValue = 1;
			aCustomList.Add(1);
			aCustomList.Add(2);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
		[TestMethod]
		public void Remove_ValueAtIndiceThree_ReturnUpdatedIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 3;
			int removeValue = 4;
			aCustomList.Add(1);
			aCustomList.Add(2);
			aCustomList.Add(3);
			aCustomList.Add(4);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList[2]);
		}
		[TestMethod]
		public void Remove_ValueAtIndiceFive_ReturnUpdatedIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 7;
			int removeValue = 6;
			aCustomList.Add(1);
			aCustomList.Add(2);
			aCustomList.Add(3);
			aCustomList.Add(4);
			aCustomList.Add(5);
			aCustomList.Add(6);
			aCustomList.Add(7);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList[5]);
		}
		[TestMethod]
		public void Remove_OneInstanceOfValue_RemoveFirstInstance()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 2;
			int removeValue = 1;
			aCustomList.Add(1);
			aCustomList.Add(2);
			aCustomList.Add(1);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
		[TestMethod]
		public void Remove_SomethingNotInList_CountStaysTheSame()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 2;
			int removeValue = 5;
			aCustomList.Add(1);
			aCustomList.Add(2);
			//act
			aCustomList.Remove(removeValue);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}

		//.TOSTRING TESTS
		[TestMethod]
		public void ToString_ConvertOneElement_OutputString()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			string expected = "25";
			string actual;
			aCustomList.Add(25);
			//act
			actual = aCustomList.ToString();
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void ToString_ConvertTwoElements_OutputString()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			string expected = "2537";
			string actual;
			aCustomList.Add(25);
			aCustomList.Add(37);
			//act
			actual = aCustomList.ToString();
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void ToString_ConvertTwoStrings_OutputStrings()
		{
			//arrange
			CustomList<string> aCustomList = new CustomList<string>();
			string expected = "Hi There";
			string actual;
			aCustomList.Add("Hi ");
			aCustomList.Add("There");
			//act
			actual = aCustomList.ToString();
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void ToString_ConvertThreeElementsInListOfDoubles_OutputString()
		{
			//arrange
			CustomList<double> aCustomList = new CustomList<double>();
			string expected = "0.250.120.15";
			string actual;
			aCustomList.Add(.25);
			aCustomList.Add(.12);
			aCustomList.Add(.15);
			//act
			actual = aCustomList.ToString();
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void ToString_ConvertADoubleElement_OutputString()
		{
			//arrange
			CustomList<double> aCustomList = new CustomList<double>();
			string expected = "0.25";
			string actual;
			aCustomList.Add(.25);
			//act
			actual = aCustomList.ToString();
			//assert
			Assert.AreEqual(expected, actual);
		}

		//+ OPERATOR TESTS
		[TestMethod]
		public void OperatorOverload_AddTwoLists_ReturnCombinedLists()
		{
			//arrange
			CustomList<int> listOfInts = new CustomList<int>();
			CustomList<int> secondListOfInts = new CustomList<int>();
			listOfInts.Add(1);
			listOfInts.Add(3);
			listOfInts.Add(5);
			secondListOfInts.Add(2);
			secondListOfInts.Add(4);
			secondListOfInts.Add(6);
			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 2, 4, 6 };
			//act
			result = listOfInts + secondListOfInts;
			//assert
			Assert.AreEqual(expected.ToString(), result.ToString());
		}
		[TestMethod]
		public void OperatorOverload_AddTwoLists_ReturnCount()
		{
			//arrange
			CustomList<int> listOfInts = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfInts = new CustomList<int>() { 2, 4, 6 };

			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 2, 4, 6 };
			//act
			result = listOfInts + secondListOfInts;
			//assert
			Assert.AreEqual(expected.Count, result.Count);
		}
		[TestMethod]
		public void OperatorOverload_AddTwoListOfStrings_ReturnCombinedListOfStrings()
		{
			CustomList<string> listOfStrings = new CustomList<string>();
			CustomList<string> secondListOfStrings = new CustomList<string>();
			listOfStrings.Add("one");
			listOfStrings.Add("three");
			listOfStrings.Add("five");
			secondListOfStrings.Add("two");
			secondListOfStrings.Add("four");
			secondListOfStrings.Add("six");
			CustomList<string> result;
			CustomList<string> expected = new CustomList<string>() { "one", "three", "five", "two", "four", "six" };
			//act
			result = listOfStrings + secondListOfStrings;
			//assert
			Assert.AreEqual(expected.ToString(), result.ToString());
		}
		[TestMethod]
		public void OperatorOverload_AddTwoListOfInts_Capacity()
		{
			CustomList<int> listOfStrings = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfStrings = new CustomList<int>() { 2, 4, 6 };
			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 3, 5, 2, 4, 6 };
			//act
			result = listOfStrings + secondListOfStrings;
			//assert
			Assert.AreEqual(expected.Capacity, result.Capacity);
		}
		// - OPERATOR TESTS
		[TestMethod]
		public void OperatorOverload_SubtractFromTwoListOfInts_ReturnCount()
		{
			//arrange
			CustomList<int> listOfInts = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfInts = new CustomList<int>() { 2, 3, 6 };

			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 5 };
			//act
			result = listOfInts - secondListOfInts;
			//assert
			Assert.AreEqual(expected.Count, result.Count);
		}
		[TestMethod]
		public void OperatorOverload_SubtractFromTwoListOfInts_Capacity()
		{
			CustomList<int> listOfStrings = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfStrings = new CustomList<int>() { 2, 3, 6 };
			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 5 };
			//act
			result = listOfStrings - secondListOfStrings;
			//assert
			Assert.AreEqual(expected.Capacity, result.Capacity);
		}
		[TestMethod]
		public void OperatorOverload_SubtractFromTwoListOfInts_ReturnResultingList()
		{
			CustomList<int> listOfStrings = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfStrings = new CustomList<int>() { 2, 3, 6 };
			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 5 };
			//act
			result = listOfStrings - secondListOfStrings;
			//assert
			Assert.AreEqual(expected.ToString(), result.ToString());
		}
		[TestMethod]
		public void OperatorOverload_SubtractFromTwoListOfInts_ReturnResultingListWithNoChange()
		{
			CustomList<int> listOfStrings = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondListOfStrings = new CustomList<int>() { 2, 4, 6 };
			CustomList<int> result;
			CustomList<int> expected = new CustomList<int>() { 1, 3, 5 };
			//act
			result = listOfStrings - secondListOfStrings;
			//assert
			Assert.AreEqual(expected.ToString(), result.ToString());
		}
		// ITERATOR TESTS
		[TestMethod]
		public void IEnumerable_ForEachElement_AddToSum()
		{
			//arrange
			CustomList<int> listOfInts = new CustomList<int>();
			int expected = 9;
			listOfInts.Add(3);
			listOfInts.Add(3);
			listOfInts.Add(3);
			int actual = 0;
			//act
			foreach (int item in listOfInts)
			{
				actual += item;
			}
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void IEnumerable_ElementsAddedDuringInstantiation_GetCount()
		{
			//arrange
			int expected = 5;
			//act
			CustomList<int> listOfInts = new CustomList<int>() { 0, 1, 2, 3, 4 };

			//assert
			Assert.AreEqual(expected, listOfInts.Count);
		}
		[TestMethod]
		public void IEnumerable_ElementsAddedDuringInstantiation_GetElementAtIndex()
		{
			//arrange
			int expected = 2;
			//act
			CustomList<int> listOfInts = new CustomList<int>() { 0, 1, 2, 3, 4 };

			//assert
			Assert.AreEqual(expected, listOfInts[2]);
		}
		[TestMethod]
		public void IEnumerable_ElementsAddedToListOfStrings_GetElementAtIndex()
		{
			//arrange

			string expected = "custom";
			//act
			CustomList<string> listOfInts = new CustomList<string>() { "I", "am", "a", "custom", "list" };

			//assert
			Assert.AreEqual(expected, listOfInts[3]);
		}
		[TestMethod]
		public void IEnumerable_ForEachElement_AddANumber()
		{
			//arrange
			CustomList<int> listOfInts = new CustomList<int>() { 0, 1, 2, 3, 4, 5 };
			string expected = "found it";
			CustomList<string> actual = new CustomList<string>();
			//act

			foreach (int item in listOfInts)
			{
				if (item == 2)
				{
					actual.Add("found it");

				}
			}
			//
			Assert.AreEqual(expected, actual[0]);

		}

		//ZIPPER TESTS
		[TestMethod]
		public void Zipper_AddTwoListOfInts_ReturnZipperedListOfInts()
		{
			//arrange
			CustomList<int> firstList = new CustomList<int>(){1, 3, 5};
			CustomList<int> secondList = new CustomList<int>(){2, 4, 6};
			CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
			CustomList<int> actual = new CustomList<int>();
			//act
			actual.Zipper(firstList, secondList);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void Zipper_AddTwoListOfInts_ReturnCount()
		{
			//arrange
			CustomList<int> firstList = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondList = new CustomList<int>() { 2, 4, 6 };
			CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
			CustomList<int> actual = new CustomList<int>();
			//act
			actual.Zipper(firstList, secondList);
			//assert
			Assert.AreEqual(expected.Count, actual.Count);
		}
		[TestMethod]
		public void Zipper_AddTwoListOfStrings_ReturnZipperedListOfStrings()
		{
			//arrange
			CustomList<string> firstList = new CustomList<string>() { "one", "three", "five"};
			CustomList<string> secondList = new CustomList<string>() { "two", "four", "six" };
			CustomList<string> expected = new CustomList<string>() { "one", "two", "three", "four", "five", "six" };
			CustomList<string> actual = new CustomList<string>();
			//act
			actual.Zipper(firstList, secondList);
			//assert
			Assert.AreEqual(expected.ToString(), actual.ToString());
		}
		[TestMethod]
		public void Zipper_AddTwoListOfInts_ReturnCapacity()
		{
			//arrange
			CustomList<int> firstList = new CustomList<int>() { 1, 3, 5 };
			CustomList<int> secondList = new CustomList<int>() { 2, 4, 6 };
			CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
			CustomList<int> actual = new CustomList<int>();
			//act
			actual.Zipper(firstList, secondList);
			//assert
			Assert.AreEqual(expected.Capacity, actual.Capacity);
		}

	}
}
