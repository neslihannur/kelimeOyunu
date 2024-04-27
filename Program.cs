namespace kelimeOyunu
{
    internal class Program
    {



        class KelimeTahminOyunu
        {
            static void Main(string[] args)
            {
                string[] kelimeler = { "kahve", "üzüm", "kalem", "telefon", "pantolon" };
                string tahminEdilecekKelime;
                int kalanTahminHakki = 7;
                Random rnd = new Random();
                tahminEdilecekKelime = kelimeler[rnd.Next(0, kelimeler.Length)];
                char[] dogruHarfler = new char[tahminEdilecekKelime.Length];

                for (int i = 0; i < dogruHarfler.Length; i++)
                {
                    dogruHarfler[i] = '-';
                    Console.Write('-');
                }
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Kalan Hak: {0}", kalanTahminHakki);
                    Console.Write("Bir harf girin: ");
                    char harf = Convert.ToChar(Console.ReadLine());

                    bool tahminDogruMu = false;
                    int kalanHarfSayisi = 0;
                    for (int i = 0; i < tahminEdilecekKelime.Length; i++)
                    {
                        if (tahminEdilecekKelime[i] == harf)
                        {
                            dogruHarfler[i] = harf;
                            tahminDogruMu = true;
                        }
                        if (dogruHarfler[i] == '-')
                        {
                            kalanHarfSayisi++;
                        }
                    }

                    for (int i = 0; i < tahminEdilecekKelime.Length; i++)
                    {
                        if (tahminDogruMu && harf == tahminEdilecekKelime[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green; 
                        }
                        Console.Write(dogruHarfler[i]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();

                    if (kalanHarfSayisi == 0)
                    {
                        Console.WriteLine("Kazandınız.");
                        break;
                    }

                    if (!tahminDogruMu)
                    {
                        kalanTahminHakki--;
                    }

                    if (kalanTahminHakki == 0)
                    {
                        Console.WriteLine("Kaybettiniz.");
                        break;
                    }

                    Console.WriteLine("******************");
                }

                Console.Write("Seçilen kelime: {0}", tahminEdilecekKelime);
                Console.ReadLine();
            }
        }
    }
  }

