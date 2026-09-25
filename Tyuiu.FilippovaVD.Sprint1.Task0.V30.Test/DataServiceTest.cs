using Tyuiu.FilippovaVD.Sprint1.Task0.V30.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(96, res);
        }
    }
}

