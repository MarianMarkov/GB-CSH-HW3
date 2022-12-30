int x;
int PrimeCheck(int num){
    for (int k = 2; k < Math.Round(Math.Sqrt(num)) + 1; k++){
        if (num % k == 0){
            return 0;
        }
    }
    return 1;
}
x = int.Parse(Console.ReadLine()!);
Console.Write(x + " -> ");
for (int i = 1; i < (x + 1); i++){
    
    if (PrimeCheck(i) == 1){
        Console.Write(i + ", ");
    }
}
