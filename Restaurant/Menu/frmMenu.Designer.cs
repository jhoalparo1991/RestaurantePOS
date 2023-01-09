namespace Restaurant.Menu
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssVendedor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNombrePc = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheros = new System.Windows.Forms.ToolStripMenuItem();
            this.smAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.smVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.smRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.smSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.smSalones = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tcMenus = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelContenedorMesas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fypSalones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalon = new System.Windows.Forms.Label();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.smMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.tcMenus.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelContenedorMesas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fypSalones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssVendedor,
            this.tssRole,
            this.tssFecha,
            this.tssHora,
            this.tssNombrePc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssVendedor
            // 
            this.tssVendedor.ForeColor = System.Drawing.Color.White;
            this.tssVendedor.Name = "tssVendedor";
            this.tssVendedor.Size = new System.Drawing.Size(67, 19);
            this.tssVendedor.Text = "vendedor";
            // 
            // tssRole
            // 
            this.tssRole.ForeColor = System.Drawing.Color.White;
            this.tssRole.Name = "tssRole";
            this.tssRole.Size = new System.Drawing.Size(32, 19);
            this.tssRole.Text = "role";
            // 
            // tssFecha
            // 
            this.tssFecha.ForeColor = System.Drawing.Color.White;
            this.tssFecha.Name = "tssFecha";
            this.tssFecha.Size = new System.Drawing.Size(41, 19);
            this.tssFecha.Text = "fecha";
            // 
            // tssHora
            // 
            this.tssHora.ForeColor = System.Drawing.Color.White;
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(37, 19);
            this.tssHora.Text = "hora";
            // 
            // tssNombrePc
            // 
            this.tssNombrePc.ForeColor = System.Drawing.Color.White;
            this.tssNombrePc.Name = "tssNombrePc";
            this.tssNombrePc.Size = new System.Drawing.Size(75, 19);
            this.tssNombrePc.Text = "nombre pc";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeVentanas,
            this.menuFicheros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeVentanas
            // 
            this.closeVentanas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.closeVentanas.Name = "closeVentanas";
            this.closeVentanas.Size = new System.Drawing.Size(31, 25);
            this.closeVentanas.Text = "x";
            this.closeVentanas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeVentanas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.closeVentanas.Click += new System.EventHandler(this.closeVentanas_Click);
            // 
            // menuFicheros
            // 
            this.menuFicheros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smAdministracion,
            this.smSalas});
            this.menuFicheros.Name = "menuFicheros";
            this.menuFicheros.Size = new System.Drawing.Size(58, 25);
            this.menuFicheros.Text = "Fichero";
            // 
            // smAdministracion
            // 
            this.smAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smVendedores,
            this.smRoles});
            this.smAdministracion.Name = "smAdministracion";
            this.smAdministracion.Size = new System.Drawing.Size(180, 22);
            this.smAdministracion.Text = "Administracion";
            // 
            // smVendedores
            // 
            this.smVendedores.Name = "smVendedores";
            this.smVendedores.Size = new System.Drawing.Size(135, 22);
            this.smVendedores.Text = "Vendedores";
            this.smVendedores.Click += new System.EventHandler(this.smVendedores_Click);
            // 
            // smRoles
            // 
            this.smRoles.Name = "smRoles";
            this.smRoles.Size = new System.Drawing.Size(135, 22);
            this.smRoles.Text = "Roles";
            this.smRoles.Click += new System.EventHandler(this.smRoles_Click);
            // 
            // smSalas
            // 
            this.smSalas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smSalones,
            this.smMesas});
            this.smSalas.Name = "smSalas";
            this.smSalas.Size = new System.Drawing.Size(180, 22);
            this.smSalas.Text = "Salas";
            // 
            // smSalones
            // 
            this.smSalones.Name = "smSalones";
            this.smSalones.Size = new System.Drawing.Size(180, 22);
            this.smSalones.Text = "Salones";
            this.smSalones.Click += new System.EventHandler(this.smSalones_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.tcMenus);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 29);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(768, 324);
            this.panelContenedor.TabIndex = 2;
            // 
            // tcMenus
            // 
            this.tcMenus.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMenus.Controls.Add(this.tabPage1);
            this.tcMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMenus.Location = new System.Drawing.Point(0, 0);
            this.tcMenus.Name = "tcMenus";
            this.tcMenus.SelectedIndex = 0;
            this.tcMenus.Size = new System.Drawing.Size(768, 324);
            this.tcMenus.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelContenedorMesas);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visor mesas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelContenedorMesas
            // 
            this.panelContenedorMesas.Controls.Add(this.panelMesas);
            this.panelContenedorMesas.Controls.Add(this.panel3);
            this.panelContenedorMesas.Controls.Add(this.panel1);
            this.panelContenedorMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMesas.Location = new System.Drawing.Point(3, 3);
            this.panelContenedorMesas.Name = "panelContenedorMesas";
            this.panelContenedorMesas.Size = new System.Drawing.Size(754, 286);
            this.panelContenedorMesas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "VisorMesas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fypSalones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 286);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 92);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fypSalones
            // 
            this.fypSalones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fypSalones.Controls.Add(this.button1);
            this.fypSalones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fypSalones.Location = new System.Drawing.Point(0, 36);
            this.fypSalones.Name = "fypSalones";
            this.fypSalones.Size = new System.Drawing.Size(165, 158);
            this.fypSalones.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSalon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(165, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 36);
            this.panel3.TabIndex = 2;
            // 
            // lblSalon
            // 
            this.lblSalon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalon.ForeColor = System.Drawing.Color.White;
            this.lblSalon.Location = new System.Drawing.Point(0, 0);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(589, 36);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMesas
            // 
            this.panelMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesas.Location = new System.Drawing.Point(165, 36);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(589, 250);
            this.panelMesas.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = global::Restaurant.Properties.Resources.esperar32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Esperar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Image = global::Restaurant.Properties.Resources.salir32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // smMesas
            // 
            this.smMesas.Name = "smMesas";
            this.smMesas.Size = new System.Drawing.Size(180, 22);
            this.smMesas.Text = "Mesas";
            this.smMesas.Click += new System.EventHandler(this.smMesas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 377);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Visor de mesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.tcMenus.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelContenedorMesas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.fypSalones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssVendedor;
        private System.Windows.Forms.ToolStripStatusLabel tssRole;
        private System.Windows.Forms.ToolStripStatusLabel tssFecha;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.ToolStripStatusLabel tssNombrePc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFicheros;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelContenedorMesas;
        private System.Windows.Forms.TabControl tcMenus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem smAdministracion;
        private System.Windows.Forms.ToolStripMenuItem smVendedores;
        private System.Windows.Forms.ToolStripMenuItem smRoles;
        private System.Windows.Forms.ToolStripMenuItem closeVentanas;
        private System.Windows.Forms.ToolStripMenuItem smSalas;
        private System.Windows.Forms.ToolStripMenuItem smSalones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fypSalones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.ToolStripMenuItem smMesas;
    }
}