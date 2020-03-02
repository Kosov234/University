using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_ThirdTask
{
	class Card : ICardInfoShow
	{
		public Card(NormalCardsType cardType,NormalCardsSuit cardSuit)
		{
			CardType = cardType;
			CardSuit = cardSuit;
		}

		public NormalCardsType CardType { get;private set; }
		public NormalCardsSuit CardSuit { get;private set; }

		public override string ToString()
		{
			return $"Card info:{CardType} {CardSuit}";
		}
	}
}
