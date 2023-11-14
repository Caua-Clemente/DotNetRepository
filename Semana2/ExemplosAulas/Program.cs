/* 
0
string[] people = { "Maria", "João", "José", "Ana" };

foreach(string person in people){
    Console.WriteLine(person);
}

*/

/*
1
for(int i = 0; i < 30; i++){
    if(i % 3 == 0 || i % 4 == 0)
        Console.WriteLine(i);
}
*/

/*
2
int a = 0, b = 1, c = 0;
while(a < 100){
    Console.WriteLine(a);
    c = a;
    a += b;
    b = c;
}
*/

for(int i = 1; i <= 8; i++){
    for(int j = 1; j <= i; j++){
        {Console.WriteLine(i * j);}
    }
    Console.WriteLine("---");
}