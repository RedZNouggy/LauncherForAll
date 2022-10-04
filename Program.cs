using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;
using System.Security.AccessControl;

namespace LauncherForAll
{

    internal static class Program
    {
        public static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string path = programData + @"\LauncherForAll";
            if (Directory.Exists(path))
            {
                if (File.Exists($"{path}\\Set_BrowseApps.config"))
                {
                    Form1 form1_vrb = new Form1();
                    Application.Run(form1_vrb);
                }
                else
                {
                    frmBrowseApps frmBrowseApps_vrb = new frmBrowseApps();
                    Application.Run(frmBrowseApps_vrb);
                }
            }
        }
    }
}
