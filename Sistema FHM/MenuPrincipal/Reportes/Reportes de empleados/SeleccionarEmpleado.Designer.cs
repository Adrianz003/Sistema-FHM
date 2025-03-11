namespace Sistema_FHM.MenuPrincipal.Reportes.Reportes_de_empleados
{
    partial class SeleccionarEmpleado
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
            this.Btn_CerrarSeleccionarEmp = new System.Windows.Forms.Button();
            this.Btn_GenerarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_CerrarSeleccionarEmp
            // 
            this.Btn_CerrarSeleccionarEmp.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_CerrarSeleccionarEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarSeleccionarEmp.ForeColor = System.Drawing.Color.White;
            this.Btn_CerrarSeleccionarEmp.Location = new System.Drawing.Point(93, 317);
            this.Btn_CerrarSeleccionarEmp.Name = "Btn_CerrarSeleccionarEmp";
            this.Btn_CerrarSeleccionarEmp.Size = new System.Drawing.Size(173, 62);
            this.Btn_CerrarSeleccionarEmp.TabIndex = 0;
            this.Btn_CerrarSeleccionarEmp.Text = "Cerrar";
            this.Btn_CerrarSeleccionarEmp.UseVisualStyleBackColor = false;
            // 
            // Btn_GenerarReporte
            // 
            this.Btn_GenerarReporte.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_GenerarReporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarReporte.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Btn_GenerarReporte.Location = new System.Drawing.Point(453, 317);
            this.Btn_GenerarReporte.Name = "Btn_GenerarReporte";
            this.Btn_GenerarReporte.Size = new System.Drawing.Size(173, 62);
            this.Btn_GenerarReporte.TabIndex = 1;
            this.Btn_GenerarReporte.Text = "Generar Reporte";
            this.Btn_GenerarReporte.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(225, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona un empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(104, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado";
            // 
            // SeleccionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_GenerarReporte);
            this.Controls.Add(this.Btn_CerrarSeleccionarEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarEmpleado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CerrarSeleccionarEmp;
        private System.Windows.Forms.Button Btn_GenerarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}