
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
    public partial class UpdateStdntScores : Form
    {
        private stdtScores stdtScores;
        // Temporary list for storing scores
        public List<object> tempStdtScore = new List<object>();

        public UpdateStdntScores(stdtScores stdtScores)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.stdtScores = stdtScores;
            // Fill temp list
            fillList();
            // Fill listbox
            fill();
        }

        // Fill temp list
        public void fillList()
        {
            for (int i = 1; i < stdtScores.students[stdtScores.stdtBox.SelectedIndex].Count; i++)
            {
                tempStdtScore.Add(stdtScores.students[stdtScores.stdtBox.SelectedIndex][i]);
            }
        }
        
        // Fill List Box
        public void fill()
        {
            name.Text = stdtScores.students[stdtScores.stdtBox.SelectedIndex][0].ToString();
            scoresBox.Items.Clear();
            for (int i = 0; i < tempStdtScore.Count; i++)
            {
                scoresBox.Items.Add(tempStdtScore[i]);
            }
        }

        // Launch add score
        private void add_Click(object sender, EventArgs e)
        {
            using (var addScr = new AddScore(this))
            {
                addScr.ShowDialog();
            }
        }

        // Launch update score
        private void update_Click(object sender, EventArgs e)
        {
            if (scoresBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to modify", "Notice");
                return;
            }
            else
            {
                using (var updtScr = new UpdateScore(this))
                {
                    updtScr.ShowDialog();
                }
            }
        }

        // Remove selected value
        private void remove_Click(object sender, EventArgs e)
        {
            if (scoresBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to modify", "Notice");
                return;
            }
            else
            {
                tempStdtScore.RemoveAt(scoresBox.SelectedIndex);
                fill();
            }
        }

        // Clear all values
        private void clrScores_Click(object sender, EventArgs e)
        {
            tempStdtScore.Clear();
            fill();
        }
        
        private void ok_Click(object sender, EventArgs e)
        {
            // Get student name of list modified
            String name = stdtScores.students[stdtScores.stdtBox.SelectedIndex][0].ToString();
            // Insert student name into beginning of list
            tempStdtScore.Insert(0, name);
            // Clear old list
            stdtScores.students[stdtScores.stdtBox.SelectedIndex].Clear();
            // Replace with updated values
            for (int i = 0; i < tempStdtScore.Count; i++)
            {
                stdtScores.students[stdtScores.stdtBox.SelectedIndex].Add(tempStdtScore[i]);
            }
            // Refill listbox
            stdtScores.fill();
            Close();
        }

        // Cancel action
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
