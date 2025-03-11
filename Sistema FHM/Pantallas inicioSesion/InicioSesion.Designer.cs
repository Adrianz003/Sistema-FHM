namespace Sistema_FHM
{
    partial class Menú
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.boton_ingresar = new System.Windows.Forms.Button();
            this.boton_Salir = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.ContraseñaBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton_ingresar
            // 
            this.boton_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(242)))), ((int)(((byte)(234)))));
            this.boton_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_ingresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(37)))), ((int)(((byte)(3)))));
            this.boton_ingresar.Location = new System.Drawing.Point(132, 310);
            this.boton_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.boton_ingresar.Name = "boton_ingresar";
            this.boton_ingresar.Size = new System.Drawing.Size(131, 35);
            this.boton_ingresar.TabIndex = 1;
            this.boton_ingresar.Text = "Ingresar";
            this.boton_ingresar.UseVisualStyleBackColor = false;
            this.boton_ingresar.Click += new System.EventHandler(this.buton_ingresar_Click);
            // 
            // boton_Salir
            // 
            this.boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(110)))), ((int)(((byte)(149)))));
            this.boton_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(37)))), ((int)(((byte)(3)))));
            this.boton_Salir.Location = new System.Drawing.Point(390, 310);
            this.boton_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.boton_Salir.Name = "boton_Salir";
            this.boton_Salir.Size = new System.Drawing.Size(132, 35);
            this.boton_Salir.TabIndex = 2;
            this.boton_Salir.Text = "Salir";
            this.boton_Salir.UseVisualStyleBackColor = false;
            this.boton_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(37)))), ((int)(((byte)(3)))));
            this.text1.Location = new System.Drawing.Point(132, 179);
            this.text1.Margin = new System.Windows.Forms.Padding(2);
            this.text1.MaximumSize = new System.Drawing.Size(177, 32);
            this.text1.MinimumSize = new System.Drawing.Size(0, 32);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(131, 32);
            this.text1.TabIndex = 3;
            this.text1.Text = "Usuario";
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioBox.Location = new System.Drawing.Point(301, 179);
            this.UsuarioBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsuarioBox.MaximumSize = new System.Drawing.Size(400, 32);
            this.UsuarioBox.MinimumSize = new System.Drawing.Size(0, 32);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(221, 32);
            this.UsuarioBox.TabIndex = 5;
            // 
            // ContraseñaBox
            // 
            this.ContraseñaBox.BackColor = System.Drawing.SystemColors.Window;
            this.ContraseñaBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaBox.Location = new System.Drawing.Point(301, 221);
            this.ContraseñaBox.Margin = new System.Windows.Forms.Padding(2);
            this.ContraseñaBox.MaximumSize = new System.Drawing.Size(4000, 32);
            this.ContraseñaBox.MinimumSize = new System.Drawing.Size(0, 32);
            this.ContraseñaBox.Name = "ContraseñaBox";
            this.ContraseñaBox.Size = new System.Drawing.Size(221, 32);
            this.ContraseñaBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(37)))), ((int)(((byte)(3)))));
            this.textBox1.Location = new System.Drawing.Point(132, 221);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaximumSize = new System.Drawing.Size(177, 32);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 32);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Contraseña";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Sistema_FHM.Properties.Resources.MORELIA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ContraseñaBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.boton_Salir);
            this.Controls.Add(this.boton_ingresar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boton_ingresar;
        private System.Windows.Forms.Button boton_Salir;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.TextBox ContraseñaBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

