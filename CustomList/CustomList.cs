using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T> : IEnumerable
	{
		//member variables
		private int count;
		private int arrayCapacity;

		private T[] arrayOfData;
		public IEnumerator GetEnumerator()
		{
			for (int index = 0; index < count; index++)
			{ yield return arrayOfData[index]; }
		}
		public T this[int index]
		{
			get
			{
				if (index >= count) { throw new ArgumentOutOfRangeException(); }
				else { return arrayOfData[index]; }
			}
			set
			{
				if (index >= count)
				{ throw new ArgumentOutOfRangeException(); }
				else
				{ arrayOfData[index] = value; }
			}
		}
		
		public int Count { get { return count; } }
		public int Capacity { get { return arrayCapacity; } }
		//ctor
		public CustomList()
		{
			count = 0;
			arrayCapacity = 4;
			arrayOfData = new T[arrayCapacity];
		}
		//member methods

		/// <summary>
		/// Adds an item to the collection in <typeparamref name=" CustomList"/> 
		/// </summary>
		/// <param name="element">
		/// A parameter must be passed in, but the parameter can be of any type. This method does not have a return type.
		/// </param>
		public void Add(T element)
		{
			if (IsOverCapacity() == true) 
			{ UpdateArray(); AddItemToArray(element); IncrementCount(); }
			else { AddItemToArray(element); IncrementCount(); }
		}
		private bool IsOverCapacity()
		{
			if ( count >= arrayCapacity ) { return true; }
			else { return false; }
		}
		private void UpdateArray()
		{
			T[] temporaryArray = new T[arrayCapacity * 2];
			for ( int i = 0; i < arrayCapacity; i++ )
			{ temporaryArray[i] = arrayOfData[i]; }
			arrayOfData = temporaryArray;
			arrayCapacity *= 2;
		}
		private void AddItemToArray(T element)
		{ arrayOfData[count] = element; }
		private void IncrementCount()
		{ count++; }

		//REMOVE METHOD FUNCTIONALITY
		/// <summary>
		/// Removes an item from the collection in <typeparamref name=" CustomList"/>.
		/// </summary>
		/// <param name="elementToRemove"></param>
		public void Remove(T elementToRemove)
		{ UpdateArray(elementToRemove); }
		private void UpdateArray(T assignedElement)
		{
			T[] temporaryArray = new T[arrayCapacity];
			int temporaryCount = count;
			bool removed = false;
			for (int i = 0, j = 0; i < temporaryCount; i++, j++)
			{
				if (assignedElement.Equals(arrayOfData[i]) && !removed)
				{
					j--;
					removed = true;
					count--;
				}
				else
				{
					temporaryArray[j] = arrayOfData[i];
				}
			}
			arrayOfData = temporaryArray;
		}

		public override string ToString()
		{
			StringBuilder newString = new StringBuilder();
			for (int i = 0; i < count; i++)
			{
				newString.Append(arrayOfData[i]);
			}

			return newString.ToString();
		}
		/// <summary>
		/// Operator overload for adding two list objects together. The parameters required are of Type CustomList<typeparamref name=" T"/>
		/// </summary>
		/// <param name="firstList"></param>
		/// <param name="secondList"></param>
		/// <returns> 
		/// returns a new list containing the elements of two custom lists.
		/// </returns>
		public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
		{
			CustomList<T> resultOfAddedLists = new CustomList<T>();
			foreach (T item in firstList) { resultOfAddedLists.Add(item); }
			foreach (T item in secondList) { resultOfAddedLists.Add(item); }
			return resultOfAddedLists;
		}
		/// <summary>
		/// Operator overload for removing the values of one list object from the other. When called, this method will remove all instances of an element in the first list object that are found in the second list object.
		/// Once removed the method will return the first list without matching elements.
		/// The parameters required for are of Type CustomList<typeparamref name=" T"/>
		/// </summary>
		/// <param name="firstList"></param>
		/// <param name="secondList"></param>
		/// <returns></returns>
		public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
		{
			foreach (T item in firstList)
			{
				for (int i = 0; i < secondList.count; i++)
				{
					if (item.Equals(secondList[i]))
					{
						firstList.Remove(item);
					}
				}
			}
		return firstList;
		}
		
		public CustomList<T> Zipper(CustomList<T> secondList)
		{ 
			CustomList<T> zippedList = new CustomList<T>();
			int temporaryCount = Math.Max(count, secondList.Count);

			for (int i = 0,j = 0; i < temporaryCount; i++, j++)
			{ 
			if (i < count) { zippedList.Add(arrayOfData[i]); } 
			if (i < secondList.count) { zippedList.Add(secondList[i]); } 
			}
			return zippedList;
		}
	}
}
