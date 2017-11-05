using System;
using System.Windows.Forms;

namespace CountryFlag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFranceRadioButton(object sender, EventArgs e)
        {
            countryFlagPictureBox.Image = Properties.Resources.france;
            countryNameLabel.Text = "France";
        }

        private void SelectSwedenRadioButton(object sender, EventArgs e)
        {
            countryFlagPictureBox.Image = Properties.Resources.sweden;
            countryNameLabel.Text = "Sweden";
        }

        private void SelectItalyRadioButton(object sender, EventArgs e)
        {
            countryFlagPictureBox.Image = Properties.Resources.italy;
            countryNameLabel.Text = "Italy";
        }

        private void SelectSpainRadioButton(object sender, EventArgs e)
        {
            countryFlagPictureBox.Image = Properties.Resources.spain;
            countryNameLabel.Text = "Spain";
        }

        private void HideCountryNameCheckboxCheckedChanged(object sender, EventArgs e)
        {
            countryNameLabel.Text = string.Empty;
        }

        private void HideFormTitleCheckboxCheckedChanged(object sender, EventArgs e)
        {
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PrintButtonClick(object sender, EventArgs e)
        {
        }

        private void CountryFlag_Click(object sender, EventArgs e)
        {
        }

        private void HideProgrammerNameCheckBoxCheckedChanged(object sender, EventArgs e)
        {
        }
    }
}