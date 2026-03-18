// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

var ds = from n in numbers
                where (n > 5)
                select n;
Console.WriteLine("Danh sach cac so lon hon 5: ");
foreach (var n in ds)
    Console.Write($"{n} ");