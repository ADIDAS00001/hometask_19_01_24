

void Num(int a)
{
    if(a==0)
    {
        return ;
    }
    else 
    {
        Num(a/10);
        System.Console.Write($"{a%10} ");
    }
}
Num(1234);
