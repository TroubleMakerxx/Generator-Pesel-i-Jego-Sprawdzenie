namespace pesel
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelSprawdzenie = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.panelPesel = new System.Windows.Forms.Panel();
            this.labelpesel2 = new System.Windows.Forms.Label();
            this.panelPesel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.BackColor = System.Drawing.Color.Snow;
            this.textBoxPesel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesel.Location = new System.Drawing.Point(130, 83);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(238, 35);
            this.textBoxPesel.TabIndex = 0;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSprawdz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSprawdz.BackgroundImage")));
            this.buttonSprawdz.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSprawdz.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSprawdz.Location = new System.Drawing.Point(70, 124);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(359, 56);
            this.buttonSprawdz.TabIndex = 1;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = false;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.BackColor = System.Drawing.Color.Coral;
            this.labelPlec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPlec.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlec.ForeColor = System.Drawing.Color.Snow;
            this.labelPlec.Location = new System.Drawing.Point(-3, 282);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(109, 56);
            this.labelPlec.TabIndex = 2;
            this.labelPlec.Text = "Plec";
            this.labelPlec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPlec.Visible = false;
            this.labelPlec.Click += new System.EventHandler(this.labelPlec_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Coral;
            this.labelData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelData.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Snow;
            this.labelData.Location = new System.Drawing.Point(-1, 338);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(93, 44);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelData.Visible = false;
            // 
            // labelSprawdzenie
            // 
            this.labelSprawdzenie.AutoEllipsis = true;
            this.labelSprawdzenie.AutoSize = true;
            this.labelSprawdzenie.BackColor = System.Drawing.Color.Snow;
            this.labelSprawdzenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSprawdzenie.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSprawdzenie.ForeColor = System.Drawing.Color.Black;
            this.labelSprawdzenie.Location = new System.Drawing.Point(65, 15);
            this.labelSprawdzenie.Name = "labelSprawdzenie";
            this.labelSprawdzenie.Size = new System.Drawing.Size(280, 64);
            this.labelSprawdzenie.TabIndex = 4;
            this.labelSprawdzenie.Text = "Sprawdzenie";
            this.labelSprawdzenie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSprawdzenie.UseCompatibleTextRendering = true;
            this.labelSprawdzenie.Visible = false;
            this.labelSprawdzenie.Click += new System.EventHandler(this.labelSprawdzenie_Click);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.BackColor = System.Drawing.Color.Salmon;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpis.ForeColor = System.Drawing.Color.Snow;
            this.labelOpis.Location = new System.Drawing.Point(20, 15);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(419, 65);
            this.labelOpis.TabIndex = 5;
            this.labelOpis.Text = "Wprowadź Pesel\r\n";
            this.labelOpis.Click += new System.EventHandler(this.labelOpis_Click);
            // 
            // panelPesel
            // 
            this.panelPesel.BackColor = System.Drawing.Color.Snow;
            this.panelPesel.Controls.Add(this.labelSprawdzenie);
            this.panelPesel.Controls.Add(this.labelpesel2);
            this.panelPesel.ForeColor = System.Drawing.Color.Snow;
            this.panelPesel.Location = new System.Drawing.Point(-12, 186);
            this.panelPesel.Name = "panelPesel";
            this.panelPesel.Size = new System.Drawing.Size(510, 93);
            this.panelPesel.TabIndex = 6;
            // 
            // labelpesel2
            // 
            this.labelpesel2.AutoEllipsis = true;
            this.labelpesel2.AutoSize = true;
            this.labelpesel2.BackColor = System.Drawing.Color.Snow;
            this.labelpesel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelpesel2.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpesel2.ForeColor = System.Drawing.Color.Black;
            this.labelpesel2.Location = new System.Drawing.Point(10, 15);
            this.labelpesel2.Name = "labelpesel2";
            this.labelpesel2.Size = new System.Drawing.Size(280, 64);
            this.labelpesel2.TabIndex = 7;
            this.labelpesel2.Text = "Sprawdzenie";
            this.labelpesel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpesel2.UseCompatibleTextRendering = true;
            this.labelpesel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 389);
            this.Controls.Add(this.panelPesel);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.textBoxPesel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPesel.ResumeLayout(false);
            this.panelPesel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSprawdzenie;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Panel panelPesel;
        private System.Windows.Forms.Label labelpesel2;
    }
}

