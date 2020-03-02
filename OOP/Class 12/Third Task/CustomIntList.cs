using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
	class CustomIntList
	{
		public Element[] Elements = new Element[0];

		private void NextElementAssigner()
		{
			if (Elements.Length > 1)
			{
				for (int i = 0; i < Elements.Length - 1; i++)
				{
					Elements[i].Next = Elements[i + 1];             //Re-assign all Element.Next pointers
				}
				Elements[Elements.Length - 1].Next = null; //Last Element.Next points to nowhere
			}
		}

		private void ElementsIndexManagerForAdding(int index)
		{
			for (int i = Elements.Length - 1; i > index; i--)
			{
				Elements[i] = Elements[i - 1];
			}
		}

		private void ElementsIndexManagerForRemoving(int index)
		{
			for (int i = index; i <= Elements.Length - 2; i++)
			{
				Elements[i] = Elements[i + 1];
			}
		}

		public void Add(Element element)
		{
			Array.Resize(ref Elements, Elements.Length + 1); //Increase the size of an array by one
			Elements[Elements.Length - 1] = element; //Add the last element
			NextElementAssigner(); //re-assign Element.Next pointers
		}
		
		public void Add(Element element,int index)
		{
			Array.Resize(ref Elements, Elements.Length + 1); //Increase the size of an array by one
			ElementsIndexManagerForAdding(index);
			Elements[index] = element;
			NextElementAssigner();
		}

		public void Remove(int value)
		{
			for (int i = 0; i < Elements.Length - 1; i++)
			{
				if (Elements[i].Value == value)
				{
					ElementsIndexManagerForRemoving(i);
					break;
				}
			}
			Array.Resize(ref Elements, Elements.Length - 1);
			NextElementAssigner();
		}

		public void ShowElements()
		{
			foreach (var element in Elements)
			{
				Console.WriteLine(element.Value);
			}
		}

		public void ShowElementsNextProperty()
		{
			for (int i = 0; i < Elements.Length; i++)
			{
				if (Elements[i].Next != null)
					Console.WriteLine($"Element[{i}].Next = {Elements[i].Next.Value}");
				else
					Console.WriteLine($"Element[{i}].Next =  ");
			}
		}

		public Element GetElementByIndex(int index)
		{
			return Elements[index];
		}

		public Element GetElementByValue(int value)
		{
			for (int i = 0; i < Elements.Length; i++)
			{
				if (Elements[i].Value == value)
				{
					return Elements[i];
				}
			}
			Console.WriteLine($"Element with a value {value} not found!");
			return null;
		}
	}
}
