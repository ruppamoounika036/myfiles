// namespace UnderstandingEqualsMethod
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Customer obj1 = new Customer();
//             obj1.FirstName = "Ruppa";
//             obj1.LastName = "Mounika";

//             Customer obj2 = new Customer();
//             obj2.FirstName = "Ruppa";
//             obj2.LastName = "Mounika";

//             Console.WriteLine($"With '==' Operator : {obj1 == obj2}");
//             Console.WriteLine($"C1.Equals(C2): {obj1.Equals(obj2)}");
//         }
//     }
//     public class Customer
//     {
//         public string? FirstName { get; set; }
//         public string? LastName { get; set; }
//         public static bool operator ==(Customer obj,Customer obj1){
          
//             if (obj is not Customer || obj1 is not Customer)
//             {
//                 return false;
//             }
//             return (((Customer)obj1).FirstName == ((Customer)obj).FirstName)
//                 && (((Customer)obj1).LastName == ((Customer)obj).LastName);
//         }
//          public static bool operator !=(Customer obj,Customer obj1){
//            if (obj is not Customer || obj1 is not Customer)
//             {
//                 return false;
//             }
//             return (((Customer)obj1).FirstName != ((Customer)obj).FirstName)
//                 || (((Customer)obj1).LastName != ((Customer)obj).LastName);
//         }

//         public override bool Equals(object ob6j)
//         {
//             if (obj is not Customer)
//             {
//                 return false;
//             }
//             return (this.FirstName == ((Customer)obj).FirstName)
//                 && (this.LastName == ((Customer)obj).LastName);
//         }
//     }
// }