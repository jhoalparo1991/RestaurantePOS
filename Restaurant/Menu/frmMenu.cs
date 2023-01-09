using CapaControlador;
using Restaurant.Helpers;
using Restaurant.SalonesMesas;
using Restaurant.Usuarios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private int vendedorId = 0;
        private string estadoSesion = "";
        private string nombreSalon = "";
        private int salonId = 0;

        private void frmMenu_Load(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.None;
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                DataTable dt = new DataTable();
                CVendedores.obtenerDatosInicioSesion(dt);

                if(dt.Rows.Count > 0 )
                {

                tssNombrePc.Text = Environment.MachineName;
                tssVendedor.Text = dt.Rows[0]["vendedor"].ToString();
                vendedorId = Convert.ToInt32(dt.Rows[0]["codigo"].ToString());
                tssRole.Text = dt.Rows[0]["roles"].ToString();
                estadoSesion = dt.Rows[0]["estado"].ToString();
                }
                else
                {
                    this.Dispose();
                    frmLogin frm = new frmLogin();
                    frm.ShowDialog();
                }

                mostrarSalones();

            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Error cargar datos");
            }
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

            foreach(Button btn in fypSalones.Controls)
            {
                if(btn is Button)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tssHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarSesion();
        }

        private void cerrarSesion()
        {
            if (estadoSesion == "activo")
            {
                CVendedores.cambiarEstado(vendedorId);
            }
        }

        private void agregarPestanias(UserControl control, string title)
        {
            TabPage page = new TabPage();
            page.Text = title;
            page.Controls.Add(control);
            tcMenus.Controls.Add(page);
            tcMenus.SelectedTab = page;
        }

        private void smVendedores_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Dock = DockStyle.Fill;
            agregarPestanias(frm,"Vendedores");
        }

        private void smRoles_Click(object sender, EventArgs e)
        {
            frmRoles frm = new frmRoles();
            frm.ShowDialog();
        }

        private void closeVentanas_Click(object sender, EventArgs e)
        {
            int total = tcMenus.TabCount;
            if(total > 0)
            {
                if(tcMenus.SelectedIndex != 0)
                {
                    tcMenus.TabPages.Remove(tcMenus.SelectedTab);
                }
            }
        }

        private void smSalones_Click(object sender, EventArgs e)
        {
            frmSalones frm = new frmSalones();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrarSesion();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cerrarSesion();
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void smMesas_Click(object sender, EventArgs e)
        {
            frmMesas frm = new frmMesas();
            frm.Dock= DockStyle.Fill;
            agregarPestanias(frm, "Mesas");
        }
    }
}
