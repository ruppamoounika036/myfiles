// // using System;

// namespace Sample{
// public enum Season
//         {
//             Spring,
//             Summer,
//             Autumn,
//             Winter
//         }
// class HelloWorld
// {
//     static void Main()
//     {
//         // int? a = null;
//         // string? x;
//         // string? x;
//         // Console.WriteLine("Hello, world!");
//         //command line arguments
//         //  string[] arguments = Environment.GetCommandLineArgs();
//         // Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", arguments));
//         // Console.WriteLine("GetCommandLineArgs: {0}", string.Join("  ", arguments));
//         // Console.WriteLine("GetCommandLineArgs: {0}", arguments[0]);
//         // Console.WriteLine("GetCommandLineArgs: {0}", arguments[1]);
//         // Console.WriteLine(
//         //     "(C) Currency: . . . . . . . . {0:C}\n" +
//         //     "(D) Decimal:. . . . . . . . . {0:D}\n" +
//         //     "(E) Scientific: . . . . . . . {1:E}\n" +
//         //     "(F) Fixed point:. . . . . . . {1:F}\n" +
//         //     "(G) General:. . . . . . . . . {0:G}\n" +
//         //     "    (default):. . . . . . . . {0} (default = 'G')\n" +
//         //     "(N) Number: . . . . . . . . . {0:N}\n" +
//         //     "(P) Percent:. . . . . . . . . {1:P}\n" +
//         //     "(R) Round-trip: . . . . . . . {1:R}\n" +
//         //     "(X) Hexadecimal:. . . . . . . {0:X}\n",
//         //     -123, -123.45f);
//         // a = Console.Read();
//         // x = Console.ReadLine();
//         // Console.WriteLine("{0}",Convert.ToDecimal(a));
//         // Console.WriteLine("{0}",Convert.ToChar(a));
//         // Console.WriteLine("{0}",a);
//         // Console.WriteLine("String {0}",x);
//         // Console.WriteLine(x);
//         // Console.WriteLine("\r\n",Console.ReadKey());
//         // Console.WriteLine(Console.ReadKey());
//         // Console.Write("Hey");
//         // Console.Write("In Write");
//         // Console.Clear();
//         // Season a = Season.Autumn;
//         // Console.WriteLine($"Integral value of {a} is {(int)a}");  
//         // var b = (Season)1;
//         // Console.WriteLine(b); 
//         // var c = (Season)4;
//         // Console.WriteLine(c);  
//         // x = Console.ReadLine();
//         // Console.WriteLine($"{x}");
//         // Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");
//         // Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");

//         // bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;
//         int i = 3;
//         Console.WriteLine(i);   
//         Console.WriteLine(i++); //postfix increment
//         Console.WriteLine(i);   
//         double a = 1.5;
//         Console.WriteLine(a);  
//         Console.WriteLine(++a); //prefix increment
//         Console.WriteLine(a);
//         //postfic decrement
//         Console.WriteLine(i);   
//         Console.WriteLine(i--); 
//         Console.WriteLine(i);  
//         //prefix decrement
//         Console.WriteLine(a);   
//         Console.WriteLine(--a); 
//         Console.WriteLine(a);  
//         Console.WriteLine(+4);     // output: 4

//         Console.WriteLine(-4);     // output: -4
//         Console.WriteLine(-(-4));  // output: 4

//         uint a1 = 5;
//         var b = -a1;
//         Console.WriteLine(b);            // output: -5
//         Console.WriteLine(b.GetType());  // output: System.Int64

//         Console.WriteLine(-double.NaN);  // output: NaN
//         Console.WriteLine(0.1m * 23.4m);  // output: 2.34
//         Console.WriteLine(13 / 5);    // output: 2
//         Console.WriteLine(-13 / 5);   // output: -2
//         Console.WriteLine(13 / -5);   // output: -2
//         Console.WriteLine(-13 / -5);  // output: 2
//         Console.WriteLine(13 / 5.0);       // output: 2.6
//         Console.WriteLine((double)a / b);  // output: 2.6
//         Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
//         Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
//         Console.WriteLine(16.8m / 4.1m);   // output: 4.0975609756097560975609756098
//         Console.WriteLine(5 % 4);   // output: 1
//     Console.WriteLine(5 % -4);  // output: 1
//     Console.WriteLine(-5 % 4);  // output: -1
//     Console.WriteLine(-5 % -4); // output: -1
//     }
// }
// }