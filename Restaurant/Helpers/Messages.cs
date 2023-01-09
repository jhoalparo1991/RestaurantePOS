using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Helpers
{
    internal class Messages
    {

        public static void messageInfo(string message,string title)
        {
            MessageBox.Show(message,title,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void messageError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void messageWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
