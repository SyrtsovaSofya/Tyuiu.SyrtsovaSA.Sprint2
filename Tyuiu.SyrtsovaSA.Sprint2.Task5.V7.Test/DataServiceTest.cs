using Tyuiu.SyrtsovaSA.Sprint2.Task5.V7.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task5.V7.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int startYear = 1990;
        int month = 5;
        Assert.AreEqual("Èþíü", ds.FindMonthName(startYear, month));
   } 
} 
