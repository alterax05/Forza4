namespace Forza4
{
    partial class Sconfitta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sconfitta));
            this.tornaAllaHome = new System.Windows.Forms.Button();
            this.ricarica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tornaAllaHome
            // 
            this.tornaAllaHome.BackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome.FlatAppearance.BorderSize = 0;
            this.tornaAllaHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tornaAllaHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tornaAllaHome.ForeColor = System.Drawing.Color.White;
            this.tornaAllaHome.Location = new System.Drawing.Point(153, 137);
            this.tornaAllaHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tornaAllaHome.Name = "tornaAllaHome";
            this.tornaAllaHome.Size = new System.Drawing.Size(147, 80);
            this.tornaAllaHome.TabIndex = 7;
            this.tornaAllaHome.Text = "TORNA ALL\'INIZIO";
            this.tornaAllaHome.UseVisualStyleBackColor = false;
            this.tornaAllaHome.Click += new System.EventHandler(this.tornaAllaHome_Click);
            // 
            // ricarica
            // 
            this.ricarica.BackColor = System.Drawing.Color.Transparent;
            this.ricarica.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.ricarica.FlatAppearance.BorderSize = 0;
            this.ricarica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ricarica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ricarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ricarica.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ricarica.ForeColor = System.Drawing.Color.White;
            this.ricarica.Location = new System.Drawing.Point(1, 137);
            this.ricarica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ricarica.Name = "ricarica";
            this.ricarica.Size = new System.Drawing.Size(147, 80);
            this.ricarica.TabIndex = 6;
            this.ricarica.Text = "GIOCA ANCORA";
            this.ricarica.UseVisualStyleBackColor = false;
            this.ricarica.Click += new System.EventHandler(this.ricarica_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sconfitta";
            // 
            // Sconfitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 215);
            this.Controls.Add(this.tornaAllaHome);
            this.Controls.Add(this.ricarica);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sconfitta";
            this.Text = "Sconfitta";
            this.ResumeLayout(false);

        }

        #endregion
        private Button tornaAllaHome;
        private Button ricarica;
        private Label label1;
    }
}