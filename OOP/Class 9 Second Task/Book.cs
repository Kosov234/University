using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_SecondTask
{
	class Book : IBook
	{
		public string Name { get; private set; }
		public string Author { get; private set; }
		public string[] Pages { get; private set; }
		public double Width { get; private set; }
		public double Height { get; private set; }
		public double Depth { get; private set; }
		public double Weight { get; private set; }

		public Book(string name, string author, string[] pages, double width, double height, double depth, double weight)
		{
			Name = name;
			Author = author;
			Pages = pages;
			Width = width;
			Height = height;
			Depth = depth;
			Weight = weight;
		}

		public void ReadBookInformation()
		{
			Console.WriteLine($"Book name:{Name}\n" +
								$"Book author:{Author}\n" +
								$"Amount of pages:{Pages.Length}\n" +
								$"Width:{Width}\n" +
								$"Depth:{Depth}\n" + 
								$"Weight:{ Weight}");
		}

		public void ReadBookPage(int page)
		{
			Console.WriteLine($"Book title:{Name}\n" +
							  $"Number of pages:{Pages.Length}\n" +
							  $"Page {page}: {Pages[page - 1]}");
		}
	}
}
