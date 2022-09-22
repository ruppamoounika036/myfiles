// namespace OptionalNamespace
// {
//     class OptionalExample
//     {
//         static void Main(string[] args)
//         {
//             // Instance anExample does not send an argument for the constructor's
//             // optional parameter.
//             ExampleClass anExample = new ExampleClass();
//             anExample.ExampleMethod(1, "One", 1);
//             anExample.ExampleMethod(2, "Two");
//             anExample.ExampleMethod(3);

        
//             // optional parameter.
//             ExampleClass anotherExample = new ExampleClass("Provided name");
//             anotherExample.ExampleMethod(1, "One", 1);
//             anotherExample.ExampleMethod(2, "Two");
//             anotherExample.ExampleMethod(3);
//             anExample.ExampleMethod(3, optionalint: 4);
//         }
//     }

//     class ExampleClass
//     {
//         private string _name;
//         public ExampleClass(string name = "Default name")
//         {
//             _name = name;
//         }
//         public void ExampleMethod(int required, string optionalstr = "default string",
//             int optionalint = 10)
//         {
//             Console.WriteLine(
//                 $"{_name}: {required}, {optionalstr}, and {optionalint}.");
//         }
//     }
// }