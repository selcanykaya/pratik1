// See https://aka.ms/new-console-template for more information
using System.Net.Security;

Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");
Console.Write("T.C. Kimlik Numarası:");
string tc = Console.ReadLine();
Console.Write("Adı:");
string ad = Console.ReadLine();
Console.Write("Soyad:");
string soyad = Console.ReadLine();
//telefon numarasıyla matematiksel işlem yapılmadığı için string olarak alıyoruz.
Console.Write("Telefon:");
string tel = Console.ReadLine();
Console.Write("Yas:");
int yas;
yas = Convert.ToInt32(Console.ReadLine());
//fiyat bilgileri ondalık sayı olabileceği için double kullandık.
Console.Write("İlk aldığı ürünün fiyatı:");
double fiyat1;
fiyat1 = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci aldığı ürünün fiyatı:");
double fiyat2;
fiyat2 = Convert.ToDouble(Console.ReadLine());
double toplam;
toplam = fiyat1 + fiyat2;
Console.WriteLine("----------------------------------");
Console.WriteLine($"{tc} TC numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur. " +
    $"\n{tel} telefon numarasına bildirim mesajı gönderilmiştir. " +
    $"\n{toplam} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {toplam / 10} TL'dir.");





