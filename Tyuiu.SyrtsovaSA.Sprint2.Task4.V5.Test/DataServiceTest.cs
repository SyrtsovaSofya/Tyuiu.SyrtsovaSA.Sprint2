using Tyuiu.SyrtsovaSA.Sprint2.Task4.V5.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task4.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{
    [TestMethod]
    public void ValidCondition1()
    {
        DataService ds = new DataService();
        double x = 0;
        double y = 5;
        double res = ds.Calculate(x, y);
        Assert.AreEqual(0.2, res);
    }
    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 15;
        double y = 5;
        double res = ds.Calculate(x, y);
        Assert.AreEqual(14312.115, res);
    }
} 
