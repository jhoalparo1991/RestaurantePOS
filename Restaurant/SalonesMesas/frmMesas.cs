using CapaControlador;
using Restaurant.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.SalonesMesas
{
    public partial class frmMesas : UserControl
    {
        string nombreSalon = "";
        int salonId = 0;
        bool addMesa = false;
        int posX = 0;
        int posY = 0;
        public frmMesas()
        {
            InitializeComponent();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            mostrarSalones();
        }

        private void mostrarSalones()
        {
            try
            {
                DataTable dt = new DataTable();
                CSalones.mostrarSalones(dt, true);
                fypSalones.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Button btnSalones = new Button();
                    btnSalones.Text = row["descripcion"].ToString();
                    btnSalones.Name = row["codigo"].ToString();
                    btnSalones.Size = new Size(158, 43);
                    btnSalones.FlatStyle = FlatStyle.Flat;
                    btnSalones.FlatAppearance.BorderSize = 2;
                    btnSalones.FlatAppearance.BorderColor = Color.LightGray;
                    btnSalones.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btnSalones.BackColor = Color.WhiteSmoke;
                    btnSalones.ForeColor = Color.DarkSlateGray;
                    btnSalones.Cursor = Cursors.Hand;
                    btnSalones.Click += BtnSalones_Click;
                    fypSalones.Controls.Add(btnSalones);
                }
            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Mostrar Salones");
            }
        }

        private void BtnSalones_Click(object sender, EventArgs e)
        {

            nombreSalon = ((Button)sender).Text;
            salonId = Convert.ToInt32(((Button)sender).Name);

            foreach (Button btn in fypSalones.Controls)
            {
                if (btn is Button)
                {
                    btn.BackColor = Color.WhiteSmoke;
                }
            }

            foreach (Button btn in fypSalones.Controls)
            {
                if (nombreSalon == btn.Text)
                {
                    btn.BackColor = Color.Salmon;
                }
            }

            lblSalon.Text = salonId + " - " + nombreSalon.ToUpper();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(salonId > 0)
            {
                btnagregar.Visible = false;
                btnCancelar.Visible = true;
                addMesa = true;
            }
            else
            {
                Messages.messageWarning("Seleccione un salon para agregar mesas", "Seleccionar salón");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnagregar.Visible = true;
            btnCancelar.Visible = false;
            addMesa = false;

        }

        private void panelMesas_MouseClick(object sender, MouseEventArgs e)
        {
            if (addMesa)
            {
                posX = e.Location.X;
                posY = e.Location.Y;
            }
        }
    }
}
