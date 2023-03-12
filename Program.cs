Console.WriteLine("*****While*****");
//While

//1' den başlayarak console dan girilen sayıya kadar (sayı dahil) sayıların ortalamasını hesaplayıp console a yazdıran program.

Console.WriteLine("Bir sayi giriniz: ");

int sayi = int.Parse(Console.ReadLine());

int sayac = 1;

int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;
}

Console.WriteLine("Ortalama: " + toplam / sayi);

//A' dan Z'ye kadar tüm harfleri console a yazdıran program.

char character = 'a';

while (character < 'z')
{
    Console.Write(character);
    character ++;
}

Console.WriteLine("*****ForEach*****");
//ForEach

string [] arabalar = {"BMW, Volvo, Audi, Ford"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}