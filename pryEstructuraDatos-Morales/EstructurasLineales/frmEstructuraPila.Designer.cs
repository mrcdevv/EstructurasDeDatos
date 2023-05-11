namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    partial class frmEstructuraPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraPila));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteElim = new System.Windows.Forms.TextBox();
            this.txtNombreElim = new System.Windows.Forms.TextBox();
            this.txtValorElim = new System.Windows.Forms.TextBox();
            this.lblTramiteElim = new System.Windows.Forms.Label();
            this.lblNombreElim = new System.Windows.Forms.Label();
            this.lblValorElim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(511, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 224);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.ColumnHeadersHeight = 35;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Nombre,
            this.Tramite});
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.dgvDatos.Location = new System.Drawing.Point(262, 251);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDatos.Size = new System.Drawing.Size(450, 260);
            this.dgvDatos.TabIndex = 18;
            this.dgvDatos.TabStop = false;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.txtTramiteElim);
            this.panel2.Controls.Add(this.txtNombreElim);
            this.panel2.Controls.Add(this.txtValorElim);
            this.panel2.Controls.Add(this.lblTramiteElim);
            this.panel2.Controls.Add(this.lblNombreElim);
            this.panel2.Controls.Add(this.lblValorElim);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(262, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 224);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Elemento Eliminado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(62, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 39);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTramiteElim
            // 
            this.txtTramiteElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtTramiteElim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramiteElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramiteElim.Location = new System.Drawing.Point(78, 130);
            this.txtTramiteElim.Name = "txtTramiteElim";
            this.txtTramiteElim.ReadOnly = true;
            this.txtTramiteElim.Size = new System.Drawing.Size(136, 26);
            this.txtTramiteElim.TabIndex = 12;
            this.txtTramiteElim.TabStop = false;
            // 
            // txtNombreElim
            // 
            this.txtNombreElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtNombreElim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombreElim.Location = new System.Drawing.Point(78, 89);
            this.txtNombreElim.Name = "txtNombreElim";
            this.txtNombreElim.ReadOnly = true;
            this.txtNombreElim.Size = new System.Drawing.Size(136, 26);
            this.txtNombreElim.TabIndex = 11;
            this.txtNombreElim.TabStop = false;
            // 
            // txtValorElim
            // 
            this.txtValorElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtValorElim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValorElim.Location = new System.Drawing.Point(121, 48);
            this.txtValorElim.Name = "txtValorElim";
            this.txtValorElim.ReadOnly = true;
            this.txtValorElim.Size = new System.Drawing.Size(93, 26);
            this.txtValorElim.TabIndex = 10;
            this.txtValorElim.TabStop = false;
            // 
            // lblTramiteElim
            // 
            this.lblTramiteElim.AutoSize = true;
            this.lblTramiteElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTramiteElim.Location = new System.Drawing.Point(8, 133);
            this.lblTramiteElim.Name = "lblTramiteElim";
            this.lblTramiteElim.Size = new System.Drawing.Size(66, 20);
            this.lblTramiteElim.TabIndex = 9;
            this.lblTramiteElim.Text = "Tramite:";
            // 
            // lblNombreElim
            // 
            this.lblNombreElim.AutoSize = true;
            this.lblNombreElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreElim.Location = new System.Drawing.Point(8, 92);
            this.lblNombreElim.Name = "lblNombreElim";
            this.lblNombreElim.Size = new System.Drawing.Size(69, 20);
            this.lblNombreElim.TabIndex = 7;
            this.lblNombreElim.Text = "Nombre:";
            // 
            // lblValorElim
            // 
            this.lblValorElim.AutoSize = true;
            this.lblValorElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValorElim.Location = new System.Drawing.Point(8, 51);
            this.lblValorElim.Name = "lblValorElim";
            this.lblValorElim.Size = new System.Drawing.Size(50, 20);
            this.lblValorElim.TabIndex = 6;
            this.lblValorElim.Text = "Valor:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtTramite);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblTramite);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 224);
            this.panel1.TabIndex = 14;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtValor.Location = new System.Drawing.Point(123, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 26);
            this.txtValor.TabIndex = 17;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.Color.White;
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtTramite.Location = new System.Drawing.Point(80, 130);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(136, 26);
            this.txtTramite.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtNombre.Location = new System.Drawing.Point(80, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTramite.Location = new System.Drawing.Point(10, 133);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(66, 20);
            this.lblTramite.TabIndex = 16;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(10, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValor.Location = new System.Drawing.Point(10, 51);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nuevo Elemento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(62, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 39);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.lstDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(12, 251);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(228, 260);
            this.lstDatos.TabIndex = 15;
            this.lstDatos.TabStop = false;
            // 
            // frmEstructuraPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(725, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstructuraPila";
            this.Text = "Estructura Dinamica Lineal - Pila";
            this.Load += new System.EventHandler(this.frmEstructuraPila_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteElim;
        private System.Windows.Forms.TextBox txtNombreElim;
        private System.Windows.Forms.TextBox txtValorElim;
        private System.Windows.Forms.Label lblTramiteElim;
        private System.Windows.Forms.Label lblNombreElim;
        private System.Windows.Forms.Label lblValorElim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstDatos;
    }
}