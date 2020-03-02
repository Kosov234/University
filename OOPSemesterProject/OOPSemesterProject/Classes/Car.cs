using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterProject.Classes
{
	public class Car : Classes.ShopElement,IGetDescription
	{
		public List<CarPart> Components = new List<CarPart>();	

		public override string GetDescription()
		{
			string partsDescription = string.Empty;
			for (int i = 0; i < Components.Count; i++)
			{
				partsDescription += Components[i].GetDescription().ToString() + "\r\n\r\n";
			}
				
			return partsDescription;
		}
	}
}
