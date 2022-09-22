/****************************Static Class**************************************/
// namespace CSharpClasses
// {
//     public static class College

//     {
//         public static string Name = "LPS Inter College";
//         public static string Address = "Noida Sctor 62";
//         public static int PhoneNo = 000;
//         static College()  
//         {

//         }
//         public static string TimeTable() 
//         {
//             string timeT = "Morning";
//             return timeT;

//         }
//     }

//     public class MainClass
//     {
//         static public void Main()

//         {
//             Console.WriteLine("Name : {0} ", College.Name);
//             Console.WriteLine("Address : {0} ", College.Address);
//             Console.WriteLine("PhoneNo : {0} ", College.PhoneNo);
//             Console.WriteLine("TimeTable : {0} ", College.TimeTable());
//         }
//     }
// }
/**************************************Partial Class*******************************/
// public partial class Geeks {
// 	private string Author_name;
// 	private int Total_articles;

// 	public Geeks(string a, int t)
// 	{
// 		this.Author_name = a;
// 		this.Total_articles = t;
// 	}
// }
// public partial class Geeks {
// 	public void Display()
// 	{
// 		Console.WriteLine("Author's name is : " + Author_name);
// 		Console.WriteLine("Total number articles is : " + Total_articles);
// 	}
// }
// public class Sam{
//     static void Main(){
//         Geeks g= new Geeks("Mounika",10);
//         g.Display();
//     }
// }
/*******************************Abstract Classes*******************************/
// Abstract class
// abstract class Animal
// {
//   // Abstract method (does not have a body)
//   public abstract void animalSound();
//   // Regular method
//   public void sleep()
//   {
//     Console.WriteLine("Zzz");
//   }
// }

// // Derived class (inherit from Animal)
// class Pig : Animal
// {
//   public override void animalSound()
//   {
//     // The body of animalSound() is provided here
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Pig myPig = new Pig(); // Create a Pig object
//     myPig.animalSound();  // Call the abstract method
//     myPig.sleep();  // Call the regular method
//   }
// }
/*******************************Sealed****************************/
// namespace SealedClass_Demo  
// {  
//     public sealed class Employee  
//     {  
//         string firstName;  
//         string lastName;  
//     }  
//     class Program:Employee  
//     {  
//         static void Main(string[] args)  
//         {  
  
//         }  
//     }  
// }