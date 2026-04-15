namespace Sistema_Estudiantil
{
    partial class HorarioContenedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.presentar3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Panel();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtHoraInicial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar3 = new System.Windows.Forms.Button();
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.btnEditar3 = new System.Windows.Forms.Button();
            this.btnGuardar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presentar3)).BeginInit();
            this.panel2.SuspendLayout();
            this.Dato.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // presentar3
            // 
            this.presentar3.AllowUserToAddRows = false;
            this.presentar3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presentar3.BackgroundColor = System.Drawing.Color.White;
            this.presentar3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presentar3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.presentar3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.presentar3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.presentar3.DefaultCellStyle = dataGridViewCellStyle14;
            this.presentar3.EnableHeadersVisualStyles = false;
            this.presentar3.Location = new System.Drawing.Point(822, 116);
            this.presentar3.MultiSelect = false;
            this.presentar3.Name = "presentar3";
            this.presentar3.RowHeadersWidth = 51;
            this.presentar3.RowTemplate.Height = 24;
            this.presentar3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentar3.Size = new System.Drawing.Size(785, 575);
            this.presentar3.TabIndex = 5;
            this.presentar3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentar3_CellContentClick);
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
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seccion de Horario";
            // 
            // Dato
            // 
            this.Dato.Controls.Add(this.cbDia);
            this.Dato.Controls.Add(this.cbMateria);
            this.Dato.Controls.Add(this.txtHoraFin);
            this.Dato.Controls.Add(this.label8);
            this.Dato.Controls.Add(this.label6);
            this.Dato.Controls.Add(this.label4);
            this.Dato.Controls.Add(this.label3);
            this.Dato.Controls.Add(this.label2);
            this.Dato.Controls.Add(this.txtAula);
            this.Dato.Controls.Add(this.txtHoraInicial);
            this.Dato.Location = new System.Drawing.Point(29, 154);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(751, 265);
            this.Dato.TabIndex = 7;
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(115, 105);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(251, 24);
            this.cbDia.TabIndex = 16;
            this.cbDia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(115, 26);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(251, 24);
            this.cbMateria.TabIndex = 15;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(506, 30);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(176, 22);
            this.txtHoraFin.TabIndex = 14;
            this.txtHoraFin.TextChanged += new System.EventHandler(this.txtHoraFin_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Aula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora Inicial:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dia:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materia:";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(516, 109);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(176, 22);
            this.txtAula.TabIndex = 5;
            this.txtAula.TextChanged += new System.EventHandler(this.txtAula_TextChanged);
            // 
            // txtHoraInicial
            // 
            this.txtHoraInicial.Location = new System.Drawing.Point(140, 187);
            this.txtHoraInicial.Name = "txtHoraInicial";
            this.txtHoraInicial.Size = new System.Drawing.Size(226, 22);
            this.txtHoraInicial.TabIndex = 4;
            this.txtHoraInicial.TextChanged += new System.EventHandler(this.txtHoraInicial_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar3);
            this.panel1.Controls.Add(this.btnEliminar3);
            this.panel1.Controls.Add(this.btnEditar3);
            this.panel1.Controls.Add(this.btnGuardar3);
            this.panel1.Location = new System.Drawing.Point(29, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnLimpiar3
            // 
            this.btnLimpiar3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar3.Location = new System.Drawing.Point(585, 26);
            this.btnLimpiar3.Name = "btnLimpiar3";
            this.btnLimpiar3.Size = new System.Drawing.Size(97, 41);
            this.btnLimpiar3.TabIndex = 3;
            this.btnLimpiar3.Text = "Limpiar";
            this.btnLimpiar3.UseVisualStyleBackColor = true;
            this.btnLimpiar3.Click += new System.EventHandler(this.btnLimpiar3_Click);
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar3.Location = new System.Drawing.Point(390, 26);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(97, 41);
            this.btnEliminar3.TabIndex = 2;
            this.btnEliminar3.Text = "Eliminar";
            this.btnEliminar3.UseVisualStyleBackColor = true;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar3_Click);
            // 
            // btnEditar3
            // 
            this.btnEditar3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar3.Location = new System.Drawing.Point(215, 26);
            this.btnEditar3.Name = "btnEditar3";
            this.btnEditar3.Size = new System.Drawing.Size(97, 41);
            this.btnEditar3.TabIndex = 1;
            this.btnEditar3.Text = "Editar";
            this.btnEditar3.UseVisualStyleBackColor = true;
            this.btnEditar3.Click += new System.EventHandler(this.btnEditar3_Click);
            // 
            // btnGuardar3
            // 
            this.btnGuardar3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar3.Location = new System.Drawing.Point(44, 26);
            this.btnGuardar3.Name = "btnGuardar3";
            this.btnGuardar3.Size = new System.Drawing.Size(97, 41);
            this.btnGuardar3.TabIndex = 0;
            this.btnGuardar3.Text = "Guardar";
            this.btnGuardar3.UseVisualStyleBackColor = true;
            this.btnGuardar3.Click += new System.EventHandler(this.btnGuardar3_Click);
            // 
            // HorarioContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.presentar3);
            this.Name = "HorarioContenedor";
            this.Size = new System.Drawing.Size(1651, 736);
            this.Load += new System.EventHandler(this.HorarioContenedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presentar3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Dato.ResumeLayout(false);
            this.Dato.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView presentar3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dato;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtHoraInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar3;
        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Button btnEditar3;
        private System.Windows.Forms.Button btnGuardar3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbMateria;
    }
}
