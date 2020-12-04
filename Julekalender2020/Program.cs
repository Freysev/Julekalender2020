using System;
using System.Linq;

namespace Julekalender2020
{
    public class Program
    {
        public static void Main(string[] args)
		{
			Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
			Console.WriteLine("::::::::::::::::::::::::::HO HO HO!::::::::::::::::::::::::::");
			Console.WriteLine(":::::::::::::::::::FREDRIK LØSER KALENDER::::::::::::::::::::");
			Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
			Console.WriteLine("::::::::::::::::::::::KJØR DA!!!!::::::::::::::::::::::::::::\n");
			Luke1();
			Luke2();
			Luke3();
			Luke4();
			Luke5();
			Luke6();
			Luke7();
			Luke8();
			Luke9();
			Luke10();
			Luke11();
			Luke12();
			Luke13();
			Luke14();
			Luke15();
			Luke16();
			Luke17();
			Luke18();
			Luke19();
			Luke20();
			Luke21();
			Luke22();
			Luke23();
			Luke24();
			Console.WriteLine("\n");
			Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
			Console.WriteLine("::::::::::::::::::::::NAILED IT::::::::::::::/)/)::::::::::::");
			Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::(o.o)::::::::::::");
			Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::('_')/:::::::::::");
		}

        public static void Luke1()
        {
            var nrs = "3,4,5,1,2,7,8,10,9";
            var orderedNrs = nrs.Split(',').Select(int.Parse).OrderBy(x => x).ToList();
            for (int i = 0; i < orderedNrs.Count; i++)
            {
                if ((i + 1) != orderedNrs[i])
                {
                    Console.WriteLine($"[Luke 1] The missing nr is {i + 1}");
                    return;
                }
            }
        }
		public static void Luke2()
		{
			Console.WriteLine($"[Luke2] Not yet solved");
		}
		public static void Luke3()
		{
			Console.WriteLine($"[Luke3] Not yet solved");
		}
		public static void Luke4()
		{
			Console.WriteLine($"[Luke4] Not yet solved");
		}
		public static void Luke5()
		{
			Console.WriteLine($"[Luke5] Not yet solved");
		}
		public static void Luke6()
		{
			Console.WriteLine($"[Luke6] Not yet solved");
		}
		public static void Luke7()
		{
			Console.WriteLine($"[Luke7] Not yet solved");
		}
		public static void Luke8()
		{
			Console.WriteLine($"[Luke8] Not yet solved");
		}
		public static void Luke9()
		{
			Console.WriteLine($"[Luke9] Not yet solved");
		}
		public static void Luke10()
		{
			Console.WriteLine($"[Luke10] Not yet solved");
		}
		public static void Luke11()
		{
			Console.WriteLine($"[Luke11] Not yet solved");
		}
		public static void Luke12()
		{
			Console.WriteLine($"[Luke12] Not yet solved");
		}
		public static void Luke13()
		{
			Console.WriteLine($"[Luke13] Not yet solved");
		}
		public static void Luke14()
		{
			Console.WriteLine($"[Luke14] Not yet solved");
		}
		public static void Luke15()
		{
			Console.WriteLine($"[Luke15] Not yet solved");
		}
		public static void Luke16()
		{
			Console.WriteLine($"[Luke16] Not yet solved");
		}
		public static void Luke17()
		{
			Console.WriteLine($"[Luke17] Not yet solved");
		}
		public static void Luke18()
		{
			Console.WriteLine($"[Luke18] Not yet solved");
		}
		public static void Luke19()
		{
			Console.WriteLine($"[Luke19] Not yet solved");
		}
		public static void Luke20()
		{
			Console.WriteLine($"[Luke20] Not yet solved");
		}
		public static void Luke21()
		{
			Console.WriteLine($"[Luke21] Not yet solved");
		}
		public static void Luke22()
		{
			Console.WriteLine($"[Luke22] Not yet solved");
		}
		public static void Luke23()
		{
			Console.WriteLine($"[Luke23] Not yet solved");
		}
		public static void Luke24()
		{
			Console.WriteLine($"[Luke24] Not yet solved");
		}
	}
}
