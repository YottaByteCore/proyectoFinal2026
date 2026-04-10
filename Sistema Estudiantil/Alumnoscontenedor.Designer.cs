using System;

namespace Sistema_Estudiantil
{
    partial class Alumnoscontenedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Panel();
            this.Nombre1 = new System.Windows.Forms.TextBox();
            this.Apellido1 = new System.Windows.Forms.TextBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.sexo1 = new System.Windows.Forms.ComboBox();
            this.Telefono1 = new System.Windows.Forms.TextBox();
            this.Email1 = new System.Windows.Forms.TextBox();
            this.Estado1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.presentar1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dato.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seccion de Alumnos";
            // 
            // Dato
            // 
            this.Dato.Controls.Add(this.label8);
            this.Dato.Controls.Add(this.label7);
            this.Dato.Controls.Add(this.label6);
            this.Dato.Controls.Add(this.label5);
            this.Dato.Controls.Add(this.label4);
            this.Dato.Controls.Add(this.label3);
            this.Dato.Controls.Add(this.label2);
            this.Dato.Controls.Add(this.Estado1);
            this.Dato.Controls.Add(this.Email1);
            this.Dato.Controls.Add(this.Telefono1);
            this.Dato.Controls.Add(this.sexo1);
            this.Dato.Controls.Add(this.FechaNacimiento);
            this.Dato.Controls.Add(this.Apellido1);
            this.Dato.Controls.Add(this.Nombre1);
            this.Dato.Location = new System.Drawing.Point(3, 106);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(751, 417);
            this.Dato.TabIndex = 1;
            // 
            // Nombre1
            // 
            this.Nombre1.Location = new System.Drawing.Point(115, 23);
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.Size = new System.Drawing.Size(251, 22);
            this.Nombre1.TabIndex = 0;
            this.Nombre1.TextChanged += new System.EventHandler(this.Nombre1_TextChanged);
            // 
            // Apellido1
            // 
            this.Apellido1.Location = new System.Drawing.Point(115, 83);
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Size = new System.Drawing.Size(251, 22);
            this.Apellido1.TabIndex = 1;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Location = new System.Drawing.Point(199, 221);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.FechaNacimiento.TabIndex = 2;
            // 
            // sexo1
            // 
            this.sexo1.FormattingEnabled = true;
            this.sexo1.Location = new System.Drawing.Point(502, 29);
            this.sexo1.Name = "sexo1";
            this.sexo1.Size = new System.Drawing.Size(171, 24);
            this.sexo1.TabIndex = 3;
            // 
            // Telefono1
            // 
            this.Telefono1.Location = new System.Drawing.Point(115, 151);
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.Size = new System.Drawing.Size(251, 22);
            this.Telefono1.TabIndex = 4;
            // 
            // Email1
            // 
            this.Email1.Location = new System.Drawing.Point(524, 149);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(176, 22);
            this.Email1.TabIndex = 5;
            this.Email1.TextChanged += new System.EventHandler(this.Email1_TextChanged);
            // 
            // Estado1
            // 
            this.Estado1.FormattingEnabled = true;
            this.Estado1.Location = new System.Drawing.Point(128, 301);
            this.Estado1.Name = "Estado1";
            this.Estado1.Size = new System.Drawing.Size(154, 24);
            this.Estado1.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Nacimiento:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.tbnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(3, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(44, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 41);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(215, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 41);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbnEliminar
            // 
            this.tbnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnEliminar.Location = new System.Drawing.Point(390, 26);
            this.tbnEliminar.Name = "tbnEliminar";
            this.tbnEliminar.Size = new System.Drawing.Size(97, 41);
            this.tbnEliminar.TabIndex = 2;
            this.tbnEliminar.Text = "Eliminar";
            this.tbnEliminar.UseVisualStyleBackColor = true;
            this.tbnEliminar.Click += new System.EventHandler(this.tbnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(585, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 41);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // presentar1
            // 
            this.presentar1.AllowUserToAddRows = false;
            this.presentar1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presentar1.BackgroundColor = System.Drawing.Color.White;
            this.presentar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presentar1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.presentar1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.presentar1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.presentar1.DefaultCellStyle = dataGridViewCellStyle2;
            this.presentar1.EnableHeadersVisualStyles = false;
            this.presentar1.Location = new System.Drawing.Point(760, 106);
            this.presentar1.MultiSelect = false;
            this.presentar1.Name = "presentar1";
            this.presentar1.RowHeadersWidth = 51;
            this.presentar1.RowTemplate.Height = 24;
            this.presentar1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentar1.Size = new System.Drawing.Size(841, 539);
            this.presentar1.TabIndex = 3;
            this.presentar1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentar1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 100);
            this.panel2.TabIndex = 4;
            // 
            // Alumnoscontenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.presentar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dato);
            this.Name = "Alumnoscontenedor";
            this.Size = new System.Drawing.Size(1651, 736);
            this.Load += new System.EventHandler(this.Alumnoscontenedor_Load);
            this.Dato.ResumeLayout(false);
            this.Dato.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presentar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dato;
        private System.Windows.Forms.TextBox Nombre1;
        private System.Windows.Forms.ComboBox Estado1;
        private System.Windows.Forms.TextBox Email1;
        private System.Windows.Forms.TextBox Telefono1;
        private System.Windows.Forms.ComboBox sexo1;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.TextBox Apellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button tbnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView presentar1;
        private System.Windows.Forms.Panel panel2;
    }
}
