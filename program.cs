// a simple C# program
Console.WriteLine("Hello, World!");
// data types
string isim= "Enes";
int yas= 19;
Console.WriteLine($"Benim adım {isim} ve yaşım {yas}");
//if else structure
int a= 76;
if (a >= 85)
{
    Console.WriteLine("Notunuz AA");
}
else if (a >= 70)
{
    Console.WriteLine("Notunuz BA");
}
else
{
    Console.WriteLine("Notunuz FF");
}   

int can= 100;
bool iksir_var= true;

if (can == 0)
{
    Console.WriteLine("Öldünüz");
}
else if (can > 0 && iksir_var == true)
{
    Console.WriteLine("Canınız var ve iksiriniz var");
}

else
{
    Console.WriteLine("Canınız var ama iksiriniz yok");
}

int can_2=20;
while (can_2 > 0)
{
    Console.WriteLine($"Canınız: {can_2}");
    can_2 -= 5;
}
Console.WriteLine("Canınız bitti");
// functions
int X(int a, int b)
{
    return a * b;
}
Console.WriteLine(X(12, 5));
// OOP example
var myCar = new car();
Console.WriteLine(myCar.araba_bilgisi());

class car
{
    public string renk = "blue";
    public int hiz = 100;
    public string marka = "BMW";

    public (string, string, int) araba_bilgisi()
    {
        return (marka, renk, hiz);
    }
}





