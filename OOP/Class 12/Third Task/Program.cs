using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomIntList Test = new CustomIntList();
			Element TestElement = new Element(1);
			Element TestElement2 = new Element(2);
			Element TestElement3 = new Element(3);
			Element TestElement4 = new Element(2);
			Element TestElement5 = new Element(5);
			Element TestElement6 = new Element(6);
			Test.Add(TestElement);
			Test.Add(TestElement2);
			Test.Add(TestElement3);
			Test.Add(TestElement4);
			Test.Add(TestElement6);
			Test.Add(TestElement5, 2);
			Test.ShowElements();
			Test.ShowElementsNextProperty();
			Console.WriteLine("-----------------");
			Test.Remove(2);
			Test.ShowElements();
			Test.ShowElementsNextProperty();
			Element FunctionTest = Test.GetElementByIndex(3);
			Console.WriteLine(FunctionTest.Value);
		}
	}
}
