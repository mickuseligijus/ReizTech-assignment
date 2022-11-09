using ReizTech.Models;
using ReizTech.Services;
namespace UnitTests
{
    public class ToolsTests
    {
        [Test]
        [TestCase(1, 5, 0)]
        [TestCase(1, 10, 30)]
        [TestCase(1, 11, 36)]
        [TestCase(1, 35, 180)]
        [TestCase(1, 34, 174)]
        [TestCase(12, 29, 174)]

        public void CalculateAngle_Works(int hours, int minutes, int expected)
        {

            var angle = Tools.CalculateAngle(hours, minutes);
            Assert.That(angle, Is.EqualTo(expected));

        }
        [Test]
        public void SearchDepth_Works()
        {
            var v11 = new Branch() { Branches = new List<Branch>() { new Branch() } };
            var v9 = new Branch() { Branches = new List<Branch>() { v11 } };
            var v6 = new Branch() { Branches = new List<Branch>() { v9 } };
            var v8 = new Branch() { Branches = new List<Branch>() { new Branch() } };
            var v2 = new Branch() { Branches = new List<Branch>() { v6, new Branch() }};
            var v4 = new Branch(){ Branches = new List<Branch> { v8 }};
            var v1 = new Branch() { Branches = new List<Branch>() { v2, new Branch(), v4, new Branch() }};

            Assert.That(Tools.SearchDepth(v1), Is.EqualTo(6));
        }

        [Test]
        public void SearchDepth_DepthOne()
        {
            var v1 = new Branch();
            Assert.That(Tools.SearchDepth(v1), Is.EqualTo(1));
        }

        [Test]
        public void SearchDepth_DepthTwo()
        {
            var v1 = new Branch() { Branches = new List<Branch>() { new Branch(), new Branch(), new Branch() } };
            
            Assert.That(Tools.SearchDepth(v1), Is.EqualTo(2));
        }
    }
}
