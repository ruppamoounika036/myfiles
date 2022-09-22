// class Car 
// {
//   string color = "red"; //Instance field
//   int maxSpeed = 200;
//   static int app=20;  //static field

//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     Console.WriteLine(myObj.color);
//     Console.WriteLine(myObj.maxSpeed);
//     Console.WriteLine(app);
//   }
// }
/*************readonly****************/
// class Age
// {
//     private readonly int _year;
//     Age(int year)
//     {
//         _year = year;
//     }
//     void ChangeYear()
//     {
//        // _year = 1967; // Compile error if uncommented.
//     }
//       static void Main(string[] args)
//   {
//     Age myObj = new Age(2000);
//     myObj.ChangeYear();
//   }
    
// }