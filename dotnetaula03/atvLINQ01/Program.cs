using System.Security.Cryptography.X509Certificates;

List<int> list = new() {1, 2, 3, 4, 5};
var squareList = list.Select(x => x*x);
Console.WriteLine($"Original List: {string.Join(", ", list)}");
Console.WriteLine($"Square List: {string.Join(", ", squareList)}");

var summedList = list.Select((x, index) => x + squareList.ElementAt(index));
Console.WriteLine($"Summed List: {string.Join(", ", summedList)}");

var listMultipleThree = list.Where(x => x % 3 == 0).ToList();
listMultipleThree.AddRange(squareList.Where(x => x % 3 == 0).ToList());
listMultipleThree.AddRange(summedList.Where(x => x % 3 == 0).ToList());
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleThree)}");
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleThree.Order())}");
