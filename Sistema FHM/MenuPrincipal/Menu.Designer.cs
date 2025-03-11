namespace Sistema_FHM.MenuPrincipal
{
    partial class Menu
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
            this.Btn_GestionEmp = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_CNomina = new System.Windows.Forms.Button();
            this.Btn_CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_GestionEmp
            // 
            this.Btn_GestionEmp.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_GestionEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GestionEmp.ForeColor = System.Drawing.Color.Black;
            this.Btn_GestionEmp.Location = new System.Drawing.Point(78, 224);
            this.Btn_GestionEmp.Name = "Btn_GestionEmp";
            this.Btn_GestionEmp.Size = new System.Drawing.Size(163, 66);
            this.Btn_GestionEmp.TabIndex = 0;
            this.Btn_GestionEmp.Text = "Gestion de Empleados";
            this.Btn_GestionEmp.UseVisualStyleBackColor = false;
            this.Btn_GestionEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_Reportes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reportes.ForeColor = System.Drawing.Color.Black;
            this.Btn_Reportes.Location = new System.Drawing.Point(321, 224);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(163, 66);
            this.Btn_Reportes.TabIndex = 1;
            this.Btn_Reportes.Text = "Reportes";
            this.Btn_Reportes.UseVisualStyleBackColor = false;
            // 
            // Btn_CNomina
            // 
            this.Btn_CNomina.BackColor = System.Drawing.Color.Aquamarine;
            this.Btn_CNomina.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CNomina.ForeColor = System.Drawing.Color.Black;
            this.Btn_CNomina.Location = new System.Drawing.Point(557, 224);
            this.Btn_CNomina.Name = "Btn_CNomina";
            this.Btn_CNomina.Size = new System.Drawing.Size(159, 66);
            this.Btn_CNomina.TabIndex = 2;
            this.Btn_CNomina.Text = "Calcular nómina";
            this.Btn_CNomina.UseVisualStyleBackColor = false;
            // 
            // Btn_CerrarSesion
            // 
            this.Btn_CerrarSesion.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_CerrarSesion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.Btn_CerrarSesion.Location = new System.Drawing.Point(321, 351);
            this.Btn_CerrarSesion.Name = "Btn_CerrarSesion";
            this.Btn_CerrarSesion.Size = new System.Drawing.Size(163, 40);
            this.Btn_CerrarSesion.TabIndex = 3;
            this.Btn_CerrarSesion.Text = "Cerrar Sesion";
            this.Btn_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_FHM.Properties.Resources.MORELIA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_CerrarSesion);
            this.Controls.Add(this.Btn_CNomina);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_GestionEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_GestionEmp;
        private System.Windows.Forms.Button Btn_Reportes;
        private System.Windows.Forms.Button Btn_CNomina;
        private System.Windows.Forms.Button Btn_CerrarSesion;
    }
}