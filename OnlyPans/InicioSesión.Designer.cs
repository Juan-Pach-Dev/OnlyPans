
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
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btniniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Location = new System.Drawing.Point(251, 55);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(103, 13);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Panaderia OnlyPans";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(215, 126);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(98, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Nombre de Usuario";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(215, 157);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(61, 13);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Btniniciarsesion
            // 
            this.Btniniciarsesion.Location = new System.Drawing.Point(254, 221);
            this.Btniniciarsesion.Name = "Btniniciarsesion";
            this.Btniniciarsesion.Size = new System.Drawing.Size(120, 23);
            this.Btniniciarsesion.TabIndex = 5;
            this.Btniniciarsesion.Text = "Iniciar Sesión";
            this.Btniniciarsesion.UseVisualStyleBackColor = true;
            // 
            // InicioSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btniniciarsesion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbltitulo);
            this.Name = "InicioSesión";
            this.Text = "InicioSesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btniniciarsesion;
    }
}