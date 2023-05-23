namespace Estacionamiento
{
    partial class Pantalla
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Controls.Add(this.panel16);
            this.panel17.Location = new System.Drawing.Point(-5, -4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(813, 459);
            this.panel17.TabIndex = 25;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel16.Location = new System.Drawing.Point(31, 33);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(744, 390);
            this.panel16.TabIndex = 23;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel17);
            this.Name = "Pantalla";
            this.Text = "Pantalla";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
    }
}