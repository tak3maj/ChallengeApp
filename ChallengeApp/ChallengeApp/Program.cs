int number = 259050229;
string numberAsString = number.ToString();
char[] digits = numberAsString.ToCharArray();

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

foreach (char digit in digits)
{
    if (digit == '0')
    {
        count0++;
    }
    else if (digit == '1')
    {
        count1++;
    }
    else if (digit == '2')
    {
        count2++;
    }
    else if (digit == '3')
    {
        count3++;
    }
    else if (digit == '4')
    {
        count4++;
    }
    else if (digit == '5')
    {
        count5++;
    }
    else if (digit == '6')
    {
        count6++;
    }
    else if (digit == '7')
    {
        count7++;
    }
    else if (digit == '8')
    {
        count8++;
    }
    else if (digit == '9')
    {
        count9++;
    }
}
List<string> dig = new List<string>();
dig.Add("0 =>" + count0);
dig.Add("1 =>" + count1);
dig.Add("2 =>" + count2);
dig.Add("3 =>" + count3);
dig.Add("4 =>" + count4);
dig.Add("5 =>" + count5);
dig.Add("6 =>" + count6);
dig.Add("7 =>" + count7);
dig.Add("8 =>" + count8);
dig.Add("9 =>" + count9);

foreach (var cyfra in dig)
    Console.WriteLine(cyfra);