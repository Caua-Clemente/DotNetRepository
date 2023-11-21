string person = Console.ReadLine() ?? "";

Func<string, int, string> isBiggerThan = (string s, int x) => s.Length > x ? "Yes" : "NO";
var size = 5; 
Console.WriteLine($"The text {person} has more than {size} chars? {isBiggerThan(person, size)}");
