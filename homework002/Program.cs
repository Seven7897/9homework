System.Console.WriteLine("Введите первое неотрицательное  число :");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе неотрицательное  число :");
int second = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int m , int n)
{
    if (m == 0) return n + 1;
    else
    {
        if(  m > 0 && n == 0) return AckermannFunction(m-1,1);
        else return AckermannFunction(m-1, (AckermannFunction(m , n-1)));
    }
}
System.Console.WriteLine(AckermannFunction(first,second));