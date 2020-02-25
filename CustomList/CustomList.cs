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
		int count;
		int arrayCapacity;
		private T[] arrayOfData;
		public T this [int index]
		{
			get { return arrayOfData[index]; }
			set { arrayOfData[index] = value; }
		}
		public int Length { get { return count; } }
		public int Count { get { return count; } }
		public int Capacity
		{
			get 
			{ 
				return arrayCapacity; 
			}
			set
			{
				if (count <= arrayCapacity)
				{
					arrayCapacity = 4;
				}
				
			}
		}
		//ctor
		public CustomList()
		{
			arrayCapacity = 4;
			arrayOfData = new T[arrayCapacity];
			
		}

		//member methods
		public void Add(T item)
		{

			if (IsOverCapacity() == true)
			{
				CreateNewPrivateArray();
				arrayOfData[count] = item;
				count++;
			}
			else
			{
			arrayOfData[count] = item;
			count++;
			}

		}
		private bool IsOverCapacity()
		{
			if (count >= arrayCapacity)
			{ return true; }
			else
			{ return false; }
		}
		private void CreateNewPrivateArray()
		{

			T[] temporaryArray = new T[arrayCapacity * 2];
			for (int i = 0; i < arrayCapacity; i++)
			{
				temporaryArray[i] = arrayOfData[i];
				
			}
			
			arrayOfData = temporaryArray;
			arrayCapacity *= 2;
		}









	}

	
}
