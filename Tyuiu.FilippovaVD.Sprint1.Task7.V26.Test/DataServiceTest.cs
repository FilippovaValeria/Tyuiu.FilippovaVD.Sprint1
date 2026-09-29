using Tyuiu.FilippovaVD.Sprint1.Task7.V26.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 2;

            double wait = 0.944;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
