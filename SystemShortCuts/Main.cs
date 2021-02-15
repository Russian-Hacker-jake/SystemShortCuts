using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemShortcuts.Properties;
using System.Runtime;
using System.Data;

namespace SystemShortcuts
{

    

    public partial class main : Component
    {

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            string userName = Environment.UserName;

            if (e.Shift && e.KeyCode == Keys.F)
            {
                System.Diagnostics.Process.Start(@"C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe");
            }



            if (e.Shift && e.KeyCode == Keys.S)
            {
                System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\\Steam\\Steam.exe");
            }


            if (e.Control && e.KeyCode == Keys.R)
            {
                System.Diagnostics.Process.Start(@"C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\System Tools\\Run");
            }




            if (e.Control && e.KeyCode == Keys.Tab)
            {
                System.Diagnostics.Process.Start(@"C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Teams");

            }






            if (e.Control && e.KeyCode == Keys.P)
            {
                System.Diagnostics.Process.Start(@"C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Libraries\\Pictures.library-ms");
            }






            if (e.Control && e.KeyCode == Keys.F)
            {
                System.Diagnostics.Process.Start(@"C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\System Tools\\File Explorer");
            }






            if (e.Control && e.KeyCode == Keys.T)
            {

                System.Diagnostics.Process.Start(@"C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\System Tools\\Command Prompt.lnk");
            }

        }










































        public main()
        {
            InitializeComponent();
        }

        public main(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


}
}

