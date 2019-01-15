using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gardian
{
    public static class MiMessagebox
    {
        public static void MensError(string s)
        {
            System.Windows.Forms.MessageBox.Show(s, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void MensInfo(string s)
        {
            System.Windows.Forms.MessageBox.Show(s, "Info.", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void MensAlert(string s)
        {
            System.Windows.Forms.MessageBox.Show(s, "Alerta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }
        public static void Mensaje(string s, string c)
        {
            System.Windows.Forms.MessageBox.Show(s, c, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.None);
        }


    }
}
