using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Feed_Rate_Adjuster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonBrowse.Click += buttonBrowse_Click;
            buttonRun.Click += buttonRun_Click;
        }

        private string _selectedFilePath;

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "G-code files (*.gcode;*.tap;*.nc)|*.gcode;*.tap;*.nc"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePath = openFileDialog.FileName;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFeedRate.Text, out double feedRate))
            {
                MessageBox.Show("Please enter a valid numeric feed rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double minFeedRate = 1.0;
            double maxFeedRate = 10000.0;

            if (feedRate < minFeedRate || feedRate > maxFeedRate)
            {
                MessageBox.Show($"Please enter a feed rate between {minFeedRate} and {maxFeedRate}.", "Invalid Feed Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedFilePath))
            {
                MessageBox.Show("Please select a G-code file.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var gcodeLines = File.ReadAllLines(_selectedFilePath).ToList();

                AdjustFeedRate(gcodeLines, feedRate);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "G-code files (*.gcode;*.tap;*.nc)|*.gcode;*.tap;*.nc",
                    DefaultExt = ".gcode"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputFilePath = saveFileDialog.FileName;

                    File.WriteAllLines(outputFilePath, gcodeLines);
                    MessageBox.Show("Feed rate adjusted and file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdjustFeedRate(List<string> gcodeLines, double newFeedRate)
        {
            for (int i = 0; i < gcodeLines.Count; i++)
            {
                string line = gcodeLines[i];
                if (line.Contains("G2") || line.Contains("G3"))
                {
                    gcodeLines[i] = Regex.Replace(line, @"F\d+(\.\d+)?", $"F{newFeedRate}");
                }
            }
        }

        private void textBoxFeedRate_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxFeedRate.Text;

            if (double.TryParse(input, out double result))
            {
                double minFeedRate = 1.0;
                double maxFeedRate = 10000.0;

                if (result < minFeedRate || result > maxFeedRate)
                {
                    textBoxFeedRate.ForeColor = Color.Red;
                }
                else
                {
                    textBoxFeedRate.ForeColor = Color.Black;
                }
            }
            else
            {
                textBoxFeedRate.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
