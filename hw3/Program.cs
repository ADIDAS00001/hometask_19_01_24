int  Num(int a)
{
    if(a==0)
    {
        return 0;
    }
    else 
    {
        return a+Num(a-1);
    }
}
System.Console.WriteLine(Num(10));