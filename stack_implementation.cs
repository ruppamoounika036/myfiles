// namespace Mystackimp{
// class MyStack<T>
// {
//    int size;
//    T[] stack;
//    int top=-1; 

//    public MyStack(int MaxSize)
//    {
//        size = MaxSize;
//        stack = new T[size];
//    }
//    public void push(T value)
//    {
//        if (top == size - 1)
//        {
//            Console.WriteLine("Overflow");
//        }
//        else
//        {
// 		  top = top + 1;
//            stack[top] = value;

//        }
//    }
 

//    public void pop()
//    {

//        if(top>0)
//        {
//              top = top-1;

//        }
// 	   else{
// 		Console.WriteLine("UnderFlow");
// 	   }
//    }
//    public void peek()
//    { 
// 	if(top<=0){
// 		Console.WriteLine("UnderFlow");
		
// 	}
// 	else{
// 	    Console.WriteLine(stack[top]);
// 	}
//    } 
// }

// }