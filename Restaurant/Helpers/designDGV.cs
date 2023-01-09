using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Helpers
{
    internal class designDGV
    {

        public static void design(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
           // dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           // dgv.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.AllCells;
            dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible= false;

            dgv.DefaultCellStyle.BackColor= Color.White;
            dgv.DefaultCellStyle.ForeColor= Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor= Color.WhiteSmoke;
            dgv.DefaultCellStyle.SelectionForeColor= Color.Black;
            dgv.RowTemplate.Height = 35;
            
        }
    }
}
