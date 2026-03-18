// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

var cacsochan = from n in numbers
                where (n % 2 == 0)
                select n;
Console.WriteLine("Danh sach cac so chan: ");
foreach (var n in cacsochan)
    Console.Write($"{n} ");