using System;
using System.Windows.Forms;
using KaraokeManagement.GUI;

namespace KaraokeManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormKaraokeMain());
        }
    }
}
