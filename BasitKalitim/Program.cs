using BasitKalitim;

Ogrenci o= new Ogrenci();
o.Ad="Duygu";
o.Soyad = "Tezcan Kantar";
o.Ilce = "Ataşehir";
o.Sehir = "İstanbul";
o.Cadde = "Atatürk";
o.Sokak = "Mevlana";


Console.WriteLine(o.FullName());
foreach (var item in o.AdresAl())
{
    Console.WriteLine(item);
}

Egitmen e=new Egitmen();
e.Ad = "Şamil";
e.Soyad = "Yılmaz";
e.Ilce = "Ümraniye";
e.Sehir = "İstanbul";
e.Cadde = "Atatürk";

