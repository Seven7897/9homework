System.Console.WriteLine($"Диапазон цисел которые хотите найти от :");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("До :");
int last = Convert.ToInt32(Console.ReadLine());
string NumberRange(int n , int m)
{
    if (n == m)  return n.ToString();
    return( n + "," +  NumberRange(n+1 , m));
}

System.Console.WriteLine(NumberRange(first,last));