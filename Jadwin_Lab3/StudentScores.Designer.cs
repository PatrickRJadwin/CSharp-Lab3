namespace Jadwin_Lab3
{
    partial class stdtScores
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
            this.StdtLbl = new System.Windows.Forms.Label();
            this.stdtBox = new System.Windows.Forms.ListBox();
            this.addNew = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.scoreTotal = new System.Windows.Forms.TextBox();
            this.scoreCount = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.scrTotalLbl = new System.Windows.Forms.Label();
            this.scoreCntLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StdtLbl
            // 
            this.StdtLbl.AutoSize = true;
            this.StdtLbl.Location = new System.Drawing.Point(13, 9);
            this.StdtLbl.Name = "StdtLbl";
            this.StdtLbl.Size = new System.Drawing.Size(52, 13);
            this.StdtLbl.TabIndex = 0;
            this.StdtLbl.Text = "Students:";
            // 
            // stdtBox
            // 
            this.stdtBox.FormattingEnabled = true;
            this.stdtBox.HorizontalScrollbar = true;
            this.stdtBox.Location = new System.Drawing.Point(16, 29);
            this.stdtBox.Name = "stdtBox";
            this.stdtBox.Size = new System.Drawing.Size(214, 121);
            this.stdtBox.TabIndex = 1;
            this.stdtBox.SelectedIndexChanged += new System.EventHandler(this.stdtBox_SelectedIndexChanged);
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(237, 29);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(93, 23);
            this.addNew.TabIndex = 2;
            this.addNew.Text = "Add New...";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(237, 59);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(93, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Update...";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(237, 89);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(93, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // scoreTotal
            // 
            this.scoreTotal.Location = new System.Drawing.Point(183, 166);
            this.scoreTotal.Name = "scoreTotal";
            this.scoreTotal.ReadOnly = true;
            this.scoreTotal.Size = new System.Drawing.Size(46, 20);
            this.scoreTotal.TabIndex = 5;
            // 
            // scoreCount
            // 
            this.scoreCount.Location = new System.Drawing.Point(183, 193);
            this.scoreCount.Name = "scoreCount";
            this.scoreCount.ReadOnly = true;
            this.scoreCount.Size = new System.Drawing.Size(47, 20);
            this.scoreCount.TabIndex = 6;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(183, 220);
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Size = new System.Drawing.Size(47, 20);
            this.average.TabIndex = 7;
            // 
            // scrTotalLbl
            // 
            this.scrTotalLbl.AutoSize = true;
            this.scrTotalLbl.Location = new System.Drawing.Point(112, 169);
            this.scrTotalLbl.Name = "scrTotalLbl";
            this.scrTotalLbl.Size = new System.Drawing.Size(65, 13);
            this.scrTotalLbl.TabIndex = 8;
            this.scrTotalLbl.Text = "Score Total:";
            // 
            // scoreCntLbl
            // 
            this.scoreCntLbl.AutoSize = true;
            this.scoreCntLbl.Location = new System.Drawing.Point(108, 196);
            this.scoreCntLbl.Name = "scoreCntLbl";
            this.scoreCntLbl.Size = new System.Drawing.Size(69, 13);
            this.scoreCntLbl.TabIndex = 9;
            this.scoreCntLbl.Text = "Score Count:";
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Location = new System.Drawing.Point(127, 223);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(50, 13);
            this.avgLbl.TabIndex = 10;
            this.avgLbl.Text = "Average:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(247, 218);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // stdtScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 256);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.scoreCntLbl);
            this.Controls.Add(this.scrTotalLbl);
            this.Controls.Add(this.average);
            this.Controls.Add(this.scoreCount);
            this.Controls.Add(this.scoreTotal);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.stdtBox);
            this.Controls.Add(this.StdtLbl);
            this.Name = "stdtScores";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StdtLbl;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox scoreTotal;
        private System.Windows.Forms.TextBox scoreCount;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.Label scrTotalLbl;
        private System.Windows.Forms.Label scoreCntLbl;
        private System.Windows.Forms.Label avgLbl;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.ListBox stdtBox;
    }
}

