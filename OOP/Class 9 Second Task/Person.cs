using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_SecondTask
{
	class Person
	{
		public string Name { get;private set; }
		public string Surname { get;private set; }

		public Person(string name,string surname)
		{
			Name = name;
			Surname = surname;
		}

		static string[] FirstBookPages = { "First book page 1", "First book page 2", "First book page 3",
										   "First book page 4", "First book page 5" };

		static string[] SecondBookPages = { "Second book page 1", "Second book page 2", "Second book page 3",
											"Second book page 4", "Second book page 5", "Second book page 6", "Second book page 7" };

		static string[] ThirdBookPages = {"Third book page 1", "Third book page 2", "Third book page 3",
										  "Third book page 4", "Third book page 5", "Third book page 6" };

		public IBook[] Books = { new ElectronikBook("The Professor's House", "Willa Cather", FirstBookPages, 242),
								 new Book("The Frederica Quartet", "A.S. Byatt",SecondBookPages,12.1,13.2,2.5,123),
								 new ElectronikBook("As a Man Grows Older","Italo Svevo",ThirdBookPages,442)};

		public void ReadBookInformation(int bookPosition)
		{
			Books[bookPosition-1].ReadBookInformation();
		}

		public void ReadBookPage(int bookPosition,int pageNumber)
		{
			Books[bookPosition-1].ReadBookPage(pageNumber);
		}
	}
}
