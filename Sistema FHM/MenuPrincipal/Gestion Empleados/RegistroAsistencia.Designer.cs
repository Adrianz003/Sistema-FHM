namespace Sistema_FHM.MenuPrincipal.Gestion_Empleados
{
    partial class RegistroAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cargarAsistencia = new System.Windows.Forms.DataGridView();
            this.salir = new System.Windows.Forms.Button();
            this.idEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cargarAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de asistencia";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // cargarAsistencia
            // 
            this.cargarAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cargarAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleados,
            this.nombre,
            this.asistencia,
            this.horasTrabajadas});
            this.cargarAsistencia.Location = new System.Drawing.Point(13, 60);
            this.cargarAsistencia.Name = "cargarAsistencia";
            this.cargarAsistencia.RowHeadersWidth = 51;
            this.cargarAsistencia.RowTemplate.Height = 24;
            this.cargarAsistencia.Size = new System.Drawing.Size(670, 281);
            this.cargarAsistencia.TabIndex = 2;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Firebrick;
            this.salir.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.Window;
            this.salir.Location = new System.Drawing.Point(13, 16);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(91, 24);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // idEmpleados
            // 
            this.idEmpleados.HeaderText = "Id Empleado";
            this.idEmpleados.MinimumWidth = 6;
            this.idEmpleados.Name = "idEmpleados";
            this.idEmpleados.Width = 75;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // asistencia
            // 
            this.asistencia.HeaderText = "Asistencia";
            this.asistencia.MinimumWidth = 6;
            this.asistencia.Name = "asistencia";
            this.asistencia.Width = 125;
            // 
            // horasTrabajadas
            // 
            this.horasTrabajadas.HeaderText = "Horas Trabajadas";
            this.horasTrabajadas.MinimumWidth = 6;
            this.horasTrabajadas.Name = "horasTrabajadas";
            this.horasTrabajadas.Width = 125;
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(695, 353);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.cargarAsistencia);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroAsistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cargarAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView cargarAsistencia;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajadas;
    }
}