namespace _3SharpUzduotisSuDB
{
    partial class CreateCountryWindow
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
            this.cNameLabel = new System.Windows.Forms.Label();
            this.countryNameInput = new System.Windows.Forms.TextBox();
            this.createCountryButton = new System.Windows.Forms.Button();
            this.cancelCreateCountryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cNameLabel
            // 
            this.cNameLabel.AutoSize = true;
            this.cNameLabel.Location = new System.Drawing.Point(72, 56);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(99, 13);
            this.cNameLabel.TabIndex = 0;
            this.cNameLabel.Text = "New Country Name";
            // 
            // countryNameInput
            // 
            this.countryNameInput.Location = new System.Drawing.Point(48, 72);
            this.countryNameInput.MaxLength = 20;
            this.countryNameInput.Name = "countryNameInput";
            this.countryNameInput.Size = new System.Drawing.Size(152, 20);
            this.countryNameInput.TabIndex = 1;
            // 
            // createCountryButton
            // 
            this.createCountryButton.Location = new System.Drawing.Point(86, 127);
            this.createCountryButton.Name = "createCountryButton";
            this.createCountryButton.Size = new System.Drawing.Size(75, 23);
            this.createCountryButton.TabIndex = 2;
            this.createCountryButton.Text = "Create";
            this.createCountryButton.UseVisualStyleBackColor = true;
            this.createCountryButton.Click += new System.EventHandler(this.createCountryButton_Click);
            // 
            // cancelCreateCountryButton
            // 
            this.cancelCreateCountryButton.Location = new System.Drawing.Point(86, 156);
            this.cancelCreateCountryButton.Name = "cancelCreateCountryButton";
            this.cancelCreateCountryButton.Size = new System.Drawing.Size(75, 23);
            this.cancelCreateCountryButton.TabIndex = 3;
            this.cancelCreateCountryButton.Text = "Cancel";
            this.cancelCreateCountryButton.UseVisualStyleBackColor = true;
            this.cancelCreateCountryButton.Click += new System.EventHandler(this.cancelCreateCountryButton_Click);
            // 
            // CreateCountryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 210);
            this.Controls.Add(this.cancelCreateCountryButton);
            this.Controls.Add(this.createCountryButton);
            this.Controls.Add(this.countryNameInput);
            this.Controls.Add(this.cNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCountryWindow";
            this.Text = "Create a Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cNameLabel;
        private System.Windows.Forms.TextBox countryNameInput;
        private System.Windows.Forms.Button createCountryButton;
        private System.Windows.Forms.Button cancelCreateCountryButton;
    }
}