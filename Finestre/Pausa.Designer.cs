namespace Forza4
{
    partial class Pausa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pausa));
            this.ricarica = new System.Windows.Forms.Button();
            this.continua = new System.Windows.Forms.Button();
            this.tornaAllaHome_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ricarica
            // 
            this.ricarica.BackColor = System.Drawing.Color.Transparent;
            this.ricarica.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.ricarica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ricarica.FlatAppearance.BorderSize = 4;
            this.ricarica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ricarica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ricarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ricarica.Font = new System.Drawing.Font("Stencil", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ricarica.ForeColor = System.Drawing.Color.White;
            this.ricarica.Location = new System.Drawing.Point(45, 40);
            this.ricarica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ricarica.Name = "ricarica";
            this.ricarica.Size = new System.Drawing.Size(96, 82);
            this.ricarica.TabIndex = 120;
            this.ricarica.Text = "↻";
            this.ricarica.UseVisualStyleBackColor = false;
            this.ricarica.Click += new System.EventHandler(this.ricarica_Click);
            // 
            // continua
            // 
            this.continua.BackColor = System.Drawing.Color.Transparent;
            this.continua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.continua.FlatAppearance.BorderSize = 4;
            this.continua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.continua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continua.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continua.ForeColor = System.Drawing.Color.White;
            this.continua.Location = new System.Drawing.Point(160, 40);
            this.continua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continua.Name = "continua";
            this.continua.Size = new System.Drawing.Size(96, 82);
            this.continua.TabIndex = 121;
            this.continua.Text = "▶";
            this.continua.UseVisualStyleBackColor = false;
            this.continua.Click += new System.EventHandler(this.continua_Click);
            // 
            // tornaAllaHome_button
            // 
            this.tornaAllaHome_button.BackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tornaAllaHome_button.FlatAppearance.BorderSize = 4;
            this.tornaAllaHome_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tornaAllaHome_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tornaAllaHome_button.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tornaAllaHome_button.ForeColor = System.Drawing.Color.White;
            this.tornaAllaHome_button.Location = new System.Drawing.Point(45, 134);
            this.tornaAllaHome_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tornaAllaHome_button.Name = "tornaAllaHome_button";
            this.tornaAllaHome_button.Size = new System.Drawing.Size(212, 82);
            this.tornaAllaHome_button.TabIndex = 122;
            this.tornaAllaHome_button.Text = "TORNA \r\nALL\'INIZIO";
            this.tornaAllaHome_button.UseVisualStyleBackColor = false;
            this.tornaAllaHome_button.Click += new System.EventHandler(this.tornaAllaHome_Click);
            // 
            // Pausa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 258);
            this.Controls.Add(this.tornaAllaHome_button);
            this.Controls.Add(this.continua);
            this.Controls.Add(this.ricarica);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pausa";
            this.Text = "Pausa";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ricarica;
        private Button continua;
        private Button tornaAllaHome_button;
    }
}