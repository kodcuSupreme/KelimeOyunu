﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceKelimeOyunu
{
    public static class Program
    {
        
        // Uygulamanın ana girdi noktası.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ingilizceKelimeOyunu());
        }
    }
}
