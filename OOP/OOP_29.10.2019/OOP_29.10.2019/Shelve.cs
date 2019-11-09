using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29._10._2019
{
	class Shelve
	{
		private Book[] bookArray;

		public void PopulateShelve(int amountOfBooks)
		{
			bookArray = new Book[10];
			for (int i = 0; i < amountOfBooks; i++)
			{
				bookArray[i] = new Book();
				bookArray[i].Author = "Author number " + i;
				bookArray[i].Id = i;
				bookArray[i].Title = "Title number " + i;
			}
		}


		public void Print()
		{
			for (int i = 0; i < bookArray.Length; i++)
			{
				Console.WriteLine(bookArray[i].Title);
			}
		}
	}
	
}

