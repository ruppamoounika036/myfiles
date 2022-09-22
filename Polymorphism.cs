/***********************Overloading*******************************************/
// namespace DemoCsharp  
// {  
//     class Program  
//     {  
//         public int Add(int num1, int num2)  
//         {  
//             return (num1 + num2);  
//         }  
//         public int Add(int num1, int num2, int num3)  
//         {  
//             return (num1 + num2 + num3);  
//         }  
//         public float Add(float num1, float num2)  
//         {  
//             return (num1 + num2);  
//         }  
//         public string Add(string value1, string value2)  
//         {  
//             return (value1 + " " + value2);  
//         }  
//         static void Main(string[] args)  
//         {  
//             Program objProgram = new Program();  
//             Console.WriteLine("Add with two int parameter :{0}", objProgram.Add(3, 2));  
//             Console.WriteLine("Add with three int parameter :" + objProgram.Add(3, 2, 8));  
//             Console.WriteLine("Add with two float parameter :" + objProgram.Add(3f, 22f));  
//             Console.WriteLine("Add with two string parameter :" + objProgram.Add("hello", "world"));  
//             Console.ReadLine();  
//         }  
//     }  
// }  
/***********************Override And Virtual**********************************/
// class Animal  
// {
//   public virtual void animalSound() 
//   {
//     Console.WriteLine("The animal makes a sound");
//   }
// }

// class Pig : Animal   
// {
//   public override void animalSound() 
//   {
//     Console.WriteLine("The pig says: wee wee");
//   }
// }

// class Dog : Animal  
// {
//   public override void animalSound() 
//   {
//     Console.WriteLine("The dog says: bow wow");
//   }
// }

// class Program 
// {
//   static void Main(string[] args) 
//   {
    // Animal myAnimal = new Animal();   
    // Animal myPig = new Pig();  
    // Animal myDog = new Dog();   

//     myAnimal.animalSound();
//     myPig.animalSound();
//     myDog.animalSound();
//   }
// }
/********************New Modifier****************************/
// public class BaseC
// {
//     public static int x = 55;
//     public static int y = 22;
// }

// public class DerivedC : BaseC
// {

//     new public static int x = 100;
//     static void Main()
//     {
        
//         Console.WriteLine(x);
//         Console.WriteLine(BaseC.x);
//         Console.WriteLine(y);
//     }
// }
/*
Output:
100
55
22
*/
/*****************************New modifier for nested classes***********************************/
// public class BaseC
// {
//     public class NestedC
//     {
//         public int x = 200;
//         public int y;
//     }
// }

// public class DerivedC : BaseC
// {
//     new public class NestedC
//     {
//         public int x = 100;
//         public int y;
//         public int z;
//     }

//     static void Main()
//     {
        
//         NestedC c1  = new NestedC();
//         BaseC.NestedC c2 = new BaseC.NestedC();
//         Console.WriteLine(c1.x);
//         Console.WriteLine(c2.x);
//     }
// }
// /*
// Output:
// 100
// 200
// */
/************************* Base operator ******************************/
// public class Person
// {
//     protected string ssn = "444-55-6666";
//     protected string name = "Mounika Ruppa";

//     public virtual void GetInfo()
//     {
//         Console.WriteLine("Name: {0}", name);
//         Console.WriteLine("SSN: {0}", ssn);
//     }
// }
// class Employee : Person
// {
//     public string id = "C367";
//     public override void GetInfo()
//     {
//         base.GetInfo();
//         Console.WriteLine("Employee ID: {0}", id);
//     }
// }

// class TestClass
// {
//     static void Main()
//     {
//         Employee E = new Employee();
//         E.GetInfo();
//     }
// }
// /*
// Output
// Name: Mounika Ruppa
// SSN: 444-55-6666
// Employee ID: C367
// */
/*********************base-class constructor using base*********************/
// public class BaseClass
// {
//     int num;

//     public BaseClass()
//     {
//         Console.WriteLine("in BaseClass()");
//     }

//     public BaseClass(int i)
//     {
//         num = i;
//         Console.WriteLine("in BaseClass(int i)");
//     }

//     public int GetNum()
//     {
//         return num;
//     }
// }

// public class DerivedClass : BaseClass
// {
//     public DerivedClass()
//     {
//          Console.WriteLine("in derivedClass()");
//     }
//     public DerivedClass(int i) 
//     {
       
//         Console.WriteLine("in Derived(int i)");
//     }

//     static void Main()
//     {
//         DerivedClass md = new DerivedClass();
//         DerivedClass md1 = new DerivedClass(1);
//     }
// }
// // /*
// // Output:
// // in BaseClass()
// // in BaseClass(int i)
// // */
 