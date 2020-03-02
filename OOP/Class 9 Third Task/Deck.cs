using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_ThirdTask
{
	class Deck : IDeck
	{
		public Deck(string DeckType)
		{
			if (DeckType == "Uno")
			{
				//Adding all colours of 0,Draw_Two_Cards,Reverse and Skip
				for (int i = 0; i < 4; i++)
				{
					DeckList.Add(new UnoCard(UnoCardType.Zero, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Draw_Two_Cards, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Draw_Two_Cards, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Reverse, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Reverse, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Skip, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Skip, (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), i)));
					DeckList.Add(new UnoCard(UnoCardType.Wild));
					DeckList.Add(new UnoCard(UnoCardType.Wild_Draw_Four_Cards));
				}

				//Adding all colours of cards from 1 to 9
				for (int i = 1; i <= 9; i++)
				{
					for (int y = 0; y < 4; y++)
					{
						DeckList.Add(new UnoCard((UnoCardType)Enum.ToObject(typeof(UnoCardType), i),(UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), y)));
						DeckList.Add(new UnoCard((UnoCardType)Enum.ToObject(typeof(UnoCardType), i), (UnoCardSuit)Enum.ToObject(typeof(UnoCardSuit), y)));
					}
				}
			}
			else
			{
				for (int i = 2; i < 15; i++)
				{
					for (int y = 1; y < 5; y++)
					{
						DeckList.Add(new Card((NormalCardsType)Enum.ToObject(typeof(NormalCardsType), i),(NormalCardsSuit)Enum.ToObject(typeof(NormalCardsSuit), y)));
					}
				}
			}
		}

		public List<ICardInfoShow> DeckList = new List<ICardInfoShow>();

		public void ShowDeck()
		{
			foreach (var item in DeckList)
			{
				Console.WriteLine(item);
			}
		}

		public void RemoveFromTheTop()
		{
			Console.WriteLine($"The following card has been removed: {DeckList[DeckList.Count - 1]}");
			DeckList.RemoveAt(DeckList.Count - 1);
		}

		public void Shuffle()
		{
			for (int i = 0; i < DeckList.Count; i++)
			{
				var item = DeckList[i];
				DeckList.RemoveAt(i);
				Random random = new Random();
				DeckList.Insert(random.Next(DeckList.Count - 1),item);
			}
		}
	}
}
