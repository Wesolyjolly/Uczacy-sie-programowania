const string quote = "\"";
string name = "Ewa";
bool woman = false;
int age = 50;

if (woman == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("(2): " + quote + name + ", lat " + age + quote);
    }
    else
    {
        if (age < 30)
        {
            Console.WriteLine("(1): " + quote + "Kobieta ponizej 30 lat" + quote);
        }
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("(3): " + quote + "Nieplnoletni Mężczyzna" + quote);
    }
else
    {
        Console.WriteLine("(4): " + quote + "Pełnoletni Mężczyzna" + quote);
    }
    Console.WriteLine("\n");
    Console.WriteLine("Uczący się programowania w c#");
}
