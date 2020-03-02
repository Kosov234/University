using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject
{
	public class CartElement : Classes.IGetDescription
	{
		public Classes.ShopElement Element;
		public int Amount { get; set; }

		public CartElement(Classes.ShopElement element,int amount)
		{
			Element = element;
			Amount = amount;
		}

		public string GetDescription()
		{
			return Element.GetDescription();
		}
	}
}
