// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8 };
//using Query syntax
//var ds = from n in numbers
//         select n * n;
//using Method syntax
var ds = numbers.Select(x => x * x);

Console.WriteLine("Danh sach cac so binh phuong: ");
foreach (var n in ds)
    Console.Write($"{n} ");