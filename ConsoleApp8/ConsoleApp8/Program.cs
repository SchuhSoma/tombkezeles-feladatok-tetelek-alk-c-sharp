using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static int[] Szamok = new int[30];
        static int[] KesesekSzama=new int[32];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //BevetelFeladat();
            KesesekFeladat();
            Console.ReadKey();
        }

        private static void KesesekFeladat()
        {
            Feladat1Kes(); Console.WriteLine("\n--------------------------------------\n");
            Feladat3Kes(); Console.WriteLine("\n--------------------------------------\n");
            Feladat4Kes(); Console.WriteLine("\n--------------------------------------\n");
            Feladat5Kes(); Console.WriteLine("\n--------------------------------------\n");
            Feladat67Kes(); Console.WriteLine("\n--------------------------------------\n");
            Feladat8Kes();
        }

        private static void Feladat8Kes()
        {
            Console.WriteLine("Írjuk ki az értékeket csökkenő rendben! ");
            int CsereKesesek;
            for (int i = 0; i < KesesekSzama.Length-1; i++)
            {
                for (int j = 0; j < KesesekSzama.Length-1; j++)
                {
                    if(KesesekSzama[j]<KesesekSzama[j+1])
                    {
                        CsereKesesek = KesesekSzama[j];
                        KesesekSzama[j] = KesesekSzama[j + 1];
                        KesesekSzama[j + 1] = CsereKesesek;
                    }
                }
            }
            
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                Console.WriteLine("\t{0:00}. diák -> késése: {1} ", i + 1, KesesekSzama[i]);
            }
        }

        private static void Feladat67Kes()
        {
            Console.WriteLine("Add meg a legkisebb elemet!, Add meg a legnagyobb elemet!");
            int LegkevesebbKeses=int.MaxValue;
            int LegtobbKeses=int.MinValue;
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                if(KesesekSzama[i]<LegkevesebbKeses)
                {
                    LegkevesebbKeses = KesesekSzama[i];
                }
                if(KesesekSzama[i]>LegtobbKeses)
                {
                    LegtobbKeses = KesesekSzama[i];
                }
            }
            Console.WriteLine("\tA legtöbb késés: {0}", LegtobbKeses);
            Console.WriteLine("\tA legkevesebb keses: {0}", LegkevesebbKeses);
        }

        private static void Feladat5Kes()
        {
            Console.WriteLine("Add meg, hány embert kell fegyelmire hívni (aki több mint 9-szer késett)");
            int Fegyelmisek = 0;
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                if(KesesekSzama[i]>9)
                {
                    Fegyelmisek++;
                }
            }
            Console.WriteLine("\tEnnyi diák szorul fegyelmire: {0}", Fegyelmisek);
        }

        private static void Feladat4Kes()
        {
            Console.WriteLine("Add meg, hányan nem késtek egyáltalán");
            int NemKesok = 0;
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                if(KesesekSzama[i]==0)
                {
                    NemKesok++;
                }
            }
            Console.WriteLine("\tEnnyi diák nem késett: {0}", NemKesok);
        }

        private static void Feladat3Kes()
        {
            Console.WriteLine("Add meg az átlagos késést az osztályban");
            int OsszesKeses = 0;
            double AtlagKeses = 0;
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                OsszesKeses += KesesekSzama[i];
            }
            AtlagKeses = (double)OsszesKeses / KesesekSzama.Length;
            Console.WriteLine("ÁTlag késések száma: {0:0.00}", AtlagKeses);
        }

        private static void Feladat1Kes()
        {
            Console.WriteLine("Töltsd fel a tömböt véletlenszámokkal a feladat leírásának megfelelően ");
            int RandomSzamok = 0;
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                RandomSzamok = rnd.Next(0, 21);
                KesesekSzama[i] = RandomSzamok;
            }
            Console.WriteLine("\n--------------------------------------\n");
            for (int i = 0; i < KesesekSzama.Length; i++)
            {
                Console.WriteLine("{0:00}. diák -> késése: {1} ",i+1, KesesekSzama[i]);
            }

        }

        private static void BevetelFeladat()
        {
            Feladat1Bev(); Console.WriteLine("\n--------------------------------------\n");
            Feladat3Bev(); Console.WriteLine("\n--------------------------------------\n");
            Feladat4Bev(); Console.WriteLine("\n--------------------------------------\n");
            Feladat5Bev(); Console.WriteLine("\n--------------------------------------\n");
            Feladat6Bev(); Console.WriteLine("\n--------------------------------------\n");
            Feladat7Bev(); Console.WriteLine("\n--------------------------------------\n");
        }

        private static void Feladat7Bev()
        {
            Console.WriteLine("Írjuk ki a hőmérséklet értékeket növekvő rendben");
            int CsereSzam;
            for (int i = 0; i < Szamok.Length-1; i++)
            {
                for (int j = 0; j < Szamok.Length-1; j++)
                {
                    if(Szamok[j]>Szamok[j+1])
                    {
                        CsereSzam = Szamok[j];
                        Szamok[j] = Szamok[j + 1];
                        Szamok[j + 1] = CsereSzam;
                    }
                }
            }
            for (int j = 0; j < Szamok.Length; j++)
            {
                Console.WriteLine("\t{0} nap: {1}", j + 1, Szamok[j]);
            }
        }

        private static void Feladat6Bev()
        {
            Console.WriteLine("Volt-e 185 a bevétel valamelyik napon?");
            int db185 = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]==185)
                {
                    db185++;
                }
            }
            if (db185 > 0) Console.WriteLine("\tVolt ilyen nap");
            else Console.WriteLine("\tNem volt ilyen nap");

        }

        private static void Feladat5Bev()
        {
            Console.WriteLine("Mennyi volt a legalacsonyabb bevétel és a legnagyobb bevétel különbsége?");
            int MaxBev = int.MinValue;
            int MinBev = int.MaxValue;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]>MaxBev)
                {
                    MaxBev = Szamok[i];
                }
                if(Szamok[i]<MinBev)
                {
                    MinBev = Szamok[i];
                }
            }
            Console.WriteLine("\tA legmagasabb bevétel : {0}", MaxBev);
            Console.WriteLine("\tA legalacsonyabb bevétel: {0}", MinBev);
            int Kulonbseg = MaxBev - MinBev;
            Console.WriteLine("\tA legalacsonyabb bevétel és a legnagyobb bevétel különbsége: {0}", Kulonbseg);
        }

        private static void Feladat4Bev()
        {
            Console.WriteLine("Hányszor volt a napi bevétel 185 és 200 közötti?");
            int dbVolt = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                if(Szamok[i]>185 && Szamok[i]<200)
                {
                    dbVolt++;
                }
            }
            Console.WriteLine("Ennyi alkalommal volt a napi bevétel 185 és 200 közötti: {0}", dbVolt);
        }

        private static void Feladat3Bev()
        {
            Console.WriteLine("Adjuk meg az átlagos novemberi bevételt! Az értéket 1 tizedesre kerekítsük!");
            int OsszegBev = 0;
            double AtlagBev = 0;
            for (int i = 0; i < Szamok.Length; i++)
            {
                OsszegBev += Szamok[i];
            }
            AtlagBev =(double) OsszegBev / Szamok.Length;
            Console.WriteLine("\tÁtlag bevétel: {0:0.00}", AtlagBev);
        }

        private static void Feladat1Bev()
        {
            Console.WriteLine("Töltsük fel a tömböt véletlenszámokkal [125,278] tartományból");
            for (int i = 0; i < Szamok.Length; i++)
            {
                Szamok[i] = rnd.Next(125, 279);
            }
            for (int j = 0; j < Szamok.Length; j++)
            {
                Console.WriteLine("\t{0} nap: {1}", j + 1, Szamok[j]);
            }
        }
    }
}
