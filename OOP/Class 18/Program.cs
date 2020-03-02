using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var products = new List<Product>
			{
				new Product(1,"Mouse",39,EnumColor.Black),
				new Product(2,"Keyboard",49,EnumColor.Black),
				new Product(3,"Monitor",460,EnumColor.Gray),
				new Product(4,"Speakers 2.1",70,EnumColor.Blue),
				new Product(5,"Speakers 5.1",250,EnumColor.Black)
			};

			//3.1
			//var productNames = products.Select(product => product.Name);
			//foreach (var item in productNames)
			//{
			//	Console.WriteLine(item);
			//}
			//3.2
			//var productNamesAndPrices = products.Select(product => product.Name +" "+ product.Price);
			//foreach (var item in productNamesAndPrices)
			//{
			//	Console.WriteLine(item);
			//}
			//3.3
			//var speakers = products.Where(product => product.Name.Contains("Speakers"))
			//					   .Select(product => product.ToString());
			//foreach (var item in speakers)
			//{
			//	Console.WriteLine(item);
			//}
			//3.4
			//var blackProducts = products.Where(product => product.Color == EnumColor.Black)
			//					   .Select(product => product.ToString());
			//foreach (var item in blackProducts)
			//{
			//	Console.WriteLine(item);
			//}
			//3.5
			//var cheapProducts = products.Where(product => product.Price < 100)
			//							.Select(product => product.ToString());
			//foreach (var item in cheapProducts)
			//{
			//	Console.WriteLine(item);
			//}
			//3.6
			//var notBlackProducts = products.Where(product => product.Color != EnumColor.Black)
			//					   .Select(product => product.ToString());
			//foreach (var item in notBlackProducts)
			//{
			//	Console.WriteLine(item);
			//}
			//3.7
			//var blackAndExpensiveProducts = products.Where(product => product.Color == EnumColor.Black && product.Price > 200)
			//					   .Select(product => product.Id);
			//foreach (var item in blackAndExpensiveProducts)
			//{
			//	Console.WriteLine(item);
			//}
			//3.8
			var id4products = products.Where(product => product.Id == 4);
			foreach (var item in id4products)
			{
				Console.WriteLine(item);
			}
			//3.9
			//var averagePrice = products.Select(product => product.Price)
			//							.Average();
			//Console.WriteLine(averagePrice);
			//3.10
			//var biggestId = products.Select(product => product.Id)
			//						.Max();
			//Console.WriteLine(biggestId);
			//3.11
			//var prices = products.OrderByDescending(product => product.Price);
			//foreach (var item in prices)
			//{
			//	Console.WriteLine(item);
			//}
		}


	}
}
