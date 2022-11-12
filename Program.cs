namespace MatamatikMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = 26, b = 32;

            decimal s = b / a;
            Console.WriteLine(Math.Round(s, 3));
            Console.WriteLine(Math.PI);

            if (b < a)
                s = a;
            else
                s = b;

            s = b < a ? a : b;

            s = Math.Min(a, b);
            s = Math.Max(a, b);

            DateTime tarih1 = new DateTime(2022, 12, 8);
            DateTime tarih2 = DateTime.Now;

            var sonuc = tarih2.Day - tarih1.Day;
            Console.WriteLine(sonuc);

            var sonuc2 = tarih1.Day - tarih2.Day;
            Console.WriteLine(Math.Abs(sonuc2));
            Console.WriteLine(sonuc2 < 0 ? (sonuc2 * -1) : sonuc2);
        }
    }
}