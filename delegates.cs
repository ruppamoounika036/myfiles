/************************************Delegates********************************************/
// namespace GeeksForGeeks {
// class Geeks {
// public delegate void addnum(int a, int b);
// public delegate void subnum(int a, int b);
// 	public void sum(int a, int b)
// 	{
// 		Console.WriteLine("(100 + 40) = {0}", a + b);
// 	}
// 	public void subtract(int a, int b)
// 	{
// 		Console.WriteLine("(100 - 60) = {0}", a - b);
// 	}
// public static void Main(String []args)
// {
// 	Geeks obj = new Geeks();
// 	dynamic del_obj1 = new addnum(obj.sum);
// 	dynamic del_obj2 = new subnum(obj.subtract);
// 	del_obj1(100, 40);
// 	del_obj2(100, 60);
// }
// }
// }
/*************************** Multicasting delegates *****************************************************/

// class rectangle {
// public delegate void rectDelegate(double height,
// 								double width);

// 	public void area(double height, double width)
// 	{
// 		Console.WriteLine("Area is: {0}", (width * height));
// 	}
// 	public void perimeter(double height, double width)
// 	{
// 		Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
// 	}
// public static void Main(String []args)
// {
// 	rectangle rect = new rectangle();
// 	rectDelegate rectdele = new rectDelegate(rect.area); 
// 	rectdele += rect.perimeter;
// 	rectdele.Invoke(6.3, 4.2);
// 	Console.WriteLine();
// 	rectdele.Invoke(16.3, 10.3);
// }
// }
/************************ Func delegates *************************/
// class Program  
//    {  
//        static void Main(string[] args)  
//        {  
//            Func<int,int,int> Addition = AddNumbers;  
//            int result = Addition(10, 20);  
//            Console.WriteLine($"Addition = {result}");  
//        }  
  
//        public int AddNumbers(int param1, int param2 )  
//        {  
//            return param1 + param2;  
//        }          
//   } 
/************************ func delegates - Anonymous methods ******************************/
// class Program1
// {
//     static void Main()
//     {
//         Func<int,int,int> Addition = delegate (int param1, int param2)    
//         {    
//             return param1 + param2;    
//         };    
//         int result = Addition(10, 20);    
//         Console.WriteLine($"Addition = {result}");  
//     }
// }
/********************** func delegates - Lambda functions ***********************************/
// class Program3{
//  static void Main(){
//         Func<int, int, int> Addition = (param1, param2) => param1 + param2;  
//         int result = Addition(10, 20);  
//         Console.WriteLine($"Addition = {result}"); 
//  }
// }
/*********************** Action Delegate **************************************************/
// class Program4{
//     private static int result;  
//         static void Main(string[] args)  
//         {  
//             Action<int, int> Addition = AddNumbers;  
//             Addition(10, 20);  
//             Console.WriteLine($"Addition = {result}");  
//         }  
  
//         private static void AddNumbers(int param1, int param2 )  
//         {  
//             result = param1 + param2;  
//         } 
// }
/******************** Action Delegate - anonymous *******************************************/
// class Program5{
//     private static int result;  
//        static void Main(string[] args)  
//        {  
//            Action<int, int> Addition = delegate (int param1, int param2)  
//            {  
//                result = param1 + param2;  
//            };  
//            Addition(10, 20);  
//            Console.WriteLine($"Addition = {result}");  
//        } 
// }
/********************* Action Delegate - Lambda ***********************************/ 
// class Program6{
//         public static int result;
  
//     static void Main(){
//         Action<int,int> Addition = (param1 , param2) =>result = param1 + param2;
//         Addition(30,40);
//         Console.WriteLine($"{result}");
//     }
// }
/***************** Predicate Delegate ******************************************/
// class Program  
// {  
//     static void Main(string[] args)  
//     {  
//         Predicate<string> CheckIfApple = IsApple;  
//         bool result  = IsApple("I Phone X");  
//         if(result)  
//         Console.WriteLine("It's an IPhone");  
//     }  
  
//     private static bool IsApple(string modelName)  
//     {  
//         if (modelName == "I Phone X")  
//             return true;  
//         else  
//             return false;  
//     }  
// }  
/***************** predicate delegates - anonymous *************************/
// class Program  
// {  
//     public static void Main(){
//     Predicate < string > CheckIfApple = delegate(string modelName) {  
//     if (modelName == "I Phone X") return true;  
//     else return false;  
// };  
// bool result = CheckIfApple("I Phone X");  
// if (result) Console.WriteLine("It's an IPhone");  
// }  
// }
// /**************** predicate delegates - lambda **************************/
// class Program{
//     public static void Main(){
//         Predicate < string > CheckIfApple = modelName => {  
//         if (modelName == "I Phone X") return true;  
//         else return false;  
//     };  
//     bool result = CheckIfApple("I Phone X");  
//     if (result) Console.WriteLine("It's an IPhone"); 
//     }
// }