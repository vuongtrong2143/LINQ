// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
/*
//using Query syntax
var ds1 = from n in numbers
         where (n % 2 == 0)
         select n;
*/
//using Method syntax
var ds = numbers.Count(x => (x % 2) == 0);
Console.WriteLine($"So cac so chan trong danh sach la: {ds}.");