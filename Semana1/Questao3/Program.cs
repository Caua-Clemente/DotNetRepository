int x, y, z;

double vdouble = 10.4;
x = ((int)vdouble);

vdouble = 10.6;
y = ((int)vdouble);

vdouble = 10.9;
z = ((int)vdouble);

Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);
Console.WriteLine("z: " + z);
Console.WriteLine("A conversao de double pra int nao arredonda o valor, mas 'corta' totalmente a parte fracionaria");
Console.WriteLine("Podemos pegar o valor do double e subtrair ao valor do inteiro, sobrando apenas a parte fracionaria.");
Console.WriteLine("vdouble: " + vdouble);
Console.WriteLine("vdouble - z: " + (vdouble - z));

