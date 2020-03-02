using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_17
{
	class Program
	{
		static void Main(string[] args)
		{
			UnsignedInt test1 = new UnsignedInt(3) + new UnsignedInt(4);
			test1.ShowValue();
			UnsignedInt test2 = new UnsignedInt(3) + new UnsignedInt(-2);
			test2.ShowValue();
			UnsignedInt test3 = new UnsignedInt(3) + 4;
			test3.ShowValue();
			UnsignedInt test4 = 4 + new UnsignedInt(3);
			test4.ShowValue();
			UnsignedInt test5 = new UnsignedInt(3) - new UnsignedInt(2);
			test5.ShowValue();
			UnsignedInt test6 = new UnsignedInt(3) - new UnsignedInt(4);
			test6.ShowValue();
			UnsignedInt test7 = new UnsignedInt(3) - 1;
			test7.ShowValue();
			UnsignedInt test8 = 4 - new UnsignedInt(3);
			test8.ShowValue();
			UnsignedInt test9 = new UnsignedInt(3) * 3;
			test9.ShowValue();
			UnsignedInt test10 = -3 * new UnsignedInt(3);
			test10.ShowValue();
			UnsignedInt test11 = new UnsignedInt(3) * new UnsignedInt(3);
			test11.ShowValue();
			UnsignedInt test12 = new UnsignedInt(3) * new UnsignedInt(-3);
			test12.ShowValue();
			UnsignedInt test13 = new UnsignedInt(3) / new UnsignedInt(-3);
			test13.ShowValue();
			UnsignedInt test14 = new UnsignedInt(3) / 3;
			test14.ShowValue();
			UnsignedInt test15 = 6 / new UnsignedInt(3);
			test15.ShowValue();
		}
	}
}
