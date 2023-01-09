using CapaControlador;
using Restaurant.Helpers;
using Restaurant.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Usuarios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            agregarBotones();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void agregarBotones()
        {
            string numeros = "7894561230";
            fypBotones.Controls.Clear();
            foreach(char n in numeros)
            {
                Button btn = new Button();
                btn.Text = n.ToString();
                btn.Size = new Size(65, 63);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = Color.LightGray;
                btn.Font = new Font("Segoe UI", 12,FontStyle.Bold);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.DarkSlateGray;
                btn.Click += Btn_Click;
                btn.Cursor = Cursors.Hand;
                fypBotones.Controls.Add(btn);
            }

            Button btnLimpiar = new Button();
            btnLimpiar.Text = "<-";
            btnLimpiar.Size = new Size(65, 63);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Click += BtnLimpiar_Click;
            fypBotones.Controls.Add(btnLimpiar);

            Button btnBorrar = new Button();
            btnBorrar.Text = "CS";
            btnBorrar.Size = new Size(65, 63);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.FlatAppearance.BorderSize = 2;
            btnBorrar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBorrar.BackColor = Color.DarkOrange;
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Click += BtnBorrar_Click;
            fypBotones.Controls.Add(btnBorrar);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            int total = txtclave.TextLength;
            if(total > 0)
            {
                txtclave.Text = txtclave.Text.Substring(0, total - 1);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtclave.Clear();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(txtclave.TextLength < 10)
            {
                string codigo = ((Button)sender).Text;
                txtclave.Text += codigo;
            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                DataTable dt = new DataTable();
                string clave = txtclave.Text.Trim();

                CVendedores.iniciarSesion(dt, clave);

                if(dt.Rows.Count > 0)
                {
                    this.Dispose(); 
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
