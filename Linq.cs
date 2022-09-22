// class Employee{
//     public int EmployeeID{get;set;}
//     public string? EmpName { get; set; }
//     public int Age { get; set; }
// }
// class Program
// {
//     public static void Main()
//     {
//         List<Employee> empList = new List<Employee>()
//         {
//         new Employee() { EmployeeID = 1, EmpName = "Raj", Age = 28 } ,
//         new Employee() { EmployeeID = 2, EmpName = "RajRaj",  Age = 16 } ,
//         new Employee() { EmployeeID = 3, EmpName = "Sunder",  Age = 35 } ,
//         new Employee() { EmployeeID = 4, EmpName = "Ramj" , Age = 20 } ,
//         new Employee() { EmployeeID = 5, EmpName = "Ronit" , Age = 38 }
//         };

//         var empResult = from s in empList
//                     where s.Age > 12 && s.Age < 30 && s.EmpName.StartsWith("R") &&
//                     s.EmpName.EndsWith("j")
//                     select s.EmpName;
//         foreach (var emp in empResult)
//         {
//             Console.WriteLine(emp);
//         }
//         Console.ReadLine();
//     }
// }
// C# program to illustrate the creation
// of thread using static method
/*******************************Thread LOOP*****************************/
// using System;
// using System.Threading;

 
// public class GFG {

// 	public static void Main()
// 	{
        
//         for(int i=0;i<100000;i++){
// 		   Thread t = new Thread(()=>{Thread.Sleep(120000);});
// 		   t.Start();
//         }
// 		Console.WriteLine("END");
		
// 	}
// }
