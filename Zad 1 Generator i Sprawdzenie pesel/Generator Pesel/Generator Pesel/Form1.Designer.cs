namespace Generator_Pesel
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
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.buttonWstaw = new System.Windows.Forms.Button();
            this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxPlec.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "Mezczyzna",
            "Kobieta"});
            this.comboBoxPlec.Location = new System.Drawing.Point(133, 68);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(238, 47);
            this.comboBoxPlec.TabIndex = 2;
            // 
            // buttonWstaw
            // 
            this.buttonWstaw.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonWstaw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWstaw.BackgroundImage")));
            this.buttonWstaw.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWstaw.ForeColor = System.Drawing.Color.Black;
            this.buttonWstaw.Location = new System.Drawing.Point(146, 177);
            this.buttonWstaw.Name = "buttonWstaw";
            this.buttonWstaw.Size = new System.Drawing.Size(214, 60);
            this.buttonWstaw.TabIndex = 3;
            this.buttonWstaw.Text = "Generuj";
            this.buttonWstaw.UseVisualStyleBackColor = false;
            this.buttonWstaw.Click += new System.EventHandler(this.buttonWstaw_Click);
            // 
            // dateTimePickerDataUrodzenia
            // 
            this.dateTimePickerDataUrodzenia.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dateTimePickerDataUrodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(98, 121);
            this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
            this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(301, 41);
            this.dateTimePickerDataUrodzenia.TabIndex = 4;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPesel.Location = new System.Drawing.Point(98, 255);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.ReadOnly = true;
            this.textBoxPesel.Size = new System.Drawing.Size(305, 49);
            this.textBoxPesel.TabIndex = 6;
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.BackColor = System.Drawing.Color.Transparent;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpis.ForeColor = System.Drawing.Color.Black;
            this.labelOpis.Location = new System.Drawing.Point(-6, 9);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(493, 55);
            this.labelOpis.TabIndex = 7;
            this.labelOpis.Text = "Wybierz Płeć oraz Datę";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 325);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.dateTimePickerDataUrodzenia);
            this.Controls.Add(this.buttonWstaw);
            this.Controls.Add(this.comboBoxPlec);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPlec;
        private System.Windows.Forms.Button buttonWstaw;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataUrodzenia;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label labelOpis;
    }
}

