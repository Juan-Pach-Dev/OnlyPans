
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
            this.Btnproducirregistroventa = new System.Windows.Forms.Button();
            this.Lblalmacenamientoventas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rtbalmacenamientodeventas
            // 
            this.Rtbalmacenamientodeventas.Location = new System.Drawing.Point(111, 72);
            this.Rtbalmacenamientodeventas.Name = "Rtbalmacenamientodeventas";
            this.Rtbalmacenamientodeventas.Size = new System.Drawing.Size(261, 339);
            this.Rtbalmacenamientodeventas.TabIndex = 0;
            this.Rtbalmacenamientodeventas.Text = "";
            // 
            // Btnproducirregistroventa
            // 
            this.Btnproducirregistroventa.Location = new System.Drawing.Point(482, 174);
            this.Btnproducirregistroventa.Name = "Btnproducirregistroventa";
            this.Btnproducirregistroventa.Size = new System.Drawing.Size(104, 72);
            this.Btnproducirregistroventa.TabIndex = 1;
            this.Btnproducirregistroventa.Text = "Producir Registro de Venta";
            this.Btnproducirregistroventa.UseVisualStyleBackColor = true;
            // 
            // Lblalmacenamientoventas
            // 
            this.Lblalmacenamientoventas.AutoSize = true;
            this.Lblalmacenamientoventas.Location = new System.Drawing.Point(151, 43);
            this.Lblalmacenamientoventas.Name = "Lblalmacenamientoventas";
            this.Lblalmacenamientoventas.Size = new System.Drawing.Size(185, 13);
            this.Lblalmacenamientoventas.TabIndex = 2;
            this.Lblalmacenamientoventas.Text = "Almacenamiento de las ventas totales";
            // 
            // InfoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lblalmacenamientoventas);
            this.Controls.Add(this.Btnproducirregistroventa);
            this.Controls.Add(this.Rtbalmacenamientodeventas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InfoAdministrador";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtbalmacenamientodeventas;
        private System.Windows.Forms.Button Btnproducirregistroventa;
        private System.Windows.Forms.Label Lblalmacenamientoventas;
    }
}