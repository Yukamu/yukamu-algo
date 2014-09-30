using NUnit.Framework;
using YukamuAlgo;

namespace YukamuAlgoTest
{
	[TestFixture(Description = "4つの引数を渡しその中で一番大きなものを返すメソッドを作成しなさい。")]
	public class 演習1_1
	{
		[Test]
		public void Max4ReturnMaxNumber()
		{
			Sept21st.Max4(1, 2, 3, 4).Is(4);
			Sept21st.Max4(2, 3, 4, 1).Is(4);
			Sept21st.Max4(3, 4, 1, 2).Is(4);
			Sept21st.Max4(8, 8, 9, 9).Is(9);
			Assert.AreEqual(Sept21st.Max4(4, 5, 6, 7), 7);
		}

		[Test]
		public void Max4_2ReturnsMaxNumber()
		{
			Sept21st.Max4_2(1, 2, 3, 4).Is(4);
			Sept21st.Max4_2(2, 3, 4, 1).Is(4);
			Sept21st.Max4_2(-2, -3, -4, -1).Is(-1);
		}
	}

	[TestFixture(Description = "3つの引数を渡しその中で一番小さなものを返すメソッドを作成しなさい。")]
	public class 演習1_2
	{
		[Test]
		public void Min3ReturnsMinNumber()
		{
			Sept21st.Min3(1, 2, 3).Is(1);
			Sept21st.Min3(2, 3, 1).Is(1);
			Sept21st.Min3(3, 2, 1).Is(1);
		}
	}

	[TestFixture(Description = "4つの引数を渡しその中で一番小さなものを返すメソッドを作成しなさい。")]
	public class 演習1_3
	{
		[Test]
		public void Min4ReturnsMinNumber()
		{
			Sept21st.Min4(1, 2, 3, 4).Is(1);
			Sept21st.Min4(2, 3, 4, 1).Is(1);
			Sept21st.Min4(2, 2, 2, 2).Is(2);
		}
	}

	[TestFixture]
	public class おまけ
	{
		[Test]
		public void Max3ReturnsMaxNumber()
		{
			Sept21st.Max3(1, 2, 3).Is(3);
			Sept21st.Max3(2, 3, 1).Is(3);
			Sept21st.Max3(2, 2, 3).Is(3);
		}
	}
	[TestFixture(Description = "3つの引数を渡しその中の最大でも最小でもない値を返すメソッドを作成しなさい。")]
	public class 演習1_4
	{
		[Test]
		public void Med3ReturnsMediumNumber()
		{
			Sept21st.Med3(1, 2, 3).Is(2);
			Sept21st.Med3(2, 3, 1).Is(2);
			Sept21st.Med3(3, 1, 2).Is(2);

			Sept21st.Med3(2, 2, 3).Is(2);
			Sept21st.Med3(3, 2, 3).Is(3);
			Sept21st.Med3(3, 3, 3).Is(3);
		}
	}

	[TestFixture(Description="while文の終了時点における変数iの値が n+1 となることを確認せよ。（表示するプログラムを作成する）")]
	public class 演習１_6
	{
		[Test]
		public void _WhenWhileStatementNplusOneOut()
		{
			Sept21st.Practice1_6(7);
		}
	}

	[TestFixture(Description="1から7まで足したものを表示しなさい。（n=7）1 + 2 + ・・・  + 7 = 28")]
	public class 演習1_7
	{
		[Test]
		public void SumFrom1ToN()
		{
			Sept21st.Practice1_7(7);
			Sept21st.Practice1_7(10);
		}
	}

	[TestFixture(Description="ガウスの方法で和を求めるプログラムを作成しなさい。")]
	public class 演習1_8
	{
		[Test]
		public void SumWithGaussMethod()
		{
			Sept21st.Practice1_8(10).Is(55);
			Sept21st.Practice1_8(100).Is(5050);
		}
	}
}
