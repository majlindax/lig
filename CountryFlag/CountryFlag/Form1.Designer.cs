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
            this.CountryFlag = new System.Windows.Forms.PictureBox();
            this.France = new System.Windows.Forms.RadioButton();
            this.Sweden = new System.Windows.Forms.RadioButton();
            this.Italy = new System.Windows.Forms.RadioButton();
            this.Spain = new System.Windows.Forms.RadioButton();
            this.HideFormTitle = new System.Windows.Forms.CheckBox();
            this.HideCountryName = new System.Windows.Forms.CheckBox();
            this.HideProgrammerName = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CountryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryFlag
            // 
            this.CountryFlag.Image = global::CountryFlag.Properties.Resources.france;
            this.CountryFlag.Location = new System.Drawing.Point(29, 32);
            this.CountryFlag.Name = "CountryFlag";
            this.CountryFlag.Size = new System.Drawing.Size(223, 136);
            this.CountryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountryFlag.TabIndex = 0;
            this.CountryFlag.TabStop = false;
            this.CountryFlag.Click += new System.EventHandler(this.CountryFlag_Click);
            // 
            // France
            // 
            this.France.AutoSize = true;
            this.France.Location = new System.Drawing.Point(297, 33);
            this.France.Name = "France";
            this.France.Size = new System.Drawing.Size(58, 17);
            this.France.TabIndex = 2;
            this.France.TabStop = true;
            this.France.Text = "France";
            this.France.UseVisualStyleBackColor = true;
            this.France.CheckedChanged += new System.EventHandler(this.DisplayFranceFlag);
            // 
            // Sweden
            // 
            this.Sweden.AutoSize = true;
            this.Sweden.Location = new System.Drawing.Point(297, 56);
            this.Sweden.Name = "Sweden";
            this.Sweden.Size = new System.Drawing.Size(64, 17);
            this.Sweden.TabIndex = 3;
            this.Sweden.TabStop = true;
            this.Sweden.Text = "Sweden";
            this.Sweden.UseVisualStyleBackColor = true;
            this.Sweden.CheckedChanged += new System.EventHandler(this.DisplaySwedenFlag);
            // 
            // Italy
            // 
            this.Italy.AutoSize = true;
            this.Italy.Location = new System.Drawing.Point(297, 79);
            this.Italy.Name = "Italy";
            this.Italy.Size = new System.Drawing.Size(44, 17);
            this.Italy.TabIndex = 4;
            this.Italy.TabStop = true;
            this.Italy.Text = "Italy";
            this.Italy.UseVisualStyleBackColor = true;
            this.Italy.CheckedChanged += new System.EventHandler(this.DisplayItalyFlag);
            // 
            // Spain
            // 
            this.Spain.AutoSize = true;
            this.Spain.Location = new System.Drawing.Point(297, 102);
            this.Spain.Name = "Spain";
            this.Spain.Size = new System.Drawing.Size(52, 17);
            this.Spain.TabIndex = 5;
            this.Spain.TabStop = true;
            this.Spain.Text = "Spain";
            this.Spain.UseVisualStyleBackColor = true;
            this.Spain.CheckedChanged += new System.EventHandler(this.DispalySpainFlag);
            // 
            // HideFormTitle
            // 
            this.HideFormTitle.AutoSize = true;
            this.HideFormTitle.Location = new System.Drawing.Point(297, 128);
            this.HideFormTitle.Name = "HideFormTitle";
            this.HideFormTitle.Size = new System.Drawing.Size(90, 17);
            this.HideFormTitle.TabIndex = 6;
            this.HideFormTitle.Text = "Hide form title";
            this.HideFormTitle.UseVisualStyleBackColor = true;
            this.HideFormTitle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HideCountryName
            // 
            this.HideCountryName.AutoSize = true;
            this.HideCountryName.Location = new System.Drawing.Point(297, 151);
            this.HideCountryName.Name = "HideCountryName";
            this.HideCountryName.Size = new System.Drawing.Size(116, 17);
            this.HideCountryName.TabIndex = 7;
            this.HideCountryName.Text = "Hide Country name";
            this.HideCountryName.UseVisualStyleBackColor = true;
            this.HideCountryName.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // HideProgrammerName
            // 
            this.HideProgrammerName.AutoSize = true;
            this.HideProgrammerName.Location = new System.Drawing.Point(297, 174);
            this.HideProgrammerName.Name = "HideProgrammerName";
            this.HideProgrammerName.Size = new System.Drawing.Size(135, 17);
            this.HideProgrammerName.TabIndex = 8;
            this.HideProgrammerName.Text = "Hide programmer name";
            this.HideProgrammerName.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(381, 242);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(381, 206);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 10;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CountryName
            // 
            this.CountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryName.Location = new System.Drawing.Point(53, 188);
            this.CountryName.Name = "CountryName";
            this.CountryName.Size = new System.Drawing.Size(174, 66);
            this.CountryName.TabIndex = 11;
            this.CountryName.Text = "label1";
            this.CountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 277);
            this.Controls.Add(this.CountryName);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HideProgrammerName);
            this.Controls.Add(this.HideCountryName);
            this.Controls.Add(this.HideFormTitle);
            this.Controls.Add(this.Spain);
            this.Controls.Add(this.Italy);
            this.Controls.Add(this.Sweden);
            this.Controls.Add(this.France);
            this.Controls.Add(this.CountryFlag);
            this.Name = "Form1";
            this.Text = "Country Flag by Joanna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountryFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CountryFlag;
        private System.Windows.Forms.RadioButton France;
        private System.Windows.Forms.RadioButton Sweden;
        private System.Windows.Forms.RadioButton Italy;
        private System.Windows.Forms.RadioButton Spain;
        private System.Windows.Forms.CheckBox HideFormTitle;
        private System.Windows.Forms.CheckBox HideCountryName;
        private System.Windows.Forms.CheckBox HideProgrammerName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label CountryName;
    }
}

