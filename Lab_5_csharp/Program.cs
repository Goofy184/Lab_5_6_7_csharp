using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_csharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                List<DesyatkovaStrichka> desyatkovaStrichkas = new List<DesyatkovaStrichka>();
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(10));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(20));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(30));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(4));
                desyatkovaStrichkas.Add(new DesyatkovaStrichka(2));

                foreach (var str in desyatkovaStrichkas)
                {
                    Console.WriteLine(str.Symbol);
                }

                Console.WriteLine("-------------------------------");

                int count = desyatkovaStrichkas.Count;

                for (int i = 0; i < count; i++)
                {
                    desyatkovaStrichkas.Add((DesyatkovaStrichka)desyatkovaStrichkas[i].Clone());
                }


                foreach (var str in desyatkovaStrichkas)
                {
                    Console.WriteLine(str.Symbol);
                }

                desyatkovaStrichkas.Sort();

                Console.WriteLine("-------------------------------");

                foreach (var str in desyatkovaStrichkas)
                {
                    Console.WriteLine(str.Symbol);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
        }
    }
}
