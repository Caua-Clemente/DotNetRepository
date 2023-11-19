Console.WriteLine("Alguns dos tipos de dados numericos inteiros sao: ");
Console.WriteLine("sbyte (" + sbyte.MinValue + " --------- " + sbyte.MaxValue + ")");
Console.WriteLine("byte (" + byte.MinValue + " --- " + byte.MaxValue + ")");
Console.WriteLine("short (" + short.MinValue + " --- " + short.MaxValue + ")");
Console.WriteLine("ushort (" + ushort.MinValue + " --- " + ushort.MaxValue + ")");
Console.WriteLine("int (" + int.MinValue + " --- " + int.MaxValue + ")");
Console.WriteLine("uint (" + uint.MinValue + " --- " + uint.MaxValue + ")");
Console.WriteLine("long (" + long.MinValue + " --- " + long.MaxValue + ")");
Console.WriteLine("ulong (" + ulong.MinValue + " --- " + ulong.MaxValue + ")");
Console.WriteLine("nint (Varia da plataforma)");
Console.WriteLine("nuint (Varia da plataforma)");

Console.WriteLine("Dados mais leves (como sbyte, short) sao mais utilizados quando precisamos usar o minimo de memoria possivel, como em alguns sistemas embarcados.");
Console.WriteLine("Dados maiores (como ulong) sao utilizados quando trabalhamos com numeros muito maiores (e temos mais disponibilidade de memoria).");
Console.WriteLine("Quando nao precisamos utilizar numeros negativos, podemos criar um tipo unsigned, isto e, utiliza o 'espaco destinado aos numeros negativos' e 'coloca no espaco do positivo'.");