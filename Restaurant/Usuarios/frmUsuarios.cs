using CapaControlador;
using Restaurant.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant.Usuarios
{
    public partial class frmUsuarios : UserControl
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private int opcion = 0;

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            designDGV.design(dgv);
            mostrar();
            mostrarRoles();
            inHabilitarBotones();
            limpiarCampos();
            lbTipoDoc.Visible = false;
        }




        private void habilitarBotones()
        {
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            gbMantenimiento.Enabled = true;
            pbimagen.Enabled = true;
            btnSubirImagen.Enabled = true;
            btnQuitarImagen.Enabled = true;
            btnBuscarDoc.Enabled = true;

        }

        private void inHabilitarBotones()
        {
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            gbMantenimiento.Enabled = false;

            pbimagen.Enabled = false;
            btnSubirImagen.Enabled = false;
            btnBuscarDoc.Enabled = false;
            btnQuitarImagen.Enabled = false;

        }

        private void limpiarCampos()
        {
            txtapellido.Clear();
            txtbase.Text = "0";
            txtcelular.Clear();
            txtciudad.Clear();
            txtclave.Clear();
            txtcomision.Clear();
            txtdireccion.Clear();
            txtcomision.Text = "0";
            txtdireccion.Clear();
            txtemail.Clear();
            txtnombre.Clear();
            txtNumDoc.Clear();
            txtpais.Clear();
            txttelefono.Clear();
            txttipo_doc.Text = "CC";
            opcion = 0;
            txttipo_doc.Enabled = false;
            txtcodigo.Text = "0";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            limpiarCampos();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inHabilitarBotones();
            limpiarCampos();
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            Images.upload(pbimagen);
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            Images.noImage(pbimagen);
        }

        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                CVendedores.mostrar(dt, txtbuscar.Text.Trim());
                dgv.DataSource = dt;
                lbltotal.Text = $"Registros totales {dt.Rows.Count}";
                ocultarFilas();
                formatoTabla();
            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Error");
            }
        }

        private void mostrarRoles()
        {
            try
            {
                DataTable dt = new DataTable();
                CVendedores.llenarComboBox(dt);
                cbxRole.DataSource = dt;
                cbxRole.DisplayMember = "nombre";
                cbxRole.ValueMember= "codigo";
            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Error");
            }
        }


        private void ocultarFilas()
        {
            dgv.Columns[1].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].Visible = false;
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].Visible = false;

            dgv.Columns[0].Width = 50;
        }


        private void formatoTabla()
        {
            dgv.Columns[0].HeaderText = "";
            dgv.Columns[1].HeaderText = "CODIGO";
            dgv.Columns[2].HeaderText = "NOMBRES";
            dgv.Columns[3].HeaderText = "APELLIDOS";
            dgv.Columns[4].HeaderText = "TIPO DOC.";
            dgv.Columns[5].HeaderText = "NUM DOC.";
            dgv.Columns[6].HeaderText = "DIRECCION";
            dgv.Columns[7].HeaderText = "TELEFONO";
            dgv.Columns[8].HeaderText = "CELULAR";
            dgv.Columns[9].HeaderText = "EMAIL";
            dgv.Columns[10].HeaderText = "CIUDAD";
            dgv.Columns[11].HeaderText = "PAIS";
            dgv.Columns[12].HeaderText = "CLAVE";
            dgv.Columns[13].HeaderText = "FOTO";
            dgv.Columns[14].HeaderText = "ACTIVO";
            dgv.Columns[15].HeaderText = "S. BASE";
            dgv.Columns[16].HeaderText = "COMISION";
            dgv.Columns[17].HeaderText = "SALARIO";
            dgv.Columns[18].HeaderText = "ROLE_ID";
            dgv.Columns[19].HeaderText = "ROLE";
        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            lbTipoDoc.Visible = true;
            lbTipoDoc.Location = pTipoDoc.Location;
        }

        private void lbTipoDoc_DoubleClick(object sender, EventArgs e)
        {
            txttipo_doc.Text =  lbTipoDoc.Text;
            lbTipoDoc.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            try
            {
                if (validarCampos())
                {
                    int codigo = Convert.ToInt32(txtcodigo.Text.Trim());
                    string nombres = txtnombre.Text.Trim();
                    string apellidos = txtapellido.Text.Trim();
                    string tipoDoc  = txttipo_doc.Text.Trim();
                    string nroDoc  = txtNumDoc.Text.Trim();
                    string direccion  = txtdireccion.Text.Trim();
                    string telefono  = txttelefono.Text.Trim();
                    string celular  = txtcelular.Text.Trim();
                    string email  = txtemail.Text.Trim();
                    string ciudad  = txtciudad.Text.Trim();
                    string pais  = txtpais.Text.Trim();
                    string clave  = txtclave.Text.Trim();
                    bool activo  = Convert.ToBoolean(chkActivo.CheckState);
                    decimal salarioBase  = Convert.ToDecimal(txtbase.Text.Trim());
                    decimal comision  = Convert.ToDecimal(txtcomision.Text.Trim());
                    int roleId  = Convert.ToInt32(cbxRole.SelectedValue);

                    MemoryStream ms = new MemoryStream();
                    pbimagen.Image.Save(ms, pbimagen.Image.RawFormat);
                    byte[] foto = ms.GetBuffer();

                    if (opcion == 0)
                    {
                        if(CVendedores.guardar(0,nombres,apellidos,tipoDoc,nroDoc,direccion,
                            telefono,celular,email,ciudad,pais,clave,foto,activo,salarioBase,
                            comision, roleId, 0))
                        {
                            Messages.messageInfo("Registro exitoso", "Guardar");
                            inHabilitarBotones();
                            limpiarCampos();
                        }
                    }
                    else
                    {
                        if (CVendedores.guardar(codigo, nombres, apellidos, tipoDoc, nroDoc, direccion,
                            telefono, celular, email, ciudad, pais, clave, foto, activo, salarioBase,
                            comision, roleId, 1))
                        {
                            Messages.messageInfo("Registro guardado con exito", "Editar registro");
                            inHabilitarBotones();
                            limpiarCampos();
                        }
                    }
                    mostrar();
                    mostrarRoles();
                }
                else
                {
                    Messages.messageWarning("Verifique los campos que son obligatorios", "Campos vacios");
                }
            }
            catch (Exception e)
            {
                Messages.messageError(e.Message, "Error al guardar vendedor");
            }
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                error.SetError(txtnombre, "");
                if (!string.IsNullOrEmpty(txtapellido.Text))
                {
                    error.SetError(pApellidos, "");
                    if (!string.IsNullOrEmpty(txttipo_doc.Text))
                    {
                        error.SetError(pTipoDoc, "");
                        if (!string.IsNullOrEmpty(txtNumDoc.Text))
                        {
                            error.SetError(pNumDoc, "");
                            if (!string.IsNullOrEmpty(txtclave.Text))
                            {
                                error.SetError(pClave, "");
                                if (!string.IsNullOrEmpty(cbxRole.Text))
                                {
                                    error.SetError(cbxRole, "");
                                    return true;
                                }
                                else
                                {
                                    error.SetError(cbxRole, "Elija un role");
                                    return false;
                                }
                            }
                            else
                            {
                                error.SetError(pClave, "Ingrese la clave");
                                return false;
                            }
                        }
                        else
                        {
                            error.SetError(pNumDoc, "Ingrese el numero de documento");
                            return false;
                        }
                    }
                    else
                    {
                        error.SetError(pTipoDoc, "Ingrese el tipo de documento");
                        return false;
                    }
                }
                else
                {
                    error.SetError(pApellidos, "Ingrese el apellido");
                    return false;
                }
            }
            else
            {
                error.SetError(pNombre, "Ingrese el nombre");
                return false;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerDatos();
            if(e.ColumnIndex == 0)
            {
                habilitarBotones();
                btnBorrar.Enabled = true;
                opcion = 1;

            }
        }


        private void obtenerDatos()
        {
            txtcodigo.Text = dgv.CurrentRow.Cells["codigo"].Value.ToString();
            txtnombre.Text = dgv.CurrentRow.Cells["nombres"].Value.ToString();
            txtapellido.Text = dgv.CurrentRow.Cells["apellidos"].Value.ToString();
            txttipo_doc.Text = dgv.CurrentRow.Cells["tipo_doc"].Value.ToString();
            txtNumDoc.Text = dgv.CurrentRow.Cells["nro_doc"].Value.ToString();
            txtdireccion.Text = dgv.CurrentRow.Cells["direccion"].Value.ToString();
            txttelefono.Text = dgv.CurrentRow.Cells["telefono"].Value.ToString();
            txtcelular.Text = dgv.CurrentRow.Cells["celular"].Value.ToString();
            txtemail.Text = dgv.CurrentRow.Cells["email"].Value.ToString();
            txtciudad.Text = dgv.CurrentRow.Cells["ciudad"].Value.ToString();
            txtpais.Text = dgv.CurrentRow.Cells["pais"].Value.ToString();
            txtclave.Text = dgv.CurrentRow.Cells["clave"].Value.ToString();
            byte[] imagen = (byte[]) dgv.CurrentRow.Cells["foto"].Value;
            MemoryStream ms = new MemoryStream(imagen);
            pbimagen.Image = Image.FromStream(ms);
            chkActivo.Checked = Convert.ToBoolean(dgv.CurrentRow.Cells["activo"].Value);
            txtbase.Text = dgv.CurrentRow.Cells["salario_base"].Value.ToString();
            txtcomision.Text = dgv.CurrentRow.Cells["comision"].Value.ToString();
            cbxRole.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["role_id"].Value);
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
                        CVendedores.eliminar(codigo);
                        MessageBox.Show("Registro eliminado con exito");
                        limpiarCampos();
                        inHabilitarBotones();
                        mostrar();
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
                    mostrar();
                }
            }
            else
            {
                Messages.messageWarning("El codigo no se ha seleccionado", "Campo vacio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarRoles();
        }
    }
}
