using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenshotTakerAndSaver
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
