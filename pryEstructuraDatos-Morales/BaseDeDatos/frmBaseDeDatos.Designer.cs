
namespace pryEstructuraDatos_Morales.BaseDeDatos
{
    partial class frmBaseDeDatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProyeccionJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMulti = new System.Windows.Forms.Button();
            this.lblEliminarElemento = new System.Windows.Forms.Label();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionConv = new System.Windows.Forms.Button();
            this.btnSeleccionMulti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAlgeDiferencia = new System.Windows.Forms.Button();
            this.btnAlgInterseccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlgUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatos.ColumnHeadersHeight = 35;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatos.RowTemplate.Height = 30;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(805, 314);
            this.dgvDatos.TabIndex = 30;
            this.dgvDatos.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btnProyeccionJuntar);
            this.panel2.Controls.Add(this.btnProyeccionMulti);
            this.panel2.Controls.Add(this.lblEliminarElemento);
            this.panel2.Controls.Add(this.btnProyeccionSimple);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 225);
            this.panel2.TabIndex = 31;
            // 
            // btnProyeccionJuntar
            // 
            this.btnProyeccionJuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnProyeccionJuntar.FlatAppearance.BorderSize = 0;
            this.btnProyeccionJuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyeccionJuntar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProyeccionJuntar.Location = new System.Drawing.Point(18, 170);
            this.btnProyeccionJuntar.Name = "btnProyeccionJuntar";
            this.btnProyeccionJuntar.Size = new System.Drawing.Size(215, 34);
            this.btnProyeccionJuntar.TabIndex = 14;
            this.btnProyeccionJuntar.Text = "Juntar";
            this.btnProyeccionJuntar.UseVisualStyleBackColor = false;
            this.btnProyeccionJuntar.Click += new System.EventHandler(this.btnProyeccionJuntar_Click);
            // 
            // btnProyeccionMulti
            // 
            this.btnProyeccionMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnProyeccionMulti.FlatAppearance.BorderSize = 0;
            this.btnProyeccionMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyeccionMulti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProyeccionMulti.Location = new System.Drawing.Point(18, 109);
            this.btnProyeccionMulti.Name = "btnProyeccionMulti";
            this.btnProyeccionMulti.Size = new System.Drawing.Size(215, 34);
            this.btnProyeccionMulti.TabIndex = 13;
            this.btnProyeccionMulti.Text = "Proyección multiatributo";
            this.btnProyeccionMulti.UseVisualStyleBackColor = false;
            this.btnProyeccionMulti.Click += new System.EventHandler(this.btnProyeccionMulti_Click);
            // 
            // lblEliminarElemento
            // 
            this.lblEliminarElemento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEliminarElemento.Location = new System.Drawing.Point(1, 1);
            this.lblEliminarElemento.Name = "lblEliminarElemento";
            this.lblEliminarElemento.Size = new System.Drawing.Size(258, 30);
            this.lblEliminarElemento.TabIndex = 12;
            this.lblEliminarElemento.Text = "Operaciones de Proyección";
            this.lblEliminarElemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnProyeccionSimple.FlatAppearance.BorderSize = 0;
            this.btnProyeccionSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyeccionSimple.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProyeccionSimple.Location = new System.Drawing.Point(18, 49);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(215, 34);
            this.btnProyeccionSimple.TabIndex = 5;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = false;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnSeleccionConv);
            this.panel1.Controls.Add(this.btnSeleccionMulti);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSeleccionSimple);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(284, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 225);
            this.panel1.TabIndex = 32;
            // 
            // btnSeleccionConv
            // 
            this.btnSeleccionConv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnSeleccionConv.FlatAppearance.BorderSize = 0;
            this.btnSeleccionConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionConv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionConv.Location = new System.Drawing.Point(18, 170);
            this.btnSeleccionConv.Name = "btnSeleccionConv";
            this.btnSeleccionConv.Size = new System.Drawing.Size(215, 34);
            this.btnSeleccionConv.TabIndex = 14;
            this.btnSeleccionConv.Text = "Selección por convolución";
            this.btnSeleccionConv.UseVisualStyleBackColor = false;
            this.btnSeleccionConv.Click += new System.EventHandler(this.btnSeleccionConv_Click);
            // 
            // btnSeleccionMulti
            // 
            this.btnSeleccionMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnSeleccionMulti.FlatAppearance.BorderSize = 0;
            this.btnSeleccionMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionMulti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionMulti.Location = new System.Drawing.Point(18, 109);
            this.btnSeleccionMulti.Name = "btnSeleccionMulti";
            this.btnSeleccionMulti.Size = new System.Drawing.Size(215, 34);
            this.btnSeleccionMulti.TabIndex = 13;
            this.btnSeleccionMulti.Text = "Selección multiatributo";
            this.btnSeleccionMulti.UseVisualStyleBackColor = false;
            this.btnSeleccionMulti.Click += new System.EventHandler(this.btnSeleccionMulti_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Operaciones de Slección";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnSeleccionSimple.FlatAppearance.BorderSize = 0;
            this.btnSeleccionSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionSimple.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionSimple.Location = new System.Drawing.Point(18, 49);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(215, 34);
            this.btnSeleccionSimple.TabIndex = 5;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = false;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.btnAlgeDiferencia);
            this.panel3.Controls.Add(this.btnAlgInterseccion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnAlgUnion);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(556, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 225);
            this.panel3.TabIndex = 33;
            // 
            // btnAlgeDiferencia
            // 
            this.btnAlgeDiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnAlgeDiferencia.FlatAppearance.BorderSize = 0;
            this.btnAlgeDiferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgeDiferencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlgeDiferencia.Location = new System.Drawing.Point(18, 170);
            this.btnAlgeDiferencia.Name = "btnAlgeDiferencia";
            this.btnAlgeDiferencia.Size = new System.Drawing.Size(215, 34);
            this.btnAlgeDiferencia.TabIndex = 14;
            this.btnAlgeDiferencia.Text = "Diferencia";
            this.btnAlgeDiferencia.UseVisualStyleBackColor = false;
            this.btnAlgeDiferencia.Click += new System.EventHandler(this.btnAlgeDiferencia_Click);
            // 
            // btnAlgInterseccion
            // 
            this.btnAlgInterseccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnAlgInterseccion.FlatAppearance.BorderSize = 0;
            this.btnAlgInterseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgInterseccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlgInterseccion.Location = new System.Drawing.Point(18, 109);
            this.btnAlgInterseccion.Name = "btnAlgInterseccion";
            this.btnAlgInterseccion.Size = new System.Drawing.Size(215, 34);
            this.btnAlgInterseccion.TabIndex = 13;
            this.btnAlgInterseccion.Text = "Intersección";
            this.btnAlgInterseccion.UseVisualStyleBackColor = false;
            this.btnAlgInterseccion.Click += new System.EventHandler(this.btnAlgInterseccion_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Operaciones de Algebraicas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlgUnion
            // 
            this.btnAlgUnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(224)))));
            this.btnAlgUnion.FlatAppearance.BorderSize = 0;
            this.btnAlgUnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgUnion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlgUnion.Location = new System.Drawing.Point(18, 49);
            this.btnAlgUnion.Name = "btnAlgUnion";
            this.btnAlgUnion.Size = new System.Drawing.Size(215, 34);
            this.btnAlgUnion.TabIndex = 5;
            this.btnAlgUnion.Text = "Union";
            this.btnAlgUnion.UseVisualStyleBackColor = false;
            this.btnAlgUnion.Click += new System.EventHandler(this.btnAlgUnion_Click);
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(829, 579);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDeDatos";
            this.Load += new System.EventHandler(this.frmBaseDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProyeccionJuntar;
        private System.Windows.Forms.Button btnProyeccionMulti;
        private System.Windows.Forms.Label lblEliminarElemento;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeleccionConv;
        private System.Windows.Forms.Button btnSeleccionMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAlgeDiferencia;
        private System.Windows.Forms.Button btnAlgInterseccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlgUnion;
    }
}