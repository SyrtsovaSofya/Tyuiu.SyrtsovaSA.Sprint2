using Tyuiu.SyrtsovaSA.Sprint2.Task3.V18.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint2.Task3.V18.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        int x = 2;
        double res = ds.Calculate(x);
        Assert.AreEqual(36, res);
    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        int x = 0;
        double res = ds.Calculate(x);
        Assert.AreEqual(0.75, res);
    }
    [TestMethod]
    public void ValidCondition3()
    {
        DataService ds = new DataService();
        int x = 1;
        double res = ds.Calculate(x);
        Assert.AreEqual(2, res);
    } 
    [TestMethod]
    public void ValidCondition4()
    {
        DataService ds = new DataService();
        int x = -25;
        double res = ds.Calculate(x);
        Assert.AreEqual(-274.96, res);
    }
}
