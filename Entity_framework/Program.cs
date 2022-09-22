// // using EFCoreExecuteRawSQLDemo.Models;
// // using Microsoft.EntityFrameworkCore1;
// using System;
// using System.Linq;
// using System.Data;
// namespace EFCoreTutorials
// {
 
// public class Student_detai
// {
//  public int StudentId { get; set; }
//  public string Name { get; set; }
// }
// public class Course
// {
//  public int CourseId { get; set; }
//  public string CourseName { get; set; }
// }

//  public class SchoolContext : DbContext
//  {
//   public DbSet<Student_detai> Students { get; set; }
//   public DbSet<Course> Courses { get; set; }

//   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//   { 
//    optionsBuilder.UseSqlServer(@"Data Source=TGU1SER15;Initial Catalog=Mounika23;User Id=sa;Password=Dbase@1234;Trusted_Connection=True;");
//   }
//  }
 
//     class ProgramPro
//     {
//         static void Main(string[] args)
//         {
//             using (var context = new SchoolContext()) {

//                 var std = new Student_detai()
//                 {
//                      Name = "Bill"
//                 };

//                 context.Students.Add(std);
//                 context.SaveChanges();
//             }
//         }
// //         private static void Main(string[] args)
// // {
// //     var context = new SchoolContext();
// //     var studentsWithSameName = context.Students
// //                                       .Where(s => s.Name == GetName())
// //                                       .ToList();
// // }

// // public static string GetName() {
// //     return "Bill";
// // }
//     }
// }


