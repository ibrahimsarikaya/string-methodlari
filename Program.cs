using System;

namespace string_methodlari 
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
            string degisken2 = "CSharp";
            //Length
            Console.WriteLine(degisken.Length);

            // ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat 
            Console.WriteLine(string.Concat(degisken," Merhaba ")); // Değişkendeki ifadenin yanına merhaba yazısı eklendi. > Dersimiz CSharp, Hoşgeldiniz. Merhaba oldu.

            //Compare - CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // Degiskendeki yazının uzunluğu, değişken2 deki yazının uzunluğundan büyük olduğu için Çıktısı :1 dir. eğer küçük olsaydı -1 yazacaktı.
            Console.WriteLine(String.Compare(degisken,degisken2,true)); // Karşılaştırma yaparken büyük küçük harf duyarsız hale gelir eğer true olursa. Çıktısı :0 dır.
            Console.WriteLine(String.Compare(degisken,degisken2,false)); // false olduğu için büyük küçük harf duyarlıdır. Çıktısı : 1 dir.

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); // Değişken ifadesinin içinde değişken2 ifadesi var mı demektir. Eğer varsa True cevabı verir. Çıktısı: True dir
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz.")); // Degisken ifadesinin sonu Hoşgeldiniz. ile bitiyorsa true cevabı verir. Çıktısı : True dir.
            Console.WriteLine(degisken.StartsWith("Merhaba")); // Degisken ifadesinin başı Merhaba ile başlıyorsa true cevabı verir. Çıktısı : False.

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); // Degisken ifadesinin içinde ilk C harfini bulur. Eğer varsa o harfin index numarasını verir. Yoksa -1 cevabını veriri. Çıktısı : 9
            Console.WriteLine(degisken.IndexOf("zzz")); // Çıktısı : -1
            Console.WriteLine(degisken.LastIndexOf("i")); // Degisken ifadesindeki son i harfinin index numarasını verir. Çıktısı :26

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba ")); // 0. indexe Merhaba yazısını atar. Çıktısı : Merhaba Dersimiz CSharp, Hoşgeldiniz.

            //PadLeft - PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // Degisken2 ve bosluklar dahil 30 harf sola kayar. Çıktısı: Dersimiz CSharp, Hoşgeldiniz.                        CSharp
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //Degisken2 ve bosluklar dahil 30 harf sola kayar ve * koyar. Çıktısı: Dersimiz CSharp, Hoşgeldiniz.************************CSharp
            Console.WriteLine(degisken.PadRight(50) + degisken2); // Degisken ifadesi dahil 50 harf saga kayar. Çıktısı: Dersimiz CSharp, Hoşgeldiniz.                     CSharp // degisken 29 harf + 21 bosluk + degisken2 olarak yazılır yani.
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);// Üsttekinin aynısı. Sadece 21 boşluk yerine '-' kullanılıyor. Çıktısı: Dersimiz CSharp, Hoşgeldiniz.---------------------CSharp
            
            //Remove 
            Console.WriteLine(degisken.Remove(3)); // 3. index e kadar yazar. 3. index dahil olarak sonrasını siler. Çıkısı : Der
            Console.WriteLine(degisken.Remove(5,4)); // 5. index dahil sonraki 4 harfi siler. Çıktısı : DersiCSharp, Hoşgeldiniz.
            Console.WriteLine(degisken.Remove(0,1)); // 0. index dahil 1 harf siler. Yani baştaki harf silinir. Çıktısı: ersimiz CSharp, Hoşgeldiniz.  

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#")); // Degiskenin içindeki CSharp yazısını C# olarak değiştirdir.

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); // Degisken ifadesini boşluklara göre böldü. Yani "Dersimiz - CSharp, - Hoşgeldiniz." olarak 3 parçaya böldü. Yani 2 index numaralı bir dizi oldu. Bu dizinin 1. elemanını yazdırdık. Çıktısı : CSharp,

            //Substring
            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak cümlenin sonuna kadar yazar. Çıktısı : imiz CSharp, Hoşgeldiniz.
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başlayarak 6 karakter yazdır demek. Çıktısı : imiz C // Boşluklar sayılıyor.
            
            





        }
    }
}