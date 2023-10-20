var name = "Zosia";
var sex = "woman";
var age = 33;

if (sex == "woman")
{
    if (name == "Ewa")
    {
        if (age == 33)
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else if (age < 30)
        {
            Console.WriteLine("Kobieta poniżej 30 lat");
        }
        else
        {
            Console.WriteLine("Kobieta powyżej 30 lat");
        }
    }
    else
    {
        Console.WriteLine("Na pewno nie jestem Ewą");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
