using Tyuiu.SyrtsovaSA.Sprint2.Task0.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task0.V22.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int x = 3105;
        int y = 77;
        bool[] res = ds.GetCompareOperations(x, y);
        bool[] wait = [false, true, true, true, true, false];
        CollectionAssert.AreEqual(res, wait);
   } 
} 
