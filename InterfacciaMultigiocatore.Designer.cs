namespace Forza4
{
    partial class InterfacciaMultigiocatore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacciaMultigiocatore));
            this.Giocatore1 = new System.Windows.Forms.TextBox();
            this.Giocatore2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Segno1 = new System.Windows.Forms.Button();
            this.Segno2 = new System.Windows.Forms.Button();
            this.Gioca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Giocatore1
            // 
            this.Giocatore1.BackColor = System.Drawing.Color.Black;
            this.Giocatore1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Giocatore1.ForeColor = System.Drawing.Color.White;
            this.Giocatore1.Location = new System.Drawing.Point(38, 68);
            this.Giocatore1.Multiline = true;
            this.Giocatore1.Name = "Giocatore1";
            this.Giocatore1.Size = new System.Drawing.Size(293, 61);
            this.Giocatore1.TabIndex = 0;
            // 
            // Giocatore2
            // 
            this.Giocatore2.BackColor = System.Drawing.Color.Black;
            this.Giocatore2.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Giocatore2.ForeColor = System.Drawing.Color.White;
            this.Giocatore2.Location = new System.Drawing.Point(38, 135);
            this.Giocatore2.Multiline = true;
            this.Giocatore2.Name = "Giocatore2";
            this.Giocatore2.Size = new System.Drawing.Size(293, 67);
            this.Giocatore2.TabIndex = 1;
            this.Giocatore2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "scrivere il nome";
            // 
            // Segno1
            // 
            this.Segno1.BackColor = System.Drawing.Color.Black;
            this.Segno1.ForeColor = System.Drawing.Color.White;
            this.Segno1.Location = new System.Drawing.Point(378, 68);
            this.Segno1.Name = "Segno1";
            this.Segno1.Size = new System.Drawing.Size(76, 51);
            this.Segno1.TabIndex = 3;
            this.Segno1.Text = "scelta \r\nsegno";
            this.Segno1.UseVisualStyleBackColor = false;
            this.Segno1.Click += new System.EventHandler(this.Segno1_Click);
            // 
            // Segno2
            // 
            this.Segno2.BackColor = System.Drawing.Color.Black;
            this.Segno2.ForeColor = System.Drawing.Color.White;
            this.Segno2.Location = new System.Drawing.Point(374, 151);
            this.Segno2.Name = "Segno2";
            this.Segno2.Size = new System.Drawing.Size(76, 51);
            this.Segno2.TabIndex = 4;
            this.Segno2.Text = "scelta \r\nsegno";
            this.Segno2.UseVisualStyleBackColor = false;
            this.Segno2.Visible = false;
            this.Segno2.Click += new System.EventHandler(this.Segno2_Click);
            // 
            // gioca
            // 
            this.Gioca.BackColor = System.Drawing.Color.Black;
            this.Gioca.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gioca.ForeColor = System.Drawing.Color.White;
            this.Gioca.Location = new System.Drawing.Point(12, 249);
            this.Gioca.Name = "gioca";
            this.Gioca.Size = new System.Drawing.Size(328, 51);
            this.Gioca.TabIndex = 5;
            this.Gioca.Text = "GIOCA";
            this.Gioca.UseVisualStyleBackColor = false;
            this.Gioca.Visible = false;
            this.Gioca.Click += new System.EventHandler(this.Gioca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 210);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 151);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // InterfacciaMultigiocatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 359);
            this.Controls.Add(this.Gioca);
            this.Controls.Add(this.Segno2);
            this.Controls.Add(this.Segno1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Giocatore2);
            this.Controls.Add(this.Giocatore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InterfacciaMultigiocatore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Giocatore1;
        private TextBox Giocatore2;
        private Label label1;
        private Button Segno1;
        private Button Segno2;
        private Button Gioca;
        private PictureBox pictureBox1;
        private Label label2;
    }
}