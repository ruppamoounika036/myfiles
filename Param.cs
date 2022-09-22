// class ParamsExample
// {
//     string? FirstName;
//     string? LastName;
//     int Age;

//     ParamsExample(string? PFirstName,string? PLastName,int PAge){
//         FirstName = PFirstName;
//         LastName = PLastName;
//         Age = PAge;
//     }
//     static void Main()
//     {
//         Console.Clear();
//         string fromArray = GetVowels(new[] { "apple", "banana", "pear" }); //Parameter as an array
//         Console.WriteLine($"Vowels from array: '{fromArray}'");

//         string fromMultipleArguments = GetVowels("apple", "banana", "pear"); //Passing with comma
//         Console.WriteLine($"Vowels from multiple arguments: '{fromMultipleArguments}'");
        
//         string fromNull = GetVowels(null);
//         Console.WriteLine($"Vowels from null: '{fromNull}'");

//         string fromNoValue = GetVowels();
//         Console.WriteLine($"Vowels from no value: '{fromNoValue}'");

//         ParamsExample per = new ParamsExample("Mounika","Ruppa",21);
//         var person = per.GetPersonalInfo(per);
//         Console.WriteLine($"{person.Item1} {person.Item2}: age = {person.Item3}");

//         var person1 = per.GetPersonalInfoo(per);
//         Console.WriteLine($"{person1.FName} {person1.LName}: age = {person1.Age}");
//     }

//     public (string, string, int) GetPersonalInfo(ParamsExample per)
//     {
//         return (per.FirstName, per.LastName, per.Age);
//     }
//     public (string FName, string LName, int Age) GetPersonalInfoo(ParamsExample per)
//     {
//         return (per.FirstName, per.LastName, per.Age);
//     }

//     static string GetVowels(params string[] input)
//     {
//         if (input == null || input.Length == 0)
//         {
//             return string.Empty;
//         }

//         var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
//         return string.Concat(
//             input.SelectMany(
//                 word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
//     }
// }
