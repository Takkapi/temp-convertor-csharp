namespace TempConvertor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cLabel = new Label();
            fLabel = new Label();
            kLabel = new Label();
            cRadioButton = new RadioButton();
            fRadioButton = new RadioButton();
            kRadioButton = new RadioButton();
            temperature = new NumericUpDown();
            convertBtn = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)temperature).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cLabel
            // 
            cLabel.Location = new Point(98, 31);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(67, 15);
            cLabel.TabIndex = 0;
            cLabel.Text = "°C";
            // 
            // fLabel
            // 
            fLabel.Location = new Point(98, 56);
            fLabel.Name = "fLabel";
            fLabel.Size = new Size(67, 15);
            fLabel.TabIndex = 1;
            fLabel.Text = "°F";
            // 
            // kLabel
            // 
            kLabel.Location = new Point(98, 81);
            kLabel.Name = "kLabel";
            kLabel.Size = new Size(67, 15);
            kLabel.TabIndex = 3;
            kLabel.Text = "K";
            // 
            // cRadioButton
            // 
            cRadioButton.AutoSize = true;
            cRadioButton.Location = new Point(12, 29);
            cRadioButton.Name = "cRadioButton";
            cRadioButton.Size = new Size(38, 19);
            cRadioButton.TabIndex = 5;
            cRadioButton.Text = "°C";
            cRadioButton.UseVisualStyleBackColor = true;
            cRadioButton.CheckedChanged += cRadioButton_CheckedChanged;
            // 
            // fRadioButton
            // 
            fRadioButton.AutoSize = true;
            fRadioButton.Location = new Point(12, 54);
            fRadioButton.Name = "fRadioButton";
            fRadioButton.Size = new Size(36, 19);
            fRadioButton.TabIndex = 6;
            fRadioButton.Text = "°F";
            fRadioButton.UseVisualStyleBackColor = true;
            fRadioButton.CheckedChanged += fRadioButton_CheckedChanged;
            // 
            // kRadioButton
            // 
            kRadioButton.AutoSize = true;
            kRadioButton.Location = new Point(12, 79);
            kRadioButton.Name = "kRadioButton";
            kRadioButton.Size = new Size(32, 19);
            kRadioButton.TabIndex = 7;
            kRadioButton.Text = "K";
            kRadioButton.UseVisualStyleBackColor = true;
            kRadioButton.CheckedChanged += kRadioButton_CheckedChanged;
            // 
            // temperature
            // 
            temperature.Location = new Point(12, 125);
            temperature.Name = "temperature";
            temperature.Size = new Size(51, 23);
            temperature.TabIndex = 8;
            // 
            // convertBtn
            // 
            convertBtn.Enabled = false;
            convertBtn.Location = new Point(98, 125);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(67, 23);
            convertBtn.TabIndex = 9;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(184, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(184, 161);
            Controls.Add(convertBtn);
            Controls.Add(temperature);
            Controls.Add(kRadioButton);
            Controls.Add(fRadioButton);
            Controls.Add(cRadioButton);
            Controls.Add(kLabel);
            Controls.Add(fLabel);
            Controls.Add(cLabel);
            Controls.Add(menuStrip1);
            HelpButton = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(200, 200);
            MinimumSize = new Size(200, 200);
            Name = "Form1";
            Text = "Temperature Covertor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)temperature).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label cLabel;
        private Label fLabel;
        private Label kLabel;
        private RadioButton cRadioButton;
        private RadioButton fRadioButton;
        private RadioButton kRadioButton;
        private NumericUpDown temperature;
        private Button convertBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}