using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static int[] KesesekTMB = new int[32];
        static int[] Munkaido=new int[21];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            KesesekFeladat();
            MunkaidoFeladat();
            Console.ReadKey();
        }

        private static void MunkaidoFeladat()
        {
            Feladat1Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat3Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat4Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat56Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat7Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat8Munk(); Console.WriteLine("\n--------------------------------\n");
            Feladat9Munk(); Console.WriteLine("\n--------------------------------\n");
        }

        private static void Feladat9Munk()
        {
            Console.WriteLine("Írjuk ki az értékeket növekvő rendben!");
            int CsereMunka;
            for (int i = 0; i < Munkaido.Length - 1; i++)
            {
                for (int j = 0; j < Munkaido.Length - 1; j++)
                {
                    if (Munkaido[j] > Munkaido[j + 1])
                    {
                        CsereMunka = Munkaido[j];
                        Munkaido[j] = Munkaido[j + 1];
                        Munkaido[j + 1] = CsereMunka;
                    }
                }
            }
            for (int j = 0; j < Munkaido.Length; j++)
            {
                Console.WriteLine("\t{0}", Munkaido[j]);
            }
        }

        private static void Feladat8Munk()
        {
            Console.WriteLine("Hányszor volt a napi munkaidő 11 és13 óra közötti?");
            int dbVolt = 0;
            for (int i = 0; i < Munkaido.Length; i++)
            {
                if(Munkaido[i]>11 && Munkaido[i]<13)
                {
                    dbVolt++;
                }
            }
            Console.WriteLine("\tEnnyi elkalommal volt a napi munkaidő 11 és13 óra közötti: {0} ",dbVolt);
        }

        private static void Feladat7Munk()
        {
            Console.WriteLine("Volt-e 9 órás munka napja valamikor?");
            bool MunkaDont = false;
            for (int i = 0; i < Munkaido.Length; i++)
            {
                if(Munkaido[i]==9)
                { MunkaDont = true; }
            }
            if (MunkaDont == true) Console.WriteLine("\tVolt 9 órája");
            else Console.WriteLine("\tNem volt 9 órája");

        }

        private static void Feladat56Munk()
        {
            Console.WriteLine("Melyik nap dolgozott legtöbbet illetve legkevesebbet? ");
            int MaxMunka = int.MinValue;
            int MaxHely = 0;
            int MinMunka = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i < Munkaido.Length; i++)
            {
                if(Munkaido[i]>MaxMunka)
                {
                    MaxMunka = Munkaido[i];
                    MaxHely = i;
                }
                if(Munkaido[i]<MinMunka)
                {
                    MinMunka = Munkaido[i];
                    MinHely = i;
                }
            }
            Console.WriteLine("\tLegkevesebbet ezen a napon dolgozott :{0} -> ennyi órát dolgozott aznap :{1}", MinHely+1, MinMunka);
            Console.WriteLine("\tLegtöbbet ezen a napon dolgozott :{0} -> ennyi órát dolgozott aznap :{1}", MaxHely+1, MaxMunka);
        }

        private static void Feladat4Munk()
        {
            Console.WriteLine("Hányszor dolgozott 8 órát?");
            int dbMunk = 0;
            for (int i = 0; i < Munkaido.Length; i++)
            {
                if(Munkaido[i]==8)
                {
                    dbMunk++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt 8 órája: {0}", dbMunk);
        }

        private static void Feladat3Munk()
        {
            Console.WriteLine("Adjuk meg, hogy mennyi pénzt keresett a tanár, ha nettó 2500 Ft - ot kap egy óráért!");
            int OsszegMunka = 0;
            for (int i = 0; i < Munkaido.Length; i++)
            {
                OsszegMunka += Munkaido[i];
            }
            int Fizetes = OsszegMunka * 2500;
            Console.WriteLine("\tA tanár ennyit keresett három hét alatt: {0} Ft", Fizetes);
        }

        private static void Feladat1Munk()
        {
            Console.WriteLine("Töltsük fel a tömböt véletlenszámokkal a megadott tartományból");
            for (int i = 0; i < Munkaido.Length; i++)
            {
                Munkaido[i] = rnd.Next(6, 15);
            }
            for (int j = 0; j < Munkaido.Length; j++)
            {
                Console.WriteLine("\t{0}. nap -> {1}",j+1,Munkaido[j]);
            }
            int k = 0;
           /* foreach (var Munka in Munkaido)
            {
                k++;
                Console.WriteLine("\t{0:00}. nap -> {1}", k, Munka);
            }*/
        }

        private static void KesesekFeladat()
        {
            Feladat1Kes(); Console.WriteLine("\n--------------------------------\n");
            Feladat2Kes(); Console.WriteLine("\n--------------------------------\n");
            Feladat3Kes(); Console.WriteLine("\n--------------------------------\n");
            Feladat4Kes(); Console.WriteLine("\n--------------------------------\n");
            Feladat5Kes(); Console.WriteLine("\n--------------------------------\n");
            Feledat67Kes(); Console.WriteLine("\n--------------------------------\n");
            Feladat8Kes(); Console.WriteLine("\n--------------------------------\n");
        }

        private static void Feladat8Kes()
        {
            Console.WriteLine("Írjuk ki az értékeket növekvő rendben!");
            int CsereKeses;
            for (int i = 0; i < KesesekTMB.Length-1; i++)
            {
                for (int j = 0; j < KesesekTMB.Length-1; j++)
                {
                    if(KesesekTMB[j]>KesesekTMB[j+1])
                    {
                        CsereKeses = KesesekTMB[j];
                        KesesekTMB[j] = KesesekTMB[j + 1];
                        KesesekTMB[j + 1] = CsereKeses;
                    }
                }
            }
            for (int i = 0; i < KesesekTMB.Length; i++)
            {
                if (i % 8 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("\t{0} ", KesesekTMB[i]);
            }
        }

        private static void Feledat67Kes()
        {
            Console.WriteLine("Add meg a legkisebb elemet!");
            int MinKeses = int.MaxValue;
            int MaxKeses = int.MinValue;
            for (int i = 0; i < KesesekTMB.Length; i++)
            {
                if(KesesekTMB[i]<MinKeses)
                {
                    MinKeses = KesesekTMB[i];
                }
                if(KesesekTMB[i]>MaxKeses)
                {
                    MaxKeses=KesesekTMB[i];
                }
            }
            Console.WriteLine("\tA legkevesebb késé : {0}", MinKeses);
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("Add meg a legnagyobb elemet!");
            Console.WriteLine("\tA legtöbb késé : {0}", MaxKeses);
        }

        private static void Feladat5Kes()
        {
            Console.WriteLine("Add meg, hány embert kell fegyelmire hívni (aki több mint 9-szer késett)");
            int FegyelmiDb = 0;
            for (int i = 0; i < KesesekTMB.Length; i++)
            {
                if (KesesekTMB[i] >=9)
                {
                    FegyelmiDb++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal lesz fegyelmi: {0}", FegyelmiDb);
        }

        private static void Feladat4Kes()
        {
            Console.WriteLine("Add meg, hányan nem késtek egyáltalán");
            int KesesDb = 0;
            for (int i = 0; i < KesesekTMB.Length; i++)
            {
                if(KesesekTMB[i]==0)
                {
                    KesesDb++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal nem volt késés: {0}", KesesDb);
        }

        private static void Feladat3Kes()
        {
            Console.WriteLine("Add meg az átlagos késést az osztályban");
            int KesesOsszeg = 0;
            double KesesAtlag = 0;
            for (int i = 0; i < KesesekTMB.Length; i++)
            {
                KesesOsszeg += KesesekTMB[i];
            }
            KesesAtlag = (double)KesesOsszeg / 32;
            Console.WriteLine("\tA késések összege: {0}",KesesOsszeg);
            Console.WriteLine("\tA késések átlaga: {0:0.00}", KesesAtlag);
        }

        private static void Feladat2Kes()
        {
            Console.WriteLine("Listázd ki a tömb elemeit egymás mellé, szóközzel elválasztva, úgy hogy egy"+
                "sorba 8 személy késési adata jelenjen meg.");
            for (int i = 0; i < 32; i++)
            {                
                if (i % 8 == 0)
                { 
                    Console.Write("\n");
                }
                Console.Write("\t{0} ", KesesekTMB[i]);
            }
        }

        private static void Feladat1Kes()
        {
            Console.WriteLine("Töltsd fel a tömböt véletlenszámokkal a feladat leírásának megfelelően");
            int Keses;
            for (int i = 0; i < 32; i++)
            {
                Keses = rnd.Next(0, 21);
                KesesekTMB[i] = Keses;
            }
        }
    }
}
