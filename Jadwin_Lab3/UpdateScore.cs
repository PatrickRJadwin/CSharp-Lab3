
/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 10-05-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jadwin_Lab3
{
    public partial class UpdateScore : Form
    {
        private UpdateStdntScores updateStdntScores;

        public UpdateScore(UpdateStdntScores updateStdntScores)
        {
            this.updateStdntScores = updateStdntScores;
            InitializeComponent();
            this.ControlBox = false;
            score.Text = updateStdntScores.tempStdtScore[updateStdntScores.scoresBox.SelectedIndex].ToString();
        }
        // Add updated number to list
        private void add_Click(object sender, EventArgs e)
        {
            int newScore = 0;
            // Check if number
            if (!int.TryParse(score.Text, out newScore))
            {
                MessageBox.Show("Please enter a number", "Notice");
            }
            // Check if in valid range
            if (newScore > 100 || newScore < 0)
            {
                MessageBox.Show("Your number must be between 0-100", "Invalid Number");
            }
            // Update value
            else
            {
                updateStdntScores.tempStdtScore[updateStdntScores.scoresBox.SelectedIndex] = Convert.ToInt32(score.Text);
                updateStdntScores.fill();
                score.Clear();
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
