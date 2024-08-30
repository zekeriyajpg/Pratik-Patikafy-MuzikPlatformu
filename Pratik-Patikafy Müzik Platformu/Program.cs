using Pratik_Patikafy_Müzik_Platformu;
List<Sarkici> sarkilar = new List<Sarkici>
{
            new Sarkici { AdSoyad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatislari = 20 },
            new Sarkici { AdSoyad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatislari = 10 },
            new Sarkici { AdSoyad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 3 },
            new Sarkici { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 5 },
            new Sarkici { AdSoyad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatislari = 3 },
            new Sarkici { AdSoyad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 10 },
            new Sarkici { AdSoyad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = 40 },
            new Sarkici { AdSoyad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 2000, AlbumSatislari = 7 },
            new Sarkici { AdSoyad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatislari = 5 },
            new Sarkici { AdSoyad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatislari = 10 },
            new Sarkici { AdSoyad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatislari = 2 }
};
Console.WriteLine("!!!!!! 1. Adı 'S' ile başlayan şarkıcılar !!!!!!");
var sIlebaslayanlar = sarkilar.Where(s => s.AdSoyad.StartsWith("S"));
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar : ");
foreach (var sarki in sIlebaslayanlar)
{
    Console.WriteLine(sarki.AdSoyad);

}
Console.WriteLine(" ");

Console.WriteLine("!!!!!! 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar !!!!!!");

var yukseksatisyapanlar = sarkilar.Where(s => s.AlbumSatislari > 10);
Console.WriteLine("\nAlbüm satışları 10 milyon üzerinde olan şarkıcılar : ");
foreach (var sarki in  yukseksatisyapanlar)
{
    Console.WriteLine(sarki.AdSoyad);
}
Console.WriteLine(" ");

Console.WriteLine("!!!!!! 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar !!!!!!");
var eskiPopcular = sarkilar.Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
                                   .OrderBy(s => s.CikisYili)
                                   .ThenBy(s => s.AdSoyad);
Console.WriteLine("\n2000 yılı öncesi çıkış yapmış pop müzik şarkıcıları : ");
foreach (var sarki  in eskiPopcular)
{
    Console.WriteLine(sarki.CikisYili +" "+ sarki.AdSoyad );
}
Console.WriteLine(" ");

Console.WriteLine("!!!!!! 4. En çok albüm satan şarkıcı !!!!!!");

var enCokSatan = sarkilar.OrderByDescending(s=>s.AlbumSatislari).First();
Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enCokSatan.AdSoyad} ({enCokSatan.AlbumSatislari} milyon)");
Console.WriteLine(" ");


Console.WriteLine("!!!!!! 5. En yeni ve en eski çıkış yapan şarkıcı !!!!!!");
var enYeni = sarkilar.OrderByDescending(s => s.CikisYili).First();
var enEski = sarkilar.OrderBy(s=> s.CikisYili).First();
Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeni.AdSoyad} ({enYeni.CikisYili})");
Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEski.AdSoyad} ({enEski.CikisYili})");
