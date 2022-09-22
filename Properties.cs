// /********************Instance************************/
// class MyClass  
// {  
//     private int x;  
//     public int X  
//     {  
//         get  
//         {  
//             return x;  
//         }  
//         set  
//         {  
//             x = value;  
//         }  
//     }  
// }  
// class MyClient  
// {  
//     public static void Main()  
//     {  
//         MyClass mc = new MyClass();  
//         mc.X = 10;  
//         int xVal = mc.X;  
//         Console.WriteLine(xVal);//Displays 10  
//     }  
// }  
// /****************************static******************************/
// // class MyClass  
// // {  
// //     private static int x;  
// //     public static int X  
// //     {  
// //         get  
// //         {  
// //             return x;  
// //         }  
// //         set  
// //         {  
// //             x = value;  
// //         }  
// //     }  
// // }  
// // class MyClient  
// // {  
// //     public static void Main()  
// //     {  
// //         MyClass.X = 10;  
// //         int xVal = MyClass.X;  
// //         Console.WriteLine(xVal);//Displays 10  
// //     }  
// // } 
// /*****************Inheritance*************************/
// // class Base  
// // {  
// //     public int X  
// //     {  
// //         get  
// //         {  
// //             Console.Write("Base GET");  
// //             return 10;  
// //         }  
// //         set  
// //         {  
// //             Console.Write("Base SET");  
// //         }  
// //     }  
// // }  
// // class Derived : Base  
// // {  
// // }  
// // class MyClient  
// // {  
// //     public static void Main()  
// //     {  
// //         Derived d1 = new Derived();  
// //         d1.X = 10;  
// //         Console.WriteLine(d1.X);
// //     }  
// // }