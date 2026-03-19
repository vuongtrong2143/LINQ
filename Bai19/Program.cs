// See https://aka.ms/new-console-template for more information
Console.WriteLine("2415053122143 - Nguyen Vuong Trong - 225LTC#02");

List<int> numbers = new List<int> { 1, 3, 4, 2, 3, 3, 1, 5, 3 };

int phantu = numbers.GroupBy(x => x) // Nhom cac so giong nhau lai voi nhau
                          .OrderByDescending(g => g.Count()) // Sap xep giam dan dua tren so luong phan tu cua moi nhom
                          .Select(g => g.Key) // Chon ra gia tri dai dien cua moi nhom
                          .FirstOrDefault(); // Lay phan tu dau tien

Console.WriteLine($"So xuat hien nhieu nhat la: {phantu}");