using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T>
	{
		//member variables
		private int count;
		private int arrayCapacity;
		private T[] arrayOfData;
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
				{
					throw new ArgumentOutOfRangeException();
				}
				else
				{
					arrayOfData[index] = value;
				}
			}
		}
			
		
		public int Length { get { return count; } }
		public int Count { get { return count; } }
		public int Capacity
		{
			get 
			{ 
				return arrayCapacity; 
			}

		}
		//ctor
		public CustomList()
		{
			arrayCapacity = 4;
			arrayOfData = new T[arrayCapacity];
			
		}

		//member methods
		public void Add(T element)
		{

			if (IsOverCapacity() == true)
			{
				CreateNewArray();
				AddItemToArray(element);
				IncrementCount();
			}
			else
			{
				AddItemToArray(element);
				IncrementCount();
			}

		}
		//ADD METHOD FUNCTIONALITY
		private bool IsOverCapacity()
		{
			if (count >= arrayCapacity)
			{ return true; }
			else
			{ return false; }
		}
		private void CreateNewArray()
		{

			T[] temporaryArray = new T[arrayCapacity * 2];
			for (int i = 0; i < arrayCapacity; i++)
			{
				temporaryArray[i] = arrayOfData[i];
				
			}
			
			arrayOfData = temporaryArray;
			arrayCapacity *= 2;
		}

		private void AddItemToArray(T element)
		{
			arrayOfData[count] = element;

		}
		private void IncrementCount()
		{
			count++;
		}

		//REMOVE METHOD FUNCTIONALITY

		public void Remove(T elementToRemove)
		{
			bool elementIsPresent = IsElementPresent(elementToRemove);
			T assignedElement = FindInstanceOfElement(elementToRemove);



		}


		private bool IsElementPresent(T elementToFind)
		{
			for (int i = 0; i < count; i++)
			{

				if (elementToFind.Equals(arrayOfData[i]))
				{
					return true;
				}
			}
			return false;
		}

		private T FindInstanceOfElement(T elementToAssign)
		{

			for (int i = 0; i < count; i++)
			{
				if (elementToAssign.Equals(arrayOfData[i]))
				{
					return arrayOfData[i];
				}
			}
			return elementToAssign;
		}

		//private void CreateNewArray()
		//{
		//	if 
		//}


	}

	
}
