using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

(string, int) CalcAage(string name, DateTime Birthday){
    DateTime dataAtual = DateTime.Now;
    dataAtual = dataAtual.Date;
    Console.WriteLine(dataAtual.ToString(""));

    int age = dataAtual.Year - Birthday.Year;
    if(dataAtual.DayOfYear < Birthday.DayOfYear){
        age--;
    }

    return (name, age);
}

var tupla1 = ("Caua", new DateTime(2004, 1, 6));
(string, int) tupla2 = CalcAage(tupla1.Item1, tupla1.Item2);
Console.WriteLine(tupla2.Item2);


