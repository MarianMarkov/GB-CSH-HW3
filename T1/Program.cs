int x;

int PalindromeCheck(int num)
{
    if ((num % 10 == num / 10000) && (num / 1000 % 10 == num % 100 / 10))
    {
        return(num);
    }
    else
    {
        return(num + num);
    }
 
}
x = int.Parse(Console.ReadLine()!);
if (PalindromeCheck(x) == x) {
    Console.WriteLine(x + " -> да");
}
else {
    Console.WriteLine(x + " -> нет");
}
