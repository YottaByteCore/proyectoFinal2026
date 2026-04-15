namespace Sistema_Estudiantil
{
    partial class NotaContenedor
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar4 = new System.Windows.Forms.Button();
            this.btnEliminar4 = new System.Windows.Forms.Button();
            this.btnEditar4 = new System.Windows.Forms.Button();
            this.btnGuardar4 = new System.Windows.Forms.Button();
            this.presentar4 = new System.Windows.Forms.DataGridView();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.Dato.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentar4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 100);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seccion de Nota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dato
            // 
            this.Dato.Controls.Add(this.dtFecha);
            this.Dato.Controls.Add(this.cbMateria);
            this.Dato.Controls.Add(this.cbAlumnos);
            this.Dato.Controls.Add(this.label8);
            this.Dato.Controls.Add(this.label7);
            this.Dato.Controls.Add(this.label6);
            this.Dato.Controls.Add(this.label3);
            this.Dato.Controls.Add(this.label2);
            this.Dato.Controls.Add(this.txtPeriodo);
            this.Dato.Controls.Add(this.txtNota);
            this.Dato.Location = new System.Drawing.Point(29, 118);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(751, 265);
            this.Dato.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Periodo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alumnos:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(524, 124);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(176, 22);
            this.txtPeriodo.TabIndex = 5;
            this.txtPeriodo.TextChanged += new System.EventHandler(this.txtPeriodo_TextChanged);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(130, 197);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(142, 22);
            this.txtNota.TabIndex = 4;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar4);
            this.panel1.Controls.Add(this.btnEliminar4);
            this.panel1.Controls.Add(this.btnEditar4);
            this.panel1.Controls.Add(this.btnGuardar4);
            this.panel1.Location = new System.Drawing.Point(29, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnLimpiar4
            // 
            this.btnLimpiar4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar4.Location = new System.Drawing.Point(585, 26);
            this.btnLimpiar4.Name = "btnLimpiar4";
            this.btnLimpiar4.Size = new System.Drawing.Size(97, 41);
            this.btnLimpiar4.TabIndex = 3;
            this.btnLimpiar4.Text = "Limpiar";
            this.btnLimpiar4.UseVisualStyleBackColor = true;
            this.btnLimpiar4.Click += new System.EventHandler(this.btnLimpiar4_Click);
            // 
            // btnEliminar4
            // 
            this.btnEliminar4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar4.Location = new System.Drawing.Point(390, 26);
            this.btnEliminar4.Name = "btnEliminar4";
            this.btnEliminar4.Size = new System.Drawing.Size(97, 41);
            this.btnEliminar4.TabIndex = 2;
            this.btnEliminar4.Text = "Eliminar";
            this.btnEliminar4.UseVisualStyleBackColor = true;
            this.btnEliminar4.Click += new System.EventHandler(this.btnEliminar4_Click);
            // 
            // btnEditar4
            // 
            this.btnEditar4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar4.Location = new System.Drawing.Point(215, 26);
            this.btnEditar4.Name = "btnEditar4";
            this.btnEditar4.Size = new System.Drawing.Size(97, 41);
            this.btnEditar4.TabIndex = 1;
            this.btnEditar4.Text = "Editar";
            this.btnEditar4.UseVisualStyleBackColor = true;
            this.btnEditar4.Click += new System.EventHandler(this.btnEditar4_Click);
            // 
            // btnGuardar4
            // 
            this.btnGuardar4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar4.Location = new System.Drawing.Point(44, 26);
            this.btnGuardar4.Name = "btnGuardar4";
            this.btnGuardar4.Size = new System.Drawing.Size(97, 41);
            this.btnGuardar4.TabIndex = 0;
            this.btnGuardar4.Text = "Guardar";
            this.btnGuardar4.UseVisualStyleBackColor = true;
            this.btnGuardar4.Click += new System.EventHandler(this.btnGuardar4_Click);
            // 
            // presentar4
            // 
            this.presentar4.AllowUserToAddRows = false;
            this.presentar4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presentar4.BackgroundColor = System.Drawing.Color.White;
            this.presentar4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presentar4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.presentar4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.presentar4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.presentar4.DefaultCellStyle = dataGridViewCellStyle2;
            this.presentar4.EnableHeadersVisualStyles = false;
            this.presentar4.Location = new System.Drawing.Point(795, 118);
            this.presentar4.MultiSelect = false;
            this.presentar4.Name = "presentar4";
            this.presentar4.RowHeadersWidth = 51;
            this.presentar4.RowTemplate.Height = 24;
            this.presentar4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentar4.Size = new System.Drawing.Size(811, 575);
            this.presentar4.TabIndex = 9;
            this.presentar4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentar4_CellContentClick);
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(130, 21);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(236, 24);
            this.cbAlumnos.TabIndex = 15;
            this.cbAlumnos.SelectedIndexChanged += new System.EventHandler(this.cbAlumnos_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(130, 120);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(236, 24);
            this.cbMateria.TabIndex = 16;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(524, 210);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(185, 22);
            this.dtFecha.TabIndex = 17;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // NotaContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.presentar4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.panel2);
            this.Name = "NotaContenedor";
            this.Size = new System.Drawing.Size(1651, 736);
            this.Load += new System.EventHandler(this.NotaContenedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Dato.ResumeLayout(false);
            this.Dato.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presentar4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar4;
        private System.Windows.Forms.Button btnEliminar4;
        private System.Windows.Forms.Button btnEditar4;
        private System.Windows.Forms.Button btnGuardar4;
        private System.Windows.Forms.DataGridView presentar4;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}
