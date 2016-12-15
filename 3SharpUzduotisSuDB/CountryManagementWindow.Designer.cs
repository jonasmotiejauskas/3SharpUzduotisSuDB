namespace _3SharpUzduotisSuDB
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
            this.changeCountryNameButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeCountryNameButton
            // 
            this.changeCountryNameButton.Location = new System.Drawing.Point(12, 101);
            this.changeCountryNameButton.Name = "changeCountryNameButton";
            this.changeCountryNameButton.Size = new System.Drawing.Size(135, 23);
            this.changeCountryNameButton.TabIndex = 0;
            this.changeCountryNameButton.Text = "Change Country Name";
            this.changeCountryNameButton.UseVisualStyleBackColor = true;
            this.changeCountryNameButton.Click += new System.EventHandler(this.changeCountryName_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.Location = new System.Drawing.Point(12, 130);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(135, 23);
            this.deleteCountryButton.TabIndex = 1;
            this.deleteCountryButton.Text = "Delete Country";
            this.deleteCountryButton.UseVisualStyleBackColor = true;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(12, 159);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(135, 23);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "Menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // CountryManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.changeCountryNameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CountryManagementWindow";
            this.Text = "My Country";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeCountryNameButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Button backToMenuButton;
    }
}