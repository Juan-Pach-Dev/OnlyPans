
namespace OnlyPans
{
    partial class InicioSesión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesión));
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.Btniniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.BackColor = System.Drawing.SystemColors.Window;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lbltitulo.Location = new System.Drawing.Point(110, 9);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(199, 24);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Panaderia OnlyPans";
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(195, 51);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(114, 20);
            this.Txtusuario.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblUsuario.Location = new System.Drawing.Point(127, 51);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(62, 16);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblContraseña.Location = new System.Drawing.Point(102, 97);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(87, 16);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "Contraseña";
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.Location = new System.Drawing.Point(195, 96);
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.Size = new System.Drawing.Size(114, 20);
            this.Txtcontraseña.TabIndex = 4;
            this.Txtcontraseña.UseSystemPasswordChar = true;
            // 
            // Btniniciarsesion
            // 
            this.Btniniciarsesion.BackColor = System.Drawing.SystemColors.Window;
            this.Btniniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btniniciarsesion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btniniciarsesion.Location = new System.Drawing.Point(146, 141);
            this.Btniniciarsesion.Name = "Btniniciarsesion";
            this.Btniniciarsesion.Size = new System.Drawing.Size(130, 28);
            this.Btniniciarsesion.TabIndex = 5;
            this.Btniniciarsesion.Text = "Iniciar Sesión";
            this.Btniniciarsesion.UseVisualStyleBackColor = false;
            this.Btniniciarsesion.Click += new System.EventHandler(this.Btniniciarsesion_Click);
            // 
            // InicioSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.Btniniciarsesion);
            this.Controls.Add(this.Txtcontraseña);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Lbltitulo);
            this.Name = "InicioSesión";
            this.Text = "InicioSesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.Button Btniniciarsesion;
    }
}