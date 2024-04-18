namespace breakout2
{
    //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
    //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
    //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
    //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException
    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;
        public Clovek(string jmeno, int telCislo)
        {
            if (String.IsNullOrEmpty(jmeno))
            {
                throw new ArgumentException("Jméno není validní");
            }
            if (telCislo.ToString().Length!=9)
            {
                throw new ArgumentException("Telefonní číslo není validní");
            }
            Jmeno = jmeno;
            TelCislo = telCislo;
        }
        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();
            try
            {
                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                prvniClovek.VypisJmenoACislo();
            }
            catch (Exception vyjimka) //OverflowException
            {
                //Console.WriteLine("Nezadal jsi správný vstup. Ukoncuji program.");
                Console.WriteLine(vyjimka.Message);

            }
        
            Console.ReadLine();
        }
    }
    /*internal class Program
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
    }*/
}