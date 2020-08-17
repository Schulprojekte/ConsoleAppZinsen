using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppZinsen
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 10000;
            double p = 9;
            int t = 125;
            double z;

            Console.WriteLine("Wofür benötigen Sie diesen Kredit?"); //Eingabeaufforderung String
            String s = Convert.ToString(Console.ReadLine()); //Eingabe String
            Console.WriteLine("Geben Sie den benötigten Kreditbetrag ein");
            k = Convert.ToDouble(Console.ReadLine()); //Eingabe double
            Console.WriteLine("Geben Sie den benötigten Zeitraum ein");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            z = (p * k * t) / (100 * 360);
            z = Math.Round(z * 100) / 100;

            Console.WriteLine(z + " Euro" + " Zinsen");
            Console.ReadKey();
            MessageBox.Show(z + " Euro" + " Zinsen");
        }
    }
}