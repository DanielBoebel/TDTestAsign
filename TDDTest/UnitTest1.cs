using System;
using System.Collections;
using Xunit;

namespace TDDTest
{
    public class UnitTest1
    {
		

        [Fact]
		public void TestGrade()
        {
			string testGrade = "C";
			int tempGrade = -1;
			ArrayList americanGrade = new ArrayList();
			americanGrade.Add("A");
			americanGrade.Add("B");
			americanGrade.Add("C");
			americanGrade.Add("D");
			americanGrade.Add("E");
			americanGrade.Add("Fx");
			americanGrade.Add("F");

			if (americanGrade.Contains(testGrade) == true)
			{
				tempGrade = americanGrade.IndexOf(testGrade);
			}


			ArrayList danishGrade = new ArrayList();
			danishGrade.Add("12");
			danishGrade.Add("10");
			danishGrade.Add("7");
			danishGrade.Add("4");
			danishGrade.Add("02");
			danishGrade.Add("00");
			danishGrade.Add("-3");

			Assert.Equal("12", danishGrade[tempGrade]);
			Assert.Equal("10", danishGrade[tempGrade]);
			Assert.Equal("7", danishGrade[tempGrade]);
			Assert.Equal("4", danishGrade[tempGrade]);




        }
    }
}
