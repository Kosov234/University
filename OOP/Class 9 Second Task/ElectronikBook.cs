using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_SecondTask
{
	class ElectronikBook : IBook
	{
		public string Name { get; private set; }
		public string Author { get;private set; }
		public string[] Pages { get;private set; }
		public int Size { get;private set; }

		public ElectronikBook(string name,string author,string[] pages,int size)
		{
			Name = name;
			Author = author;
			Pages = pages;
			Size = size;
		}

		public void ReadBookInformation()
		{
			Console.WriteLine($"Book name:{Name}\n" +
								 $"Book author:{Author}\n" +
								 $"Amount of pages:{Pages.Length}\n" +
								 $"Size:{Size}");
		}

		public void ReadBookPage(int page)
		{
			Console.WriteLine($"Book title:{Name}\n" +
							  $"Number of pages:{Pages.Length}\n" + 
				              $"Page {page}: {Pages[page - 1]}");
		}
	}
}
