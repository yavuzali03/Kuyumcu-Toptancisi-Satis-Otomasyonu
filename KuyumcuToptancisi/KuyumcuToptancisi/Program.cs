using System;
using System.Windows.Forms;

namespace KuyumcuToptancisi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new girisEkrani());
        }

        public static void geriDon(Form form)
        {
            form.Show();
        }
    }
}
