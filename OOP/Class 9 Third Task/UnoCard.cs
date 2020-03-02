using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_ThirdTask
{
	class UnoCard : ICardInfoShow
	{
		public UnoCard(UnoCardType cardType,UnoCardSuit cardSuit)
		{
			CardType = cardType;
			CardSuit = cardSuit;
		}

		public UnoCard(UnoCardType cardType)
		{
			CardType = cardType;
		}

		UnoCardType CardType;
		UnoCardSuit CardSuit;

		public override string ToString()
		{
			return $"Card info : {CardType} {CardSuit}";
		}
	}
}
