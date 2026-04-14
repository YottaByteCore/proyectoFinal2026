namespace Sistema_Estudiantil
{
    partial class ContenedorProfesor
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
            this.presentar2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Panel();
            this.txtEspecial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Estado2 = new System.Windows.Forms.ComboBox();
            this.Email2 = new System.Windows.Forms.TextBox();
            this.Telefono2 = new System.Windows.Forms.TextBox();
            this.Apellido2 = new System.Windows.Forms.TextBox();
            this.Nombre2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnEditar1 = new System.Windows.Forms.Button();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presentar2)).BeginInit();
            this.panel2.SuspendLayout();
            this.Dato.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // presentar2
            // 
            this.presentar2.AllowUserToAddRows = false;
            this.presentar2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presentar2.BackgroundColor = System.Drawing.Color.White;
            this.presentar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presentar2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.presentar2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.presentar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.presentar2.DefaultCellStyle = dataGridViewCellStyle2;
            this.presentar2.EnableHeadersVisualStyles = false;
            this.presentar2.Location = new System.Drawing.Point(786, 106);
            this.presentar2.MultiSelect = false;
            this.presentar2.Name = "presentar2";
            this.presentar2.RowHeadersWidth = 51;
            this.presentar2.RowTemplate.Height = 24;
            this.presentar2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentar2.Size = new System.Drawing.Size(785, 575);
            this.presentar2.TabIndex = 4;
            this.presentar2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentar2_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 100);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seccion de Profesores";
            // 
            // Dato
            // 
            this.Dato.Controls.Add(this.txtEspecial);
            this.Dato.Controls.Add(this.label8);
            this.Dato.Controls.Add(this.label7);
            this.Dato.Controls.Add(this.label6);
            this.Dato.Controls.Add(this.label4);
            this.Dato.Controls.Add(this.label3);
            this.Dato.Controls.Add(this.label2);
            this.Dato.Controls.Add(this.Estado2);
            this.Dato.Controls.Add(this.Email2);
            this.Dato.Controls.Add(this.Telefono2);
            this.Dato.Controls.Add(this.Apellido2);
            this.Dato.Controls.Add(this.Nombre2);
            this.Dato.Location = new System.Drawing.Point(29, 130);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(751, 265);
            this.Dato.TabIndex = 6;
            // 
            // txtEspecial
            // 
            this.txtEspecial.Location = new System.Drawing.Point(524, 25);
            this.txtEspecial.Name = "txtEspecial";
            this.txtEspecial.Size = new System.Drawing.Size(176, 22);
            this.txtEspecial.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // Estado2
            // 
            this.Estado2.FormattingEnabled = true;
            this.Estado2.Location = new System.Drawing.Point(524, 151);
            this.Estado2.Name = "Estado2";
            this.Estado2.Size = new System.Drawing.Size(154, 24);
            this.Estado2.TabIndex = 6;
            // 
            // Email2
            // 
            this.Email2.Location = new System.Drawing.Point(524, 85);
            this.Email2.Name = "Email2";
            this.Email2.Size = new System.Drawing.Size(176, 22);
            this.Email2.TabIndex = 5;
            // 
            // Telefono2
            // 
            this.Telefono2.Location = new System.Drawing.Point(115, 151);
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.Size = new System.Drawing.Size(251, 22);
            this.Telefono2.TabIndex = 4;
            // 
            // Apellido2
            // 
            this.Apellido2.Location = new System.Drawing.Point(115, 83);
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.Size = new System.Drawing.Size(251, 22);
            this.Apellido2.TabIndex = 1;
            // 
            // Nombre2
            // 
            this.Nombre2.Location = new System.Drawing.Point(115, 23);
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Size = new System.Drawing.Size(251, 22);
            this.Nombre2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar1);
            this.panel1.Controls.Add(this.btnEliminar1);
            this.panel1.Controls.Add(this.btnEditar1);
            this.panel1.Controls.Add(this.btnGuardar1);
            this.panel1.Location = new System.Drawing.Point(29, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 7;
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar1.Location = new System.Drawing.Point(585, 26);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(97, 41);
            this.btnLimpiar1.TabIndex = 3;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Location = new System.Drawing.Point(390, 26);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(97, 41);
            this.btnEliminar1.TabIndex = 2;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar1.Location = new System.Drawing.Point(215, 26);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(97, 41);
            this.btnEditar1.TabIndex = 1;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.UseVisualStyleBackColor = true;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar1.Location = new System.Drawing.Point(44, 26);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(97, 41);
            this.btnGuardar1.TabIndex = 0;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // ContenedorProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.presentar2);
            this.Name = "ContenedorProfesor";
            this.Size = new System.Drawing.Size(1651, 736);
            this.Load += new System.EventHandler(this.ContenedorProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presentar2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Dato.ResumeLayout(false);
            this.Dato.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView presentar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Estado2;
        private System.Windows.Forms.TextBox Email2;
        private System.Windows.Forms.TextBox Telefono2;
        private System.Windows.Forms.TextBox Apellido2;
        private System.Windows.Forms.TextBox Nombre2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnEditar1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtEspecial;
    }
}
