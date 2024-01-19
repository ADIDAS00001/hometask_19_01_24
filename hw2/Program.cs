
void  Num(int a)
{
    if(a==0)
    {
        return ;
    }
    else 
    {
        System.Console.Write(a+ " ");
        Num( a-1);
    }
}
Num(10);