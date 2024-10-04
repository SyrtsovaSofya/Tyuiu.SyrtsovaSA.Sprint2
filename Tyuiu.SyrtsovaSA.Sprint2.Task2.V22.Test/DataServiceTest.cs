using Tyuiu.SyrtsovaSA.Sprint2.Task2.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task2.V22.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int x = 5;
        int y = 7;
        bool res = ds.CheckDotInShadedArea(x, y);
        Assert.AreEqual(true, res);
   } 
} 
