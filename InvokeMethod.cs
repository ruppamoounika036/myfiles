/**************************************static*****************************************************/
// public class SquareExample
// {
//    public static void Main()
//    {
//       // Call with an int variable.
//       int num = 4;
//       int productA = Square(num);
      
//       // Call with an integer literal.
//       int productB = Square(12);

//       // Call with an expression that evaluates to int.
//       int productC = Square(productA * 3);
//       Console.WriteLine("{0},{1},{2}",productA,productB,productC);
//    }

//    static int Square(int i)
//    {
//       int input = i;
//       return input * input;
//    }
// }
/****************************************Instance*******************************************************/
// using System;

// public class SampleRefType
// {
//     public int value;
// }

// public class ByRefTypeExample
// {
//     public static void Main()
//     {
//         var rt = new SampleRefType();
//         rt.value = 44;
//         ModifyObject(rt);
//         Console.WriteLine(rt.value);
//     }

//     static void ModifyObject(SampleRefType obj)
//     {
//         obj.value = 33;
//     }
// }