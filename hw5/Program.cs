
int cnt=0;
int Num(int a)
{
    if(a==0)
    {
        return cnt; 
    }
    else
    {
        cnt++;
        return Num(a/10);

    }
}
System.Console.WriteLine(Num(1234));