
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
    public partial class AddScore : Form
    {
        private UpdateStdntScores updateStdntScores;
        
        public AddScore(UpdateStdntScores updateStdntScores)
        {
            this.updateStdntScores = updateStdntScores;
            InitializeComponent();
            this.ControlBox = false;
        }

        // Add number to list
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
            // Add values to list
            else
            {
                updateStdntScores.tempStdtScore.Add(newScore);
                updateStdntScores.fill();
                score.Clear();
                Close();
            }
        }
        
        // Cancel action
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
