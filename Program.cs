using System;
using System.Collections.Generic;
using System.Windows.Forms;


using Microsoft.Win32;
using Divelements.SandRibbon;
using Divelements.SandRibbon.Rendering;
namespace shapes
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Office2007ColorScheme colorTheme = Office2007ColorScheme.System;

        [STAThread]
        static void Main(String[] args)
        {
            

            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            if (key != null)
            {
                Object theme = key.GetValue("theme");
                if (theme == null)
                {
                    key.SetValue("theme", 0);
                }
                int color = int.Parse(key.GetValue("theme").ToString());
                switch (color)
                {
                    case 0: colorTheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.System;

                        break;
                    case 1: colorTheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.LunaBlue;
                        break;
                    case 2: colorTheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Silver;
                        break;
                    case 3: colorTheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista;
                        break;
                    default:
                        break;
                }
            }
            Application.EnableVisualStyles();
           
            Application.SetCompatibleTextRenderingDefault(false);
            SplashForm sp = new SplashForm();
            sp.Show();
            
            Application.Run(new MainForm(sp,args));
            
        }

      
    }
}
