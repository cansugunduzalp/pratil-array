using System;

class Program
{
    static void Main()
    {
        // 1. Aşama: 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] dizi = new int[10];

        // 2. Aşama: Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");

        // For döngüsü ile diziyi dolduruyoruz.
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Dizi elemanı {i + 1}: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Foreach döngüsü ile dizinin elemanlarını ekrana yazıyoruz.
        Console.WriteLine("\nDizinin elemanları:");
        foreach (int eleman in dizi)
        {
            Console.WriteLine(eleman);
        }

        // 3. Aşama: Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak).
        Console.Write("\nYeni bir sayı girin (11. eleman olarak eklenecek): ");
        int yeniEleman = Convert.ToInt32(Console.ReadLine());

        // Diziyi yeni bir boyutta oluşturup, eski ve yeni elemanları ekliyoruz.
        Array.Resize(ref dizi, dizi.Length + 1);
        dizi[10] = yeniEleman;

        // 4. Aşama: Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(dizi);
        Array.Reverse(dizi);

        Console.WriteLine("\nDizi büyükten küçüğe sıralandı:");
        foreach (int eleman in dizi)
        {
            Console.WriteLine(eleman);
        }
    }
}
