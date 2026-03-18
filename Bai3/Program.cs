// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int>() { 24, 150, 53, 12, 21, 43 };

var ds = from n in numbers
         orderby n
         select n;
Console.WriteLine("Danh sach cac so theo thu tu tang dan: ");
foreach (var n in ds)
    Console.Write($"{n} ");