using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_SecondTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Person Mike = new Person("Mike","Vazowski");
			//Mike.ReadBookInformation(1);
			Mike.ReadBookPage(1, 2);
		}
		
	}
}
