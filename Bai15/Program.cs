// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> danhsach = new List<int>() { 1,2,2,3,4,4,5};

var sv = danhsach.Distinct();
Console.WriteLine("Danh sach sau loai bo phan tu trung: ");
foreach (int i in sv)
    Console.Write($"{i} ");