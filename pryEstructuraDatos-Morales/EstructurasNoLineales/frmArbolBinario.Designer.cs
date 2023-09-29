namespace pryEstructuraDatos_Morales.EstructurasNoLineales
{
    partial class frmArbolBinario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNuevoElemento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbValor = new System.Windows.Forms.ComboBox();
            this.lblEliminarElemento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblValorElim = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.optPost = new System.Windows.Forms.RadioButton();
            this.optDescOrd = new System.Windows.Forms.RadioButton();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.optPre = new System.Windows.Forms.RadioButton();
            this.optAscOrd = new System.Windows.Forms.RadioButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.tv = new System.Windows.Forms.TreeView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblNuevoElemento);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 224);
            this.panel1.TabIndex = 21;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValor.Location = new System.Drawing.Point(123, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramite.Location = new System.Drawing.Point(81, 130);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(136, 26);
            this.txtTramite.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            // lblNuevoElemento
            // 
            this.lblNuevoElemento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNuevoElemento.Location = new System.Drawing.Point(3, 5);
            this.lblNuevoElemento.Name = "lblNuevoElemento";
            this.lblNuevoElemento.Size = new System.Drawing.Size(222, 30);
            this.lblNuevoElemento.TabIndex = 12;
            this.lblNuevoElemento.Text = "Nuevo Elemento";
            this.lblNuevoElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.cbValor);
            this.panel2.Controls.Add(this.lblEliminarElemento);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.lblValorElim);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 153);
            this.panel2.TabIndex = 22;
            // 
            // cbValor
            // 
            this.cbValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.cbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbValor.FormattingEnabled = true;
            this.cbValor.Location = new System.Drawing.Point(95, 51);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(121, 28);
            this.cbValor.TabIndex = 13;
            // 
            // lblEliminarElemento
            // 
            this.lblEliminarElemento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEliminarElemento.Location = new System.Drawing.Point(3, 5);
            this.lblEliminarElemento.Name = "lblEliminarElemento";
            this.lblEliminarElemento.Size = new System.Drawing.Size(222, 30);
            this.lblEliminarElemento.TabIndex = 12;
            this.lblEliminarElemento.Text = "Eliminar Elemento";
            this.lblEliminarElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(63, 92);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 39);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblValorElim
            // 
            this.lblValorElim.AutoSize = true;
            this.lblValorElim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValorElim.Location = new System.Drawing.Point(8, 55);
            this.lblValorElim.Name = "lblValorElim";
            this.lblValorElim.Size = new System.Drawing.Size(50, 20);
            this.lblValorElim.TabIndex = 6;
            this.lblValorElim.Text = "Valor:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel4.Controls.Add(this.optPost);
            this.panel4.Controls.Add(this.optDescOrd);
            this.panel4.Controls.Add(this.lblOrdenar);
            this.panel4.Controls.Add(this.optPre);
            this.panel4.Controls.Add(this.optAscOrd);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(260, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 224);
            this.panel4.TabIndex = 27;
            // 
            // optPost
            // 
            this.optPost.AutoSize = true;
            this.optPost.Location = new System.Drawing.Point(32, 161);
            this.optPost.Name = "optPost";
            this.optPost.Size = new System.Drawing.Size(99, 24);
            this.optPost.TabIndex = 16;
            this.optPost.Text = "PostOrder";
            this.optPost.UseVisualStyleBackColor = true;
            this.optPost.CheckedChanged += new System.EventHandler(this.optPost_CheckedChanged);
            // 
            // optDescOrd
            // 
            this.optDescOrd.AutoSize = true;
            this.optDescOrd.Location = new System.Drawing.Point(55, 79);
            this.optDescOrd.Name = "optDescOrd";
            this.optDescOrd.Size = new System.Drawing.Size(123, 24);
            this.optDescOrd.TabIndex = 16;
            this.optDescOrd.Text = "Descendente";
            this.optDescOrd.UseVisualStyleBackColor = true;
            this.optDescOrd.CheckedChanged += new System.EventHandler(this.optDescOrd_CheckedChanged);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOrdenar.Location = new System.Drawing.Point(6, 5);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(111, 30);
            this.lblOrdenar.TabIndex = 12;
            this.lblOrdenar.Text = "InOrder";
            this.lblOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optPre
            // 
            this.optPre.AutoSize = true;
            this.optPre.Location = new System.Drawing.Point(32, 120);
            this.optPre.Name = "optPre";
            this.optPre.Size = new System.Drawing.Size(91, 24);
            this.optPre.TabIndex = 15;
            this.optPre.Text = "PreOrder";
            this.optPre.UseVisualStyleBackColor = true;
            this.optPre.CheckedChanged += new System.EventHandler(this.optPre_CheckedChanged);
            // 
            // optAscOrd
            // 
            this.optAscOrd.AutoSize = true;
            this.optAscOrd.Checked = true;
            this.optAscOrd.Location = new System.Drawing.Point(55, 38);
            this.optAscOrd.Name = "optAscOrd";
            this.optAscOrd.Size = new System.Drawing.Size(113, 24);
            this.optAscOrd.TabIndex = 15;
            this.optAscOrd.TabStop = true;
            this.optAscOrd.Text = "Ascendente";
            this.optAscOrd.UseVisualStyleBackColor = true;
            this.optAscOrd.CheckedChanged += new System.EventHandler(this.optAscOrd_CheckedChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeight = 35;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Nombre,
            this.Tramite});
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvDatos.Location = new System.Drawing.Point(260, 254);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.RowTemplate.Height = 30;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(399, 370);
            this.dgvDatos.TabIndex = 29;
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
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.lstDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(12, 424);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(228, 200);
            this.lstDatos.TabIndex = 30;
            this.lstDatos.TabStop = false;
            // 
            // tv
            // 
            this.tv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.tv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tv.Location = new System.Drawing.Point(680, 254);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(260, 370);
            this.tv.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel6.Controls.Add(this.picImagen);
            this.panel6.Location = new System.Drawing.Point(481, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 224);
            this.panel6.TabIndex = 32;
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picImagen.Image = ((System.Drawing.Image)(resources.GetObject("picImagen.Image")));
            this.picImagen.Location = new System.Drawing.Point(0, 0);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(459, 224);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(956, 637);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Ramificada - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbValor;
        private System.Windows.Forms.Label lblEliminarElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblValorElim;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton optDescOrd;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.RadioButton optAscOrd;
        private System.Windows.Forms.RadioButton optPost;
        private System.Windows.Forms.RadioButton optPre;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox picImagen;
    }
}