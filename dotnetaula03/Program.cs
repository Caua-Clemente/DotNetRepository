using System.IO.Compression;
using System.Runtime.CompilerServices;

//using System.Globalization;
//CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

var tuple1 = (10, 20);
Console.WriteLine($"Tupla 1: {tuple1.Item1}, {tuple1.Item2}");

var tuple2 = (x: 5, y: 50);
Console.WriteLine($"Tupla 2: {tuple2.x}, {tuple2.y}");

var tuple3 = (id: 10, name: "Helder", born: new DateTime(1987, 9, 24));
Console.WriteLine($"Tupla 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "Nicole", new DateTime(2019, 1, 12)));
list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));

