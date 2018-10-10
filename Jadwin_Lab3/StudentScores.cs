
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
    public partial class stdtScores : Form
    {
        // Initial values for list
        public List<List<object>> students = new List<List<object>>() { new List<object> { "Joel Murach", 97, 71, 83 },
                                                                        new List<object> { "Doug Lowe", 99, 93, 97},
                                                                        new List<object> { "Anne Boehm", 100, 100, 100 }
        };

        public stdtScores()
        {
            InitializeComponent();
            // Fill upon initialization
            fill();
        }

        public void fill()
        {
            // Clear listbox if anything is in there
            stdtBox.Items.Clear();
            String rows = "";
            for (int i = 0; i < students.Count; i++)
            {
                rows = "";
                for (int j = 0; j < students[i].Count; j++)
                {
                    rows += students[i][j] + "|";
                }
                stdtBox.Items.Add(rows);
            }
        }

        private void stdtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // -1 is no selection in listbox
            if (stdtBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                scoreTotal.Text = total().ToString();
                scoreCount.Text = count().ToString();
                average.Text = avg().ToString();
            }
        }

        public int total()
        {
            int total = 0;
            for (int i = 1; i < students[stdtBox.SelectedIndex].Count; i++)
            {
                total += Convert.ToInt32(students[stdtBox.SelectedIndex][i]);
            }
            return total;
        }
        public int count()
        {
            int count = students[stdtBox.SelectedIndex].Count - 1;

            return count;
        }
        public int avg()
        {
            int avg = total() / count();
            return avg;
        }

        // Launch add new student menu
        private void addNew_Click(object sender, EventArgs e)
        {
            using (var newStdt = new AddNewStdt(this))
            {
                newStdt.ShowDialog();
            }
        }

        // Launch update for selected student
        private void update_Click(object sender, EventArgs e)
        {
            // -1 is no selection in listbox
            if (stdtBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to modify", "Notice");
                return;
            }
            else
            {
                using (var update = new UpdateStdntScores(this))
                {
                    update.ShowDialog();
                }
            }
        }

        // Exit the app
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Delete selected student
        private void delete_Click(object sender, EventArgs e)
        {
            if (stdtBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to modify", "Notice");
                return;
            }
            else
            {
                students.RemoveAt(stdtBox.SelectedIndex);
                fill();
                scoreTotal.Text = "";
                scoreCount.Text = "";
                average.Text = "";
            }
        }
    }
}
