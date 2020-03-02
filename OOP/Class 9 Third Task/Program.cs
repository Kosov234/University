using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_ThirdTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Deck TestDeck = new Deck("Uno");
			TestDeck.Shuffle();
			TestDeck.ShowDeck();
			TestDeck.RemoveFromTheTop();
			TestDeck.ShowDeck();
			Console.WriteLine(TestDeck.DeckList.Count);
		}
	}
}
