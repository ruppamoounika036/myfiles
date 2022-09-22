// class AsyncClass{
//     public static void Main(){ 
//         var action = new Action<int>((n) =>   
//         {  
//             for (int i = 0; i < n; i++)  
//             {  
//                 Task.Delay(5000);  
//                 Console.WriteLine($"{i}");  
//             }  
//         });  
        
//         Task myTask = new Task(() => { action(5); });  
//         myTask.Start();  
//         myTask.Wait();  
//             }
        
//         }
