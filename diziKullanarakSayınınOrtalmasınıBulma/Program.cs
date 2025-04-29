namespace diziKullanarakSayınınOrtalmasınıBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar =new int[5];
            int toplam = 0;

            for(int i = 0; i < sayilar.Length; i++)
            {

                Console.Write($"{i + 1}. sayıyı gir: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];





            }

            double ortalama =  (double)toplam / sayilar.Length;
            Console.WriteLine("ortalama : " + ortalama);


        }
    }
}
