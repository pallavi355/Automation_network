using System.Collections;
using NUnit.Framework;

namespace TurnupNunitMay20
{
    public class TestDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("100", "ray");
                yield return new TestCaseData("8055", "ray1");
                yield return new TestCaseData("788", "ray3");
                yield return new TestCaseData("100", "ray4");
                yield return new TestCaseData("8055", "ray5");
                yield return new TestCaseData("788", "ray6");

            }
        }
    }
}