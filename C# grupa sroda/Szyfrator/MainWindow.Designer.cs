﻿namespace Szyfrator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.TextBox();
            this.Szyfruj = new System.Windows.Forms.Button();
            this.Odszyfruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(233, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(134, 33);
            this.title.TabIndex = 0;
            this.title.Text = "Szyfrator";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operacje na pliku:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(29, 85);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(96, 39);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Otwórz";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(131, 85);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 39);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // tekst
            // 
            this.tekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tekst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tekst.ForeColor = System.Drawing.Color.DarkOrange;
            this.tekst.Location = new System.Drawing.Point(249, 85);
            this.tekst.Multiline = true;
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(301, 249);
            this.tekst.TabIndex = 4;
            // 
            // Szyfruj
            // 
            this.Szyfruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Szyfruj.Location = new System.Drawing.Point(29, 130);
            this.Szyfruj.Name = "Szyfruj";
            this.Szyfruj.Size = new System.Drawing.Size(96, 39);
            this.Szyfruj.TabIndex = 5;
            this.Szyfruj.Text = "Szyfruj";
            this.Szyfruj.UseVisualStyleBackColor = true;
            this.Szyfruj.Click += new System.EventHandler(this.Szyfruj_Click);
            // 
            // Odszyfruj
            // 
            this.Odszyfruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Odszyfruj.Location = new System.Drawing.Point(131, 130);
            this.Odszyfruj.Name = "Odszyfruj";
            this.Odszyfruj.Size = new System.Drawing.Size(93, 39);
            this.Odszyfruj.TabIndex = 6;
            this.Odszyfruj.Text = "Odszyfruj";
            this.Odszyfruj.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(584, 519);
            this.Controls.Add(this.Odszyfruj);
            this.Controls.Add(this.Szyfruj);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Szyfrator.Properties.Settings.Default, "Szyfrator", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = global::Szyfrator.Properties.Settings.Default.Szyfrator;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox tekst;
        private System.Windows.Forms.Button Szyfruj;
        private System.Windows.Forms.Button Odszyfruj;
    }
}

