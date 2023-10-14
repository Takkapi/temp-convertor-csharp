namespace TempConvertor
{
    public partial class Form1 : Form
    {

        const int fConstant = 32;
        const float kConstant = 273.15f;

        public Form1()
        {
            InitializeComponent();
            if (cRadioButton.Checked || fRadioButton.Checked || kRadioButton.Checked)
            {
                convertBtn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cLabel.Visible = false;
            fLabel.Visible = false;
            kLabel.Visible = false;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (cRadioButton.Checked)
            {
                cLabel.Visible = false;
                fLabel.Visible = true;
                kLabel.Visible = true;

                fLabel.Text = ((temperature.Value * 9 / 5) + fConstant).ToString("#.##") + " °F";
                kLabel.Text = ((float)temperature.Value + kConstant).ToString("#.##") + " K";
            }
            else if (fRadioButton.Checked)
            {
                cLabel.Visible = true;
                fLabel.Visible = false;
                kLabel.Visible = true;

                cLabel.Text = ((temperature.Value - fConstant) * 5 / 9).ToString("#.##") + " °C";
                kLabel.Text = (((float)temperature.Value - fConstant) * 5 / 9 + kConstant).ToString("#.##") + " K";
            }
            else if (kRadioButton.Checked)
            {
                cLabel.Visible = true;
                fLabel.Visible = true;
                kLabel.Visible = false;

                cLabel.Text = ((float)temperature.Value - kConstant).ToString("#.##") + " °C";
                fLabel.Text = (((float)temperature.Value - kConstant) * 9 / 5 + fConstant).ToString("#.##") + " °F";
            }
        }

        private void cRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = true;
            temperature.Minimum = -273;
        }

        private void fRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = true;
            temperature.Minimum = -459;
        }

        private void kRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = true;
            temperature.Minimum = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}