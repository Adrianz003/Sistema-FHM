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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnGestionEmp = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_CNomina = new System.Windows.Forms.Button();
            this.Btn_CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGestionEmp
            // 
            this.BtnGestionEmp.BackColor = System.Drawing.Color.LightCoral;
            this.BtnGestionEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionEmp.ForeColor = System.Drawing.Color.Black;
            this.BtnGestionEmp.Location = new System.Drawing.Point(78, 224);
            this.BtnGestionEmp.Name = "BtnGestionEmp";
            this.BtnGestionEmp.Size = new System.Drawing.Size(163, 66);
            this.BtnGestionEmp.TabIndex = 0;
            this.BtnGestionEmp.Text = "Gestion de Empleados";
            this.BtnGestionEmp.UseVisualStyleBackColor = false;
            this.BtnGestionEmp.Click += new System.EventHandler(this.BtnGestionEmp_Click);
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
            this.Btn_CNomina.Click += new System.EventHandler(this.Btn_CNomina_Click);
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
            this.Btn_CerrarSesion.Click += new System.EventHandler(this.Btn_CerrarSesion_Click);
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
            this.Controls.Add(this.BtnGestionEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGestionEmp;
        private System.Windows.Forms.Button Btn_Reportes;
        private System.Windows.Forms.Button Btn_CNomina;
        private System.Windows.Forms.Button Btn_CerrarSesion;
    }
}