using FluentAssertions;
using NUnit.Framework;
using Split;
namespace TestSplit
{
    public class SplitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Split_ValidIEnumerable_SplitInTwo()
        {
            ICollection<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            var actual = list.Split(2);
            ICollection<IEnumerable<string>> expected = new List<IEnumerable<string>> 
            {   new List<string> { "1", "2" } ,
                new List<string> { "3" } 
            };
            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Split_ValidIEnumerable_SplitInFour()
        {
            ICollection<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.FirstOrDefault();
            var actual = list.SplitOrDefault(4);
            ICollection<IEnumerable<string>> expected = new List<IEnumerable<string>>
            {   
            };
            actual.Should().BeEquivalentTo(expected);
        }

    }
}