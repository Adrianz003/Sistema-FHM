namespace Sistema_FHM.MenuPrincipal.Reportes
{
    partial class Menu_Reportes
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
            this.Btn_ReportEmpleados = new System.Windows.Forms.Button();
            this.Btn_Rnomina = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ReportEmpleados
            // 
            this.Btn_ReportEmpleados.BackColor = System.Drawing.Color.Gold;
            this.Btn_ReportEmpleados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReportEmpleados.ForeColor = System.Drawing.Color.Peru;
            this.Btn_ReportEmpleados.Location = new System.Drawing.Point(87, 121);
            this.Btn_ReportEmpleados.Name = "Btn_ReportEmpleados";
            this.Btn_ReportEmpleados.Size = new System.Drawing.Size(177, 83);
            this.Btn_ReportEmpleados.TabIndex = 0;
            this.Btn_ReportEmpleados.Text = "Reporte de Empleados";
            this.Btn_ReportEmpleados.UseVisualStyleBackColor = false;
            this.Btn_ReportEmpleados.Click += new System.EventHandler(this.Btn_ReportEmpleados_Click);
            // 
            // Btn_Rnomina
            // 
            this.Btn_Rnomina.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_Rnomina.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rnomina.ForeColor = System.Drawing.Color.Peru;
            this.Btn_Rnomina.Location = new System.Drawing.Point(427, 121);
            this.Btn_Rnomina.Name = "Btn_Rnomina";
            this.Btn_Rnomina.Size = new System.Drawing.Size(177, 83);
            this.Btn_Rnomina.TabIndex = 1;
            this.Btn_Rnomina.Text = "Reporte de Nomina";
            this.Btn_Rnomina.UseVisualStyleBackColor = false;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(264, 279);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(163, 40);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            // 
            // Menu_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(695, 353);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Rnomina);
            this.Controls.Add(this.Btn_ReportEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Reportes";
            this.Opacity = 0.3D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ReportEmpleados;
        private System.Windows.Forms.Button Btn_Rnomina;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}