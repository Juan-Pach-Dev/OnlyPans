
namespace OnlyPans
{
    partial class InfoAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoAdministrador));
            this.Rtbalmacenamientodeventas = new System.Windows.Forms.RichTextBox();
            this.Lblalmacenamientoventas = new System.Windows.Forms.Label();
            this.Btncerrarusuario = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtbalmacenamientodeventas
            // 
            this.Rtbalmacenamientodeventas.Location = new System.Drawing.Point(80, 56);
            this.Rtbalmacenamientodeventas.Name = "Rtbalmacenamientodeventas";
            this.Rtbalmacenamientodeventas.Size = new System.Drawing.Size(315, 136);
            this.Rtbalmacenamientodeventas.TabIndex = 0;
            this.Rtbalmacenamientodeventas.Text = "Buen día administrador\n\nLe agradecemos los empleados de la panadería OnlyPans, po" +
    "r\nel software proporcionado\n\nGracias por facilitar el trabajo de sus empleados";
            // 
            // Lblalmacenamientoventas
            // 
            this.Lblalmacenamientoventas.AutoSize = true;
            this.Lblalmacenamientoventas.BackColor = System.Drawing.SystemColors.Window;
            this.Lblalmacenamientoventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblalmacenamientoventas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lblalmacenamientoventas.Location = new System.Drawing.Point(113, 23);
            this.Lblalmacenamientoventas.Name = "Lblalmacenamientoventas";
            this.Lblalmacenamientoventas.Size = new System.Drawing.Size(252, 20);
            this.Lblalmacenamientoventas.TabIndex = 2;
            this.Lblalmacenamientoventas.Text = "Mensaje para el Administrador";
            // 
            // Btncerrarusuario
            // 
            this.Btncerrarusuario.BackColor = System.Drawing.SystemColors.Window;
            this.Btncerrarusuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btncerrarusuario.Location = new System.Drawing.Point(478, 44);
            this.Btncerrarusuario.Name = "Btncerrarusuario";
            this.Btncerrarusuario.Size = new System.Drawing.Size(86, 42);
            this.Btncerrarusuario.TabIndex = 31;
            this.Btncerrarusuario.Text = "Cerrar Usuario";
            this.Btncerrarusuario.UseVisualStyleBackColor = false;
            this.Btncerrarusuario.Click += new System.EventHandler(this.Btncerrarusuario_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.SystemColors.Window;
            this.Btnsalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btnsalir.Location = new System.Drawing.Point(478, 154);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(86, 38);
            this.Btnsalir.TabIndex = 32;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // InfoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btncerrarusuario);
            this.Controls.Add(this.Lblalmacenamientoventas);
            this.Controls.Add(this.Rtbalmacenamientodeventas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InfoAdministrador";
            this.Text = "InfoAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lblalmacenamientoventas;
        public System.Windows.Forms.RichTextBox Rtbalmacenamientodeventas;
        private System.Windows.Forms.Button Btncerrarusuario;
        private System.Windows.Forms.Button Btnsalir;
    }
}