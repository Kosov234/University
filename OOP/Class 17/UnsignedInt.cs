using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_17
{
	class UnsignedInt
	{
		public int value;

		public UnsignedInt(int value)
		{
			if (value < 0)
				this.value = 0;
			else
				this.value = value;

		}

		public static UnsignedInt operator +(UnsignedInt a, UnsignedInt b)
		{
			return new UnsignedInt(a.value + b.value);
		}

		public static UnsignedInt operator +(UnsignedInt a, int b)
		{
			if (b < 0)
				return new UnsignedInt(a.value);

			return new UnsignedInt(a.value + b);
		}

		public static UnsignedInt operator +(int b, UnsignedInt a)
		{
			return a + b;
		}

		public static UnsignedInt operator -(UnsignedInt a, UnsignedInt b)
		{
				return new UnsignedInt(a.value - b.value);
		}

		public static UnsignedInt operator -(UnsignedInt a, int b)
		{
			return new UnsignedInt(a.value - b);
		}

		public static UnsignedInt operator -(int b, UnsignedInt a)
		{
			return new UnsignedInt(b - a.value);
		}

		public static UnsignedInt operator *(UnsignedInt a, UnsignedInt b)
		{
			return new UnsignedInt(a.value * b.value);
		}

		public static UnsignedInt operator *(UnsignedInt a, int b)
		{
			return new UnsignedInt(a.value * b);
		}

		public static UnsignedInt operator *(int b, UnsignedInt a)
		{
			return a * b;
		}

		public static UnsignedInt operator /(UnsignedInt a, UnsignedInt b)
		{
			if (b.value <= 0)
				return new UnsignedInt(0);
			return new UnsignedInt(a.value / b.value);
		}

		public static UnsignedInt operator /(UnsignedInt a, int b)
		{
			return new UnsignedInt(a.value / b);
		}

		public static UnsignedInt operator /(int b, UnsignedInt a)
		{
			return new UnsignedInt(b / a.value);
		}

		public void ShowValue()
		{
			Console.WriteLine($"Value is {value}");
		}
	}
}
