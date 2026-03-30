using System;

namespace WpfKosc
{
    public class Kosc
    {
        public static int LiczbaInstancji = 0;
        private string[] PlikiObrazow = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int LiczbaOczek;
        public int IndeksObrazu;
        public bool CzyDostepna;

        public Kosc()
        {
            Random rnd = new Random();
            LiczbaOczek = rnd.Next(1, 7);
            IndeksObrazu = LiczbaOczek;
            CzyDostepna = true;
            LiczbaInstancji++;
        }

        public Kosc(int wartosc)
        {
            if (wartosc >= 1 && wartosc <= 6)
            {
                LiczbaOczek = wartosc;
                IndeksObrazu = wartosc;
            }
            else
            {
                LiczbaOczek = 0;
                IndeksObrazu = 0;
            }
            CzyDostepna = true;
            LiczbaInstancji++;
        }

        public void Rzut()
        {
            if (CzyDostepna)
            {
                Random rnd = new Random();
                LiczbaOczek = rnd.Next(1, 7);
                IndeksObrazu = LiczbaOczek;
            }
        }

        public void Blokuj()
        {
            CzyDostepna = false;
        }

        public string ZwrocWartoscTekst()
        {
            string[] nazwy = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć" };
            return nazwy[LiczbaOczek];
        }
    }
}
