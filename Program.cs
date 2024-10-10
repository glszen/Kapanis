//Soru 1:
using System.Threading.Channels;

Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen Nasılsın ?");
Console.ReadKey();

//Soru 2:

string Letter = "Metin";
int Value = 0;

Console.WriteLine(Letter + Value);

//Soru 3

Random rnd = new Random();
int x = rnd.Next(1, 10);
Console.WriteLine(x);

//Soru 4

Random rnd = new Random();
int y = (rnd.Next(1, 10) % 3);

Console.WriteLine(y);

//soru 5

int yas;
Console.Write("Kaç Yaşındasınız?: ");
yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(yas >= 18 ? "+" : "-");

//soru 6

using System.Runtime.ConstrainedExecution;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//soru 7

Console.Write("İsim a: ");
string isim = Console.ReadLine();

Console.Write("İsim b: ");
string isim2 = Console.ReadLine();

Console.WriteLine("Önce: " + isim + isim2);
Console.WriteLine("Önce: " + isim2 + isim);

//soru 8

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

//soru 9

int sayi(int x, int y)
{
    return x + y;
}
Console.WriteLine(sayi(1254, 74546));

//soru 10

string TrueFalse(bool c)
{
    return c ? "Evet" : "Hayır";
}

Console.WriteLine("Yemek yemeyi sever misin?\r\n" + TrueFalse(true));

// soru 11

int Age(int age1, int age2, int age3)
{
    return Math.Max(Math.Max(age1, age2), age3);
}
Console.WriteLine(Age(52, 11, 2));

//soru 12

static int Endless(params int[] dizi)
{
    return dizi.Max();
}

Console.WriteLine(Endless(4, 6, 889, 6542, 653, 54, -100, 5613, 354));

//soru 13
using System.ComponentModel.DataAnnotations;
using System.Xml;

/
void Change(ref string x, ref string y)
{
    string hold = x;
    x = y;
    y = hold;
}

Console.WriteLine("İsim1: ");
string isim1 = Console.ReadLine();
Console.WriteLine("İsim2: ");
string isim2 = Console.ReadLine();

Console.WriteLine("Başlangıç: {0} {1}", isim1, isim2);

Change(ref isim1, ref isim2);

Console.WriteLine("Başlangıç: {0} {1}", isim1, isim2);

//soru 14

bool TekCift(int value) => value % 2 == 0; //Tek bir returnden oluşuyorsa bu şekilde kullanılabilir.

Console.WriteLine("Sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TekCift(sayi) ? "Çift" : "Tek");

//soru 15

x = V * t

double Yol(double hiz, double sure)
{
    return hiz * sure;
}

Console.WriteLine("Saatte 200km giden bir aracın ne kadar yol gideceğini hesaplayınız");
Console.WriteLine(Yol(200, 5));

//soru 16

double Daire(double r)
{
    return Math.PI * r * r;
}
Console.WriteLine("Yarıçap: ");
double yariCap = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dairenin Alanı: " + Daire(yariCap));

// soru 17

string letter = "Zaman bir GeRi SayIm";
Console.WriteLine(letter.ToUpper());
Console.WriteLine(letter.ToLower());

//soru 18

string letter = "    Selamlar   ";
letter = letter.Trim();
Console.WriteLine(letter);