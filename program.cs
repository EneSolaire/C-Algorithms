Console.WriteLine("Hello, World!");

int yas= 19;
string isim= "Enes";
Console.WriteLine($"Benim adım {isim} ve yaşım {yas}");

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

   






