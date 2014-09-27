using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukamuAlgo
{
	public class Sept21st
	{
		static void Main(string[] args)
		{
		}

		public static int Max4(int a, int b, int c, int d)
		{
			int max = a;

			if (max < b)
			{
				max = b;
			}

			if (max < c)
			{
				max = c;
			}

			if (max < d)
			{
				max = d;
			}

			return max;
		}

		public static int Max4_2(int a, int b, int c, int d)
		{
			var list = new List<int>() { a, b, c, d };
			var max = list.Aggregate((x, y) => x > y ? x : y);
			return max;
		}

		public static int Min3(int a, int b, int c)
		{
			int min = a;

			if (min > b)
			{
				min = b;
			}
			if (min > c)
			{
				min = c;
			}

			return min;
		}

		public static int Min4(int a, int b, int c, int d)
		{
			int min = a;

			if (min > b)
			{
				min = b;
			}

			if (min > c)
			{
				min = c;
			}

			if (min > d)
			{
				min = d;
			}

			return min;	
		}

		public static int Med3(int a, int b, int c)
		{
			var max = Sept21st.Max3(a, b, c);
			var min = Sept21st.Min3(a, b, c);

			var list = new List<int>() { a, b, c};
			list.Remove(min);
			list.Remove(max);

			var med = list.First();

			return med;
		}

		public static int Max3(int a, int b, int c)
		{
			int max = a;

			if (max < b)
			{
				max = b;
			}

			if (max < c)
			{
				max = c;
			}

			return max;
		}

	}
}
