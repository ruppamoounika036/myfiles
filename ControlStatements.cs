   
// public class IfExample  
//     {  
//        public static void Main(string[] args)  
//         {  
//             int num = 10;
//             Console.WriteLine("Print array:");
//             int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
//             //for
//             for(int items = 0; items < a_array.Length; items++)
//             {
//             Console.WriteLine(a_array[items]);
//             }
//             //foreach
//             foreach(int items in a_array)
//             {
//                 Console.WriteLine(items);
//             }  
//             //if else
//             if (num % 2 == 0)  
//             {  
//                 Console.WriteLine("It is even number");  
//             }  
//             else{
//                 Console.WriteLine("Odd");
//             }
//             //switch           
//             switch (num) 
//             {
//             case 1:
//                 Console.WriteLine("output:10");
//                 break;
//             case 20:
//                 Console.WriteLine("output:20");
//                 break;
//             default:
//                 Console.WriteLine("neither 20 nor 10");
//                 break;
            
//             }
//             //while
//                             while(num>0){
//                         Console.WriteLine(num);
//                         if(num==3){
//                             break;
//                         }
//                         else{
//                             num-=1;
//                             continue;
//                         }
//                     }

//         }  
//     }  
/***************single dimensional*****************/
//  int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
// foreach (int i in numbers)
// {
//      Console.Write("{0} ", i);
// }
/**************two-dimensional********************/
// int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
// foreach (int i in numbers2D)  
// {
//     System.Console.Write("{0} ", i);
// }
/**************Jagged-Array**********************/
// int[][] jArray = new int[2][]{
//                 new int[3]{1, 2, 3};
//                 new int[4]{4, 5, 6, 7}
//             };

// Console.WriteLine(jArray[0][0]); //returns 1 
// Console.WriteLine(jArray[0][1]); //returns 2
// Console.WriteLine(jArray[0][2]); //returns 3
// Console.WriteLine(jArray[1][0]); //returns 4
// Console.WriteLine(jArray[1][1]); //returns 5
// Console.WriteLine(jArray[1][2]); //returns 6
// Console.WriteLine(jArray[1][3]); //returns 7

 

