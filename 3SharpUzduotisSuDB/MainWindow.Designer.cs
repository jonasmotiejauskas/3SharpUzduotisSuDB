﻿namespace _3SharpUzduotisSuDB
{
    partial class MainWindow
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
            this.title1 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.createCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(130, 67);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(99, 41);
            this.title1.TabIndex = 0;
            this.title1.Text = "WAR";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(220, 67);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(215, 41);
            this.title2.TabIndex = 1;
            this.title2.Text = "SIMULATOR";
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(94, 26);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(165, 41);
            this.title3.TabIndex = 2;
            this.title3.Text = "HISTORY";
            // 
            // createCountry
            // 
            this.createCountry.Location = new System.Drawing.Point(199, 300);
            this.createCountry.Name = "createCountry";
            this.createCountry.Size = new System.Drawing.Size(135, 23);
            this.createCountry.TabIndex = 3;
            this.createCountry.Text = "Create Country";
            this.createCountry.UseVisualStyleBackColor = true;
            this.createCountry.Click += new System.EventHandler(this.createCountry_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.createCountry);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "History Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Button createCountry;
    }
}
