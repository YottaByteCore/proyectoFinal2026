namespace Sistema_Estudiantil
{
    partial class MateriaContenedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar7 = new System.Windows.Forms.Button();
            this.btnEliminar7 = new System.Windows.Forms.Button();
            this.btnEditar7 = new System.Windows.Forms.Button();
            this.btnGuardar7 = new System.Windows.Forms.Button();
            this.presentar7 = new System.Windows.Forms.DataGridView();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.Dato.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentar7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seccion de Materias";
            // 
            // Dato
            // 
            this.Dato.Controls.Add(this.cbEstado);
            this.Dato.Controls.Add(this.cbProfesor);
            this.Dato.Controls.Add(this.txtDescripcion);
            this.Dato.Controls.Add(this.txtMateria);
            this.Dato.Controls.Add(this.label8);
            this.Dato.Controls.Add(this.label6);
            this.Dato.Controls.Add(this.label3);
            this.Dato.Controls.Add(this.label2);
            this.Dato.Location = new System.Drawing.Point(29, 123);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(751, 265);
            this.Dato.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Profesores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Materia:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar7);
            this.panel1.Controls.Add(this.btnEliminar7);
            this.panel1.Controls.Add(this.btnEditar7);
            this.panel1.Controls.Add(this.btnGuardar7);
            this.panel1.Location = new System.Drawing.Point(29, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 9;
            // 
            // btnLimpiar7
            // 
            this.btnLimpiar7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar7.Location = new System.Drawing.Point(585, 26);
            this.btnLimpiar7.Name = "btnLimpiar7";
            this.btnLimpiar7.Size = new System.Drawing.Size(97, 41);
            this.btnLimpiar7.TabIndex = 3;
            this.btnLimpiar7.Text = "Limpiar";
            this.btnLimpiar7.UseVisualStyleBackColor = true;
            this.btnLimpiar7.Click += new System.EventHandler(this.btnLimpiar7_Click);
            // 
            // btnEliminar7
            // 
            this.btnEliminar7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar7.Location = new System.Drawing.Point(390, 26);
            this.btnEliminar7.Name = "btnEliminar7";
            this.btnEliminar7.Size = new System.Drawing.Size(97, 41);
            this.btnEliminar7.TabIndex = 2;
            this.btnEliminar7.Text = "Eliminar";
            this.btnEliminar7.UseVisualStyleBackColor = true;
            this.btnEliminar7.Click += new System.EventHandler(this.btnEliminar7_Click);
            // 
            // btnEditar7
            // 
            this.btnEditar7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar7.Location = new System.Drawing.Point(215, 26);
            this.btnEditar7.Name = "btnEditar7";
            this.btnEditar7.Size = new System.Drawing.Size(97, 41);
            this.btnEditar7.TabIndex = 1;
            this.btnEditar7.Text = "Editar";
            this.btnEditar7.UseVisualStyleBackColor = true;
            this.btnEditar7.Click += new System.EventHandler(this.btnEditar7_Click);
            // 
            // btnGuardar7
            // 
            this.btnGuardar7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar7.Location = new System.Drawing.Point(44, 26);
            this.btnGuardar7.Name = "btnGuardar7";
            this.btnGuardar7.Size = new System.Drawing.Size(97, 41);
            this.btnGuardar7.TabIndex = 0;
            this.btnGuardar7.Text = "Guardar";
            this.btnGuardar7.UseVisualStyleBackColor = true;
            this.btnGuardar7.Click += new System.EventHandler(this.btnGuardar7_Click);
            // 
            // presentar7
            // 
            this.presentar7.AllowUserToAddRows = false;
            this.presentar7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presentar7.BackgroundColor = System.Drawing.Color.White;
            this.presentar7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presentar7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.presentar7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.presentar7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.presentar7.DefaultCellStyle = dataGridViewCellStyle4;
            this.presentar7.EnableHeadersVisualStyles = false;
            this.presentar7.Location = new System.Drawing.Point(803, 123);
            this.presentar7.MultiSelect = false;
            this.presentar7.Name = "presentar7";
            this.presentar7.RowHeadersWidth = 51;
            this.presentar7.RowTemplate.Height = 24;
            this.presentar7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentar7.Size = new System.Drawing.Size(785, 575);
            this.presentar7.TabIndex = 10;
            this.presentar7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentar7_CellContentClick);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(193, 28);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(208, 22);
            this.txtMateria.TabIndex = 17;
            this.txtMateria.TextChanged += new System.EventHandler(this.txtMateria_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(140, 107);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(208, 22);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(140, 189);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(208, 24);
            this.cbProfesor.TabIndex = 19;
            this.cbProfesor.SelectedIndexChanged += new System.EventHandler(this.cbProfesor_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(516, 28);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(166, 24);
            this.cbEstado.TabIndex = 20;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // MateriaContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.presentar7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.panel2);
            this.Name = "MateriaContenedor";
            this.Size = new System.Drawing.Size(1651, 736);
            this.Load += new System.EventHandler(this.MateriaContenedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Dato.ResumeLayout(false);
            this.Dato.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presentar7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar7;
        private System.Windows.Forms.Button btnEliminar7;
        private System.Windows.Forms.Button btnEditar7;
        private System.Windows.Forms.Button btnGuardar7;
        private System.Windows.Forms.DataGridView presentar7;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}
