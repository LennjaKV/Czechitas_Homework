﻿namespace Breakout_lekce3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ukol - Obratte poradi stringu
            string palindrom = "Kuna nese nanuk";
            char[] array = palindrom.ToCharArray();
            Array.Reverse(array);
            palindrom = new string(array);
            Console.WriteLine($"Otáčím větu: {palindrom}");

            //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
            string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

            //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
            string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

            //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
            string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
        }
    }
}