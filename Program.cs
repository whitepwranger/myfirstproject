
Console.WriteLine("Hello, World!");


int a = 0, b = 0, c = 0;

// Задача 2
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if(a > b){
    Console.WriteLine(a);
}else{
    Console.WriteLine(b);
}
// Задача 4
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if(a > b){
    if(a > c)
        Console.WriteLine(a);
    else Console.WriteLine(c);
}else if(b > c){
    Console.WriteLine(b);
}else Console.WriteLine(c);
// Задача 6
a = int.Parse(Console.ReadLine());
if (a % 2 == 0){
    Console.WriteLine("Четное!");
}else{
    Console.WriteLine("Нечетное!");
}
//Задача 8
int N = int.Parse(Console.ReadLine());

for(int i = 1; i < N; ++i){
    if(i % 2 == 0) Console.Write(i.ToString() + ' ');
}
