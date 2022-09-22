// namespace CustomExtension
// {
//  public static class ExtensionSquareMethod
//  {
//   public static List<int> SquareAll(this List<int> lt)
//  {
//   for (int i = 0; i < lt.Count; i++)
//   {
//   lt[i] = lt[i] * lt[i];
//  }
//   return lt;
//   }
//  }
// }
// namespace SquareCustom
// {
//   using CustomExtension;
//   class Square
//  {
//   public static void Main(string[] args)
//  {
//   List<int> myList = new List<int>();
//   myList.Add(9);
//   myList.Add(8);
//   myList.Add(7);
//   myList.Add(6);
//   myList.SquareAll();
//  foreach (int i in myList)
//   {
//   Console.WriteLine(i);
//   }
//   }
//   }
// }

