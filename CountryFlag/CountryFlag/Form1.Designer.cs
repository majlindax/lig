namespace CountryFlag
{
    partial class Form1
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
            this.countryFlagPictureBox = new System.Windows.Forms.PictureBox();
            this.franceRadioButton = new System.Windows.Forms.RadioButton();
            this.swedenRadioButton = new System.Windows.Forms.RadioButton();
            this.italyRadioButton = new System.Windows.Forms.RadioButton();
            this.spainRadioButton = new System.Windows.Forms.RadioButton();
            this.hideFormTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.hideCountryNameCheckBox = new System.Windows.Forms.CheckBox();
            this.hideProgrammerNameCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.countryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countryFlagPictureBox
            // 
            this.countryFlagPictureBox.Location = new System.Drawing.Point(29, 32);
            this.countryFlagPictureBox.Name = "countryFlagPictureBox";
            this.countryFlagPictureBox.Size = new System.Drawing.Size(223, 136);
            this.countryFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryFlagPictureBox.TabIndex = 0;
            this.countryFlagPictureBox.TabStop = false;
            this.countryFlagPictureBox.Click += new System.EventHandler(this.CountryFlag_Click);
            // 
            // franceRadioButton
            // 
            this.franceRadioButton.AutoSize = true;
            this.franceRadioButton.Location = new System.Drawing.Point(297, 33);
            this.franceRadioButton.Name = "franceRadioButton";
            this.franceRadioButton.Size = new System.Drawing.Size(58, 17);
            this.franceRadioButton.TabIndex = 2;
            this.franceRadioButton.TabStop = true;
            this.franceRadioButton.Text = "France";
            this.franceRadioButton.UseVisualStyleBackColor = true;
            this.franceRadioButton.CheckedChanged += new System.EventHandler(this.SelectFranceRadioButton);
            // 
            // swedenRadioButton
            // 
            this.swedenRadioButton.AutoSize = true;
            this.swedenRadioButton.Location = new System.Drawing.Point(297, 56);
            this.swedenRadioButton.Name = "swedenRadioButton";
            this.swedenRadioButton.Size = new System.Drawing.Size(64, 17);
            this.swedenRadioButton.TabIndex = 3;
            this.swedenRadioButton.TabStop = true;
            this.swedenRadioButton.Text = "Sweden";
            this.swedenRadioButton.UseVisualStyleBackColor = true;
            this.swedenRadioButton.CheckedChanged += new System.EventHandler(this.SelectSwedenRadioButton);
            // 
            // italyRadioButton
            // 
            this.italyRadioButton.AutoSize = true;
            this.italyRadioButton.Location = new System.Drawing.Point(297, 79);
            this.italyRadioButton.Name = "italyRadioButton";
            this.italyRadioButton.Size = new System.Drawing.Size(44, 17);
            this.italyRadioButton.TabIndex = 4;
            this.italyRadioButton.TabStop = true;
            this.italyRadioButton.Text = "Italy";
            this.italyRadioButton.UseVisualStyleBackColor = true;
            this.italyRadioButton.CheckedChanged += new System.EventHandler(this.SelectItalyRadioButton);
            // 
            // spainRadioButton
            // 
            this.spainRadioButton.AutoSize = true;
            this.spainRadioButton.Location = new System.Drawing.Point(297, 102);
            this.spainRadioButton.Name = "spainRadioButton";
            this.spainRadioButton.Size = new System.Drawing.Size(52, 17);
            this.spainRadioButton.TabIndex = 5;
            this.spainRadioButton.TabStop = true;
            this.spainRadioButton.Text = "Spain";
            this.spainRadioButton.UseVisualStyleBackColor = true;
            this.spainRadioButton.CheckedChanged += new System.EventHandler(this.SelectSpainRadioButton);
            // 
            // hideFormTitleCheckBox
            // 
            this.hideFormTitleCheckBox.AutoSize = true;
            this.hideFormTitleCheckBox.Location = new System.Drawing.Point(297, 128);
            this.hideFormTitleCheckBox.Name = "hideFormTitleCheckBox";
            this.hideFormTitleCheckBox.Size = new System.Drawing.Size(90, 17);
            this.hideFormTitleCheckBox.TabIndex = 6;
            this.hideFormTitleCheckBox.Text = "Hide form title";
            this.hideFormTitleCheckBox.UseVisualStyleBackColor = true;
            this.hideFormTitleCheckBox.CheckedChanged += new System.EventHandler(this.HideFormTitleCheckboxCheckedChanged);
            // 
            // hideCountryNameCheckBox
            // 
            this.hideCountryNameCheckBox.AutoSize = true;
            this.hideCountryNameCheckBox.Location = new System.Drawing.Point(297, 151);
            this.hideCountryNameCheckBox.Name = "hideCountryNameCheckBox";
            this.hideCountryNameCheckBox.Size = new System.Drawing.Size(116, 17);
            this.hideCountryNameCheckBox.TabIndex = 7;
            this.hideCountryNameCheckBox.Text = "Hide Country name";
            this.hideCountryNameCheckBox.UseVisualStyleBackColor = true;
            this.hideCountryNameCheckBox.CheckedChanged += new System.EventHandler(this.HideCountryNameCheckboxCheckedChanged);
            // 
            // hideProgrammerNameCheckBox
            // 
            this.hideProgrammerNameCheckBox.AutoSize = true;
            this.hideProgrammerNameCheckBox.Location = new System.Drawing.Point(297, 174);
            this.hideProgrammerNameCheckBox.Name = "hideProgrammerNameCheckBox";
            this.hideProgrammerNameCheckBox.Size = new System.Drawing.Size(135, 17);
            this.hideProgrammerNameCheckBox.TabIndex = 8;
            this.hideProgrammerNameCheckBox.Text = "Hide programmer name";
            this.hideProgrammerNameCheckBox.UseVisualStyleBackColor = true;
            this.hideProgrammerNameCheckBox.CheckedChanged += new System.EventHandler(this.HideProgrammerNameCheckBoxCheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(381, 242);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(381, 206);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButtonClick);
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryNameLabel.Location = new System.Drawing.Point(53, 188);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(174, 66);
            this.countryNameLabel.TabIndex = 11;
            this.countryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 277);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideProgrammerNameCheckBox);
            this.Controls.Add(this.hideCountryNameCheckBox);
            this.Controls.Add(this.hideFormTitleCheckBox);
            this.Controls.Add(this.spainRadioButton);
            this.Controls.Add(this.italyRadioButton);
            this.Controls.Add(this.swedenRadioButton);
            this.Controls.Add(this.franceRadioButton);
            this.Controls.Add(this.countryFlagPictureBox);
            this.Name = "Form1";
            this.Text = "Country Flag";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryFlagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox countryFlagPictureBox;
        private System.Windows.Forms.RadioButton franceRadioButton;
        private System.Windows.Forms.RadioButton swedenRadioButton;
        private System.Windows.Forms.RadioButton italyRadioButton;
        private System.Windows.Forms.RadioButton spainRadioButton;
        private System.Windows.Forms.CheckBox hideFormTitleCheckBox;
        private System.Windows.Forms.CheckBox hideCountryNameCheckBox;
        private System.Windows.Forms.CheckBox hideProgrammerNameCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label countryNameLabel;
    }
}

