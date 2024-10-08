using Tyuiu.SyrtsovaSA.Sprint2.Task7.V13.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task7.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCheckDotInShadedArea()  
   {
        DataService ds = new DataService();
        double x = 2;
        double y = 1;
        bool res = ds.CheckDotInShadedArea(x, y);
        Assert.AreEqual(true, res);
   } 
} 
