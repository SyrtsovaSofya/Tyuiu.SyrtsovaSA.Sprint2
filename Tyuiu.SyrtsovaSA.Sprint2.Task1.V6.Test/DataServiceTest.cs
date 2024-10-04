using Tyuiu.SyrtsovaSA.Sprint2.Task1.V6.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint2.Task1.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int a = 915;
        int b = 169;
        int c = 174;
        int d = 133;
        bool[] res = ds.GetLogicOperations(a, b, c, d);
        bool[] wait = [false, false, true, false, true, false];
        CollectionAssert.AreEqual(res, wait);
    }
}
