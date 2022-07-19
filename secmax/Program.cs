int [] n =  new int [] {1, 2, 3, 4, 5, 6, 7, 0, 8, 9, 10};
int i = 0;
int first=0;
int second=0;


while (n[i]>0)
{
    if (n[i]>first)
    {
    second = first;
    first = n[i];
    i++;
    }

    
    else if (n[i]>second)
    {
        second = n[i];
        i++;
    }
}
Console.WriteLine(second);
