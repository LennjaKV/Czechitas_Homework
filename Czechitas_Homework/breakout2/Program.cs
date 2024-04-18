namespace breakout2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte den odjezdu na dovolenou");
            int denOdjezdu = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte měsíc odjezdu na dovolenou");
            int mesicOdjezdu = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte rok odjezdu na dovolenou");
            int rokOdjezdu = int.Parse(Console.ReadLine());

            DateTime datumOdjezdu = new DateTime(rokOdjezdu, mesicOdjezdu, denOdjezdu);
            TimeSpan casDoOdjezdu = datumOdjezdu - DateTime.Now;
            Console.WriteLine($"Odjezd za:{casDoOdjezdu.TotalDays} dnu");

        }
    }
}