
void  Num(int a)
{
    if(a==1)
    {
        System.Console.Write(1+ " "); 
    }
    else 
    {
        Num( a-1);
        System.Console.Write(a+ " ");
    }
}
Num(10);