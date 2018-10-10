
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
    public partial class AddNewStdt : Form
    {
        private stdtScores stdtScores;
        // list for storing scores
        public List<object> scores = new List<object>();
        // String for displaying scores
        public String listScores = "";

        public AddNewStdt(stdtScores stdtScores)
        {
            InitializeComponent();
            this.stdtScores = stdtScores;
            this.ControlBox = false;
        }

        private void addScore_Click(object sender, EventArgs e)
        {
            // Check if valid digit
            int entrScore = 0;
            if (!int.TryParse(score.Text, out entrScore))
            {
                MessageBox.Show("You must enter a number", "Invalid Input");
            }
            // Check if between 0-100
            if (entrScore > 100 || entrScore < 0)
            {
                MessageBox.Show("Your number must be between 0-100", "Invalid Input");
            }
            else
            {
                scores.Add(entrScore);
                listScores += entrScore + " ";
                allScores.Text = listScores;
                score.Clear();
                score.Focus();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            // Require name
            if (name.Text == "")
            {
                MessageBox.Show("You need to specify a name", "Invalid Input");
            }
            else
            {
                scores.Insert(0, name.Text);
                stdtScores.students.Add(scores);
                stdtScores.stdtBox.Items.Clear();
                stdtScores.fill();
                Close();
            }
        }

        // Clear scores
        private void clear()
        {
            listScores = "";
            allScores.Clear();
            name.Clear();
            score.Clear();
            scores.Clear();
        }

        private void clrScores_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        // Cancel action
        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
            Close();
        }
    }
}
