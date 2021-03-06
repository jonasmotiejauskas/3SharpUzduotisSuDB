﻿namespace _3SharpUzduotisSuDB
{
    partial class CountryManagementWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryManagementWindow));
            this.changeCountryNameButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.changeNameInput = new System.Windows.Forms.TextBox();
            this.countryDates = new System.Windows.Forms.Label();
            this.addWarriorButton = new System.Windows.Forms.Button();
            this.warriorNameLabel = new System.Windows.Forms.TextBox();
            this.thisCountryWarriors = new System.Windows.Forms.ComboBox();
            this.executionButton = new System.Windows.Forms.Button();
            this.warriorTrainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeCountryNameButton
            // 
            this.changeCountryNameButton.Location = new System.Drawing.Point(6, 33);
            this.changeCountryNameButton.Name = "changeCountryNameButton";
            this.changeCountryNameButton.Size = new System.Drawing.Size(135, 23);
            this.changeCountryNameButton.TabIndex = 0;
            this.changeCountryNameButton.Text = "Change Country Name";
            this.changeCountryNameButton.UseVisualStyleBackColor = true;
            this.changeCountryNameButton.Click += new System.EventHandler(this.changeCountryName_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.Location = new System.Drawing.Point(6, 62);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(135, 23);
            this.deleteCountryButton.TabIndex = 1;
            this.deleteCountryButton.Text = "Delete This Country";
            this.deleteCountryButton.UseVisualStyleBackColor = true;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(383, 344);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(135, 23);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "Menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.countryNameLabel.Location = new System.Drawing.Point(147, 24);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(0, 55);
            this.countryNameLabel.TabIndex = 3;
            // 
            // changeNameInput
            // 
            this.changeNameInput.Location = new System.Drawing.Point(6, 7);
            this.changeNameInput.MaxLength = 20;
            this.changeNameInput.Name = "changeNameInput";
            this.changeNameInput.Size = new System.Drawing.Size(135, 20);
            this.changeNameInput.TabIndex = 4;
            // 
            // countryDates
            // 
            this.countryDates.AutoSize = true;
            this.countryDates.BackColor = System.Drawing.Color.Transparent;
            this.countryDates.Location = new System.Drawing.Point(154, 72);
            this.countryDates.Name = "countryDates";
            this.countryDates.Size = new System.Drawing.Size(0, 13);
            this.countryDates.TabIndex = 5;
            // 
            // addWarriorButton
            // 
            this.addWarriorButton.Location = new System.Drawing.Point(6, 247);
            this.addWarriorButton.Name = "addWarriorButton";
            this.addWarriorButton.Size = new System.Drawing.Size(93, 23);
            this.addWarriorButton.TabIndex = 6;
            this.addWarriorButton.Text = "Add Warrior";
            this.addWarriorButton.UseVisualStyleBackColor = true;
            this.addWarriorButton.Click += new System.EventHandler(this.addWarriorButton_Click);
            // 
            // warriorNameLabel
            // 
            this.warriorNameLabel.Location = new System.Drawing.Point(6, 221);
            this.warriorNameLabel.MaxLength = 20;
            this.warriorNameLabel.Name = "warriorNameLabel";
            this.warriorNameLabel.Size = new System.Drawing.Size(100, 20);
            this.warriorNameLabel.TabIndex = 7;
            // 
            // thisCountryWarriors
            // 
            this.thisCountryWarriors.FormattingEnabled = true;
            this.thisCountryWarriors.Location = new System.Drawing.Point(6, 296);
            this.thisCountryWarriors.Name = "thisCountryWarriors";
            this.thisCountryWarriors.Size = new System.Drawing.Size(129, 21);
            this.thisCountryWarriors.TabIndex = 8;
            // 
            // executionButton
            // 
            this.executionButton.Location = new System.Drawing.Point(6, 352);
            this.executionButton.Name = "executionButton";
            this.executionButton.Size = new System.Drawing.Size(129, 23);
            this.executionButton.TabIndex = 9;
            this.executionButton.Text = "Execute Warrior";
            this.executionButton.UseVisualStyleBackColor = true;
            this.executionButton.Click += new System.EventHandler(this.executionButton_Click);
            // 
            // warriorTrainButton
            // 
            this.warriorTrainButton.Location = new System.Drawing.Point(6, 323);
            this.warriorTrainButton.Name = "warriorTrainButton";
            this.warriorTrainButton.Size = new System.Drawing.Size(129, 23);
            this.warriorTrainButton.TabIndex = 10;
            this.warriorTrainButton.Text = "Train Warrior";
            this.warriorTrainButton.UseVisualStyleBackColor = true;
            this.warriorTrainButton.Click += new System.EventHandler(this.warriorTrainButton_Click);
            // 
            // CountryManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3SharpUzduotisSuDB.Properties.Resources.imgres;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.warriorTrainButton);
            this.Controls.Add(this.executionButton);
            this.Controls.Add(this.thisCountryWarriors);
            this.Controls.Add(this.warriorNameLabel);
            this.Controls.Add(this.addWarriorButton);
            this.Controls.Add(this.countryDates);
            this.Controls.Add(this.changeNameInput);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.changeCountryNameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CountryManagementWindow";
            this.Text = "My Country";
            this.Load += new System.EventHandler(this.CountryManagementWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeCountryNameButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.TextBox changeNameInput;
        private System.Windows.Forms.Label countryDates;
        private System.Windows.Forms.Button addWarriorButton;
        private System.Windows.Forms.TextBox warriorNameLabel;
        private System.Windows.Forms.ComboBox thisCountryWarriors;
        private System.Windows.Forms.Button executionButton;
        private System.Windows.Forms.Button warriorTrainButton;
    }
}