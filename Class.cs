// class Member  
// {  
//     public Member()  
//     {  
//         Console.WriteLine("Default Constructor was called.");  
//     }  
  
//     public Member(string name)  
//     {  
//         Console.WriteLine("Parameterized Constructor was called. Name: {0}",name);  
//     }  
//       ~Member()  
//     {  
//         Console.WriteLine("Destructor was called.");  
//     }  
  
    
// }   
// class Program    
// {    
//     static void Main(string[] args)    
//     {    
//         Member member1 = new Member();    
                
//         Member member2 = new Member("Mounika");    
     
//     }    
// }    
/****************Copy Constructor*****************/
// class Demo
// {
// string name;
// int age;
// public Demo(string name, int age) //paramertrized constructor
// {
// this.name = name;
// this.age = age;
// }
// public Demo(Demo d) //copy constructor
// {
// this.name = d.name;
// this.age = d.age;
// }
// public void getData()
// {
// Console.WriteLine("Name is:{0}", name);
// Console.WriteLine("Age is:{0}", age);
// }
// }
// class Program
// {
// static void Main(string[] args){
// Demo obj = new Demo("John",20);
// obj.getData();
// Demo obj1 = new Demo(obj);  
// obj1.getData();
// }
// }