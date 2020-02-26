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
			count = 0;
			arrayCapacity = 4;
			arrayOfData = new T[arrayCapacity];
			
		}

		//member methods
		public void Add(T element)
		{

			if (IsOverCapacity() == true)
			{
				UpdateArray();
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
		private void UpdateArray()
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
			UpdateArray(elementToRemove);
		}
		private void UpdateArray(T assignedElement)
		{
			T[] temporaryArray = new T[arrayCapacity];
			int temporaryCount = count;
			bool removed = false;
			for (int i = 0,j=0; i < temporaryCount; i++,j++)
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


	}


}
