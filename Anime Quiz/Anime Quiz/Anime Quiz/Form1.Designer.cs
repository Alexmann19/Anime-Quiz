namespace Anime_Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbfrage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnummer = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.tbd = new System.Windows.Forms.TextBox();
            this.rba = new System.Windows.Forms.RadioButton();
            this.rbb = new System.Windows.Forms.RadioButton();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.rbd = new System.Windows.Forms.RadioButton();
            this.tbpunkte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbanime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbfrage
            // 
            this.rtbfrage.Location = new System.Drawing.Point(12, 67);
            this.rtbfrage.Name = "rtbfrage";
            this.rtbfrage.ReadOnly = true;
            this.rtbfrage.ShortcutsEnabled = false;
            this.rtbfrage.Size = new System.Drawing.Size(405, 144);
            this.rtbfrage.TabIndex = 0;
            this.rtbfrage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frage:";
            // 
            // tbnummer
            // 
            this.tbnummer.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnummer.Location = new System.Drawing.Point(55, 13);
            this.tbnummer.Name = "tbnummer";
            this.tbnummer.ReadOnly = true;
            this.tbnummer.ShortcutsEnabled = false;
            this.tbnummer.Size = new System.Drawing.Size(55, 48);
            this.tbnummer.TabIndex = 2;
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(92, 247);
            this.tba.Name = "tba";
            this.tba.ReadOnly = true;
            this.tba.ShortcutsEnabled = false;
            this.tba.Size = new System.Drawing.Size(325, 20);
            this.tba.TabIndex = 3;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(92, 273);
            this.tbb.Name = "tbb";
            this.tbb.ReadOnly = true;
            this.tbb.ShortcutsEnabled = false;
            this.tbb.Size = new System.Drawing.Size(325, 20);
            this.tbb.TabIndex = 5;
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(92, 299);
            this.tbc.Name = "tbc";
            this.tbc.ReadOnly = true;
            this.tbc.ShortcutsEnabled = false;
            this.tbc.Size = new System.Drawing.Size(325, 20);
            this.tbc.TabIndex = 6;
            // 
            // tbd
            // 
            this.tbd.Location = new System.Drawing.Point(92, 325);
            this.tbd.Name = "tbd";
            this.tbd.ReadOnly = true;
            this.tbd.ShortcutsEnabled = false;
            this.tbd.Size = new System.Drawing.Size(325, 20);
            this.tbd.TabIndex = 7;
            // 
            // rba
            // 
            this.rba.AutoSize = true;
            this.rba.Location = new System.Drawing.Point(12, 248);
            this.rba.Name = "rba";
            this.rba.Size = new System.Drawing.Size(74, 17);
            this.rba.TabIndex = 8;
            this.rba.TabStop = true;
            this.rba.Text = "Antwort A:";
            this.rba.UseVisualStyleBackColor = true;
            // 
            // rbb
            // 
            this.rbb.AutoSize = true;
            this.rbb.Location = new System.Drawing.Point(12, 274);
            this.rbb.Name = "rbb";
            this.rbb.Size = new System.Drawing.Size(74, 17);
            this.rbb.TabIndex = 9;
            this.rbb.TabStop = true;
            this.rbb.Text = "Antwort B:";
            this.rbb.UseVisualStyleBackColor = true;
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(12, 300);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(74, 17);
            this.rbc.TabIndex = 10;
            this.rbc.TabStop = true;
            this.rbc.Text = "Antwort C:";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // rbd
            // 
            this.rbd.AutoSize = true;
            this.rbd.Location = new System.Drawing.Point(12, 326);
            this.rbd.Name = "rbd";
            this.rbd.Size = new System.Drawing.Size(75, 17);
            this.rbd.TabIndex = 11;
            this.rbd.TabStop = true;
            this.rbd.Text = "Antwort D:";
            this.rbd.UseVisualStyleBackColor = true;
            // 
            // tbpunkte
            // 
            this.tbpunkte.Location = new System.Drawing.Point(317, 412);
            this.tbpunkte.Name = "tbpunkte";
            this.tbpunkte.ReadOnly = true;
            this.tbpunkte.ShortcutsEnabled = false;
            this.tbpunkte.Size = new System.Drawing.Size(100, 20);
            this.tbpunkte.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Punkte:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 81);
            this.button1.TabIndex = 14;
            this.button1.Text = "Antwort wählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbanime
            // 
            this.tbanime.Location = new System.Drawing.Point(200, 41);
            this.tbanime.Name = "tbanime";
            this.tbanime.ReadOnly = true;
            this.tbanime.ShortcutsEnabled = false;
            this.tbanime.Size = new System.Drawing.Size(217, 20);
            this.tbanime.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Anime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbanime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpunkte);
            this.Controls.Add(this.rbd);
            this.Controls.Add(this.rbc);
            this.Controls.Add(this.rbb);
            this.Controls.Add(this.rba);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.tbnummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbfrage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbfrage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnummer;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.TextBox tbd;
        private System.Windows.Forms.RadioButton rba;
        private System.Windows.Forms.RadioButton rbb;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.RadioButton rbd;
        private System.Windows.Forms.TextBox tbpunkte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbanime;
        private System.Windows.Forms.Label label3;
    }
}

