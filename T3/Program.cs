int x;
x = int.Parse(Console.ReadLine()!);
Console.Write(x + " -> ");
for (int i = 1; i < x ; i++){
    Console.Write((i * i * i) + ", ");
}
Console.WriteLine(x * x * x);