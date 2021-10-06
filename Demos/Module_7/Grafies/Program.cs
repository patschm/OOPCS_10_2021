using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafies
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Form f1 = new Form();
            f1.Text = "My form";

            Button b = new Button();
            b.Text = "Click me!";
            b.Click += MijKlik;

            f1.Controls.Add(b);

            f1.ShowDialog();

            Console.ReadLine();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }

        private static void MijKlik(object sender, EventArgs e)
        {
            Debug.WriteLine("Klikkerdeklik");
        }
    }
}
