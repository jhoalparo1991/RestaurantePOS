using CapaControlador;
using Restaurant.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant.SalonesMesas
{
    public partial class frmSalones : Form
    {
        public frmSalones()
        {
            InitializeComponent();
        }

        int opcion = 0;

        private void frmSalones_Load(object sender, EventArgs e)
        {
            designDGV.design(dgvListado);
            inHabilitarBotones();
            limpiarCampos();
            mostrarSalones();
        }

        private void habilitarBotones()
        {
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            gbMantenimiento.Enabled = true;
            txtcodigo.Enabled = false;

        }

        private void inHabilitarBotones()
        {
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            gbMantenimiento.Enabled = false;
            txtcodigo.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtcodigo.Text = "0";
            txtdescripcion.Clear();
            chkEstado.Checked = true;
            txtImpuestos.Text = "0";
            opcion = 0;
            txtdescripcion.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            inHabilitarBotones();
            limpiarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            habilitarBotones();
            limpiarCampos();
        }

        private void mostrarSalones()
        {
            try
            {
                DataTable dt = new DataTable();
                CSalones.mostrarSalones(dt, Convert.ToBoolean(chkStatus.CheckState));
                dgvListado.DataSource = dt;
                formatoTabla();
            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Mostrar salones");
            }
        }

        private void formatoTabla()
        {
            dgvListado.Columns[0].HeaderText = "";
            dgvListado.Columns[1].HeaderText = "COD.";
            dgvListado.Columns[2].HeaderText = "SALONES";
            dgvListado.Columns[3].HeaderText = "IMP.";
            dgvListado.Columns[4].HeaderText = "ACTIVO";

            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[4].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtdescripcion.Text))
                {

                    error.SetError(txtdescripcion, "");
                    if (!string.IsNullOrEmpty(txtImpuestos.Text))
                    {
                        int codigo = Convert.ToInt32(txtcodigo.Text.Trim());
                        decimal impuesto = Convert.ToDecimal(txtImpuestos.Text.Trim());
                        bool activo = Convert.ToBoolean(chkEstado.CheckState);
                        string descripcion = txtdescripcion.Text.Trim();

                        if(opcion == 0)
                        {
                            if (CSalones.guardar(0,descripcion,impuesto,activo,0)) {
                                Messages.messageInfo("Salon creado con exito", "Crear salon");
                                inHabilitarBotones();
                                limpiarCampos();
                            }
                        }
                        else
                        {
                            if (CSalones.guardar(codigo, descripcion, impuesto, activo, 1))
                            {
                                Messages.messageInfo("Salon modificado con exito", "Crear salon");
                                inHabilitarBotones();
                                limpiarCampos();
                            }
                        }
                        mostrarSalones();
                    }
                    else
                    {
                        error.SetError(txtImpuestos, "Error, ingrese un impuestode valor mínimo 0");
                    }
                }
                else
                {
                    error.SetError(txtdescripcion, "Error, Ingrese el nombre del salon");
                }
            }
            catch (Exception ex)
            {
                Messages.messageError(ex.Message, "Guardar salon");
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            mostrarSalones();
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvListado.CurrentRow.Cells["codigo"].Value.ToString();
            txtdescripcion.Text = dgvListado.CurrentRow.Cells["descripcion"].Value.ToString();
            txtImpuestos.Text = dgvListado.CurrentRow.Cells["impuesto"].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(dgvListado.CurrentRow.Cells["activo"].Value);
            
            if(e.ColumnIndex == 0)
            {
                habilitarBotones();
                btnBorrar.Enabled = true;
                opcion = 1;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                int codigo = Convert.ToInt32(txtcodigo.Text.Trim());

                DialogResult result = MessageBox.Show("Deseas eliminar este registro", "Eliminación",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        CSalones.eliminarSalon(codigo);
                        MessageBox.Show("Registro eliminado con exito");
                        limpiarCampos();
                        inHabilitarBotones();
                        mostrarSalones();

                    }
                    catch (Exception ex)
                    {
                        Messages.messageError(ex.Message, "Error eliminando");
                    }
                }
                else
                {
                    limpiarCampos();
                    inHabilitarBotones();
                    mostrarSalones();
                }
            }
            else
            {
                Messages.messageWarning("El codigo no se ha seleccionado", "Campo vacio");
            }
        }
    }
}
