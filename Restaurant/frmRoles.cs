using CapaControlador;
using Restaurant.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private int option = 0;

        private void frmRoles_Load(object sender, EventArgs e)
        {
            designDGV.design(dgvListado);
            disableButton();
            clearFields();
            mostrar();
        }

        private void disableButton()
        {
            btnNuevo.Enabled = true;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void enableButton()
        {
            btnNuevo.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void clearFields()
        {
            txtcodigo.Text = "0";
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtnombre.Focus();
            chkEstado.Checked = true;
            option = 0;
            txtcodigo.Enabled = false;
            chkStatus.Checked = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            enableButton();
            gbMantenimiento.Enabled = true;
            clearFields();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            disableButton();
            gbMantenimiento.Enabled = false;
            clearFields();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                error.SetError(txtnombre, "Ingrese el nombre del rol");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void guardar()
        {
            try
            {
                if (validateFields())
                {
                    int codigo = Convert.ToInt32(txtcodigo.Text.Trim());
                    string nombre = txtnombre.Text.Trim();
                    string descripcion = txtdescripcion.Text.Trim();
                    bool activo = Convert.ToBoolean(chkEstado.CheckState);

                    if(option == 0)
                    {
                        CRoles.guardar(0, nombre, descripcion, activo, 0);
                    }
                    else
                    {
                        CRoles.guardar(codigo, nombre, descripcion, activo, 1);
                    }

                    MessageBox.Show("Registro exitoso");
                    clearFields();
                    disableButton();
                    gbMantenimiento.Enabled = false;
                    mostrar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void mostrar()
        {
            try
            {
                bool status = Convert.ToBoolean(chkStatus.CheckState);
                DataTable dt = new DataTable();
                CRoles.mostrar(dt, status);
                dgvListado.DataSource = dt;
                formatTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void formatTable()
        {
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[3].Visible = false;
            dgvListado.Columns[4].Visible = false;


            dgvListado.Columns[0].HeaderText = "EDITAR";
            dgvListado.Columns[2].HeaderText = "NOMBRE DEL ROL";
            dgvListado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvListado.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dgvListado.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = dgvListado.CurrentRow.Cells[3].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(dgvListado.CurrentRow.Cells[4].Value);

            if (e.ColumnIndex == 0)
            {
                enableButton();
                gbMantenimiento.Enabled = true;
                btnBorrar.Enabled = true;
                option = 1;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                int codigo = Convert.ToInt32(txtcodigo.Text.Trim());

                DialogResult result = MessageBox.Show("Deseas eliminar este registro","Eliminación",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        CRoles.eliminar(codigo);
                        MessageBox.Show("Registro eliminado con exito");
                        clearFields();
                        disableButton();
                        gbMantenimiento.Enabled = false;
                        mostrar();
                    }
                    catch (Exception ex)
                    {
                        Messages.messageError(ex.Message, "Error eliminando");
                    }
                }
                else
                {
                    clearFields();
                    disableButton();
                    gbMantenimiento.Enabled = false;
                    mostrar();
                }
            }
            else
            {
                Messages.messageWarning("El codigo no se ha seleccionado","Campo vacio");
            }
        }
    }
}
