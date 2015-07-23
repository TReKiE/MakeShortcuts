using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace MakeShortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFolder.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Shortcuts");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            bw.RunWorkerAsync();
        }    

        private void CreateShortcut(string name, int i)
        {
            string newfolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Notepad Executables");
            object shDesktop = (object)"Desktop";

            WshShell shell = new WshShell();
            if (!Directory.Exists(txtFolder.Text)) Directory.CreateDirectory(txtFolder.Text);
            string shortcutAddress = Path.Combine(txtFolder.Text,"Notepad" + i.ToString() + ".lnk");
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.TargetPath = Path.Combine(newfolder,name);
            shortcut.Save();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // set up Program Files folders for new notepad executables
            string newfolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Notepad Executables");
            string newfoldermui = Path.Combine(newfolder, "en-US");

            // create folders if they don't exist
            if (!Directory.Exists(newfolder)) Directory.CreateDirectory(newfolder);
            if (!Directory.Exists(newfoldermui)) Directory.CreateDirectory(newfoldermui);

            for (int i = 1; i < 1000; i++)
            {
                string name = "notepad";
                name = name + i.ToString() + ".exe";

                // copy files to new folders
                System.IO.File.Copy("c:\\windows\\notepad.exe", Path.Combine(newfolder, name), true);
                System.IO.File.Copy("c:\\windows\\en-us\\notepad.exe.mui", Path.Combine(newfoldermui, name + ".mui"), true);

                // create shortcut for new notepad number
                CreateShortcut(name, i);
                bw.ReportProgress(50, "Notepad" + i.ToString() + " created");
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = e.UserState.ToString();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Shortcut creation complete!";
            button1.Enabled = true;
        }
    }
}
