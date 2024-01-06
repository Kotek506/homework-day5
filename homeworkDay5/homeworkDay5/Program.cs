int number = 2137;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int count0 = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;

foreach (char l in letters)
{
    if (l == '0')
    {
        count0++;
    }
    else if (l == '1')
    {
        count1++;
    }
    else if (l == '2')
    {
        count2++;
    }
    else if (l == '3')
    {
        count3++;
    }
    else if (l == '4')
    {
        count4++;
    }
    else if (l == '5')
    {
        count5++;
    }
    else if (l == '6')
    {
        count6++;
    }
    else if (l == '7')
    {
        count7++;
    }
    else if (l == '8')
    {
        count8++;
    }
    else if (l == '9')
    {
        count9++;
    }
}
Console.WriteLine("wyniki dla liczby " + number);
Console.WriteLine("0 => " + count0);
Console.WriteLine("1 => " + count1);
Console.WriteLine("2 => " + count2);
Console.WriteLine("3 => " + count3);
Console.WriteLine("4 => " + count4);
Console.WriteLine("5 => " + count5);
Console.WriteLine("6 => " + count6);
Console.WriteLine("7 => " + count7);
Console.WriteLine("8 => " + count8);
Console.WriteLine("9 => " + count9);
