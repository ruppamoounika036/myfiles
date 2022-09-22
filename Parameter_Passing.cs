// class Program
// {
//     static void Main(string[] args)
//     {
//         int arg=new int();
//         int arg1=new int();
//         int arg2=50;
//         // Passing by value.
//         // arg = 4;
//         squareVal(arg);
//         Console.WriteLine(arg);      // Output: 4

//         // Passing by reference (ref).
//         // arg = 4;
//         squareRef1(ref arg);
//         Console.WriteLine(arg); // Output: 16
//          //Passing by reference (out).
//         squareRef2(out arg1);
//         Console.WriteLine(arg1); // Output: 10
//          // Passing by reference (ref).
//         squareRef3(in arg2);
//         Console.WriteLine(arg2); // Output: 50
//     }

//     static void squareVal(int valParameter)
//     {
//         valParameter *= valParameter;
//         Console.WriteLine("Pass by Value using in: {0}", valParameter);


//     }

//     // Passing by reference (ref)
     
//     static void squareRef1(ref int refParameter)
//     {
//         refParameter *= refParameter;
//     }
//     // Passing by reference (out)
     
//     static void squareRef2(out int refParameter)
//     {
//         refParameter = 10;
//     }
//      // Passing by reference (in)
     
//     static void squareRef3(in int refParameter)
//     { 

//         Console.WriteLine("Pass by reference using in: {0}", refParameter);
//     }
// }