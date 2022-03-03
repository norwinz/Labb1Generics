//Labb 1 Generics Dan Gustafsson SUT-21
using System;

namespace Labb1Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection LådaCollect = new LådaCollection();

            LådaCollect.Add(new Låda(10, 10, 10));
            LådaCollect.Add(new Låda(2, 15, 20));
            LådaCollect.Add(new Låda(7, 4, 20));
            LådaCollect.Add(new Låda(4, 12, 15));
            LådaCollect.Add(new Låda(2, 6, 10));
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
                    "1.Visa lådor\n" +
                    "2.Lägg till ny låda\n" +
                    "3.Ta bort låda\n" +
                    "4.Hitta låda med specifikt mått\n"
                    );
                string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1": //1.Visa lådor
                        {
                            Display(LådaCollect);
                            Console.ReadKey();
                            break;
                        }
                    case "2": //2.Lägg till ny låda
                        {
                            Console.WriteLine("Välj mått för den nya lådan: ");
                            Console.WriteLine("Höjd: ");
                            int höjd = Int32.Parse(Console.ReadLine());                            
                            Console.WriteLine("Längd: ");
                            int längd = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Bredd: ");
                            int bredd = Int32.Parse(Console.ReadLine());
                            LådaCollect.Add(new Låda(höjd, längd, bredd));
                            Console.ReadKey();
                            break;
                        }
                    case "3": //3.Ta bort låda
                        {
                            Console.WriteLine("Välj mått för den lådan du vill ta bort: ");
                            Console.WriteLine("Höjd: ");
                            int höjd = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Längd: ");
                            int längd = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Bredd: ");
                            int bredd = Int32.Parse(Console.ReadLine());
                            LådaCollect.Remove(new Låda(höjd, längd, bredd));
                            Console.ReadKey();
                            break;
                        }
                    case "4": //4.Hitta låda med specifikt mått
                        {
                            Console.WriteLine("Välj mått för den lådan du vill visa: ");
                            Console.WriteLine("Höjd: ");
                            int höjd = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Längd: ");
                            int längd = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Bredd: ");
                            int bredd = Int32.Parse(Console.ReadLine());
                            Låda templåda = new Låda(höjd, längd, bredd);

                            bool lådafinns =  LådaCollect.Contains(templåda);
                            
                            if (!lådafinns) Console.WriteLine("Låda med de måtten finns ej");
                            else Console.WriteLine("Lådan finns");
                            Console.ReadKey();
                            break;
                        }                  

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ogiltigt val.\nSkriv en siffra i menyn.\n\n");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
            public static void Display(LådaCollection displayLådaList)
            {
                Console.WriteLine("\nHöjd\tLängd\tBredd\tVolym\tHash Code");
                foreach (Låda item in displayLådaList)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                    item.höjd.ToString(), item.längd.ToString(), item.bredd.ToString(), item.Volym().ToString(), item.GetHashCode().ToString());
                }
            }
        
        
    }
    } 
