namespace Jadwin_Lab3
{
    partial class AddNewStdt
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.allScores = new System.Windows.Forms.TextBox();
            this.addScore = new System.Windows.Forms.Button();
            this.clrScores = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(19, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(19, 49);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Score:";
            // 
            // scoresLbl
            // 
            this.scoresLbl.AutoSize = true;
            this.scoresLbl.Location = new System.Drawing.Point(14, 81);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(43, 13);
            this.scoresLbl.TabIndex = 2;
            this.scoresLbl.Text = "Scores:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(63, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(179, 20);
            this.name.TabIndex = 3;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(63, 46);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(92, 20);
            this.score.TabIndex = 4;
            // 
            // allScores
            // 
            this.allScores.Location = new System.Drawing.Point(63, 81);
            this.allScores.Name = "allScores";
            this.allScores.ReadOnly = true;
            this.allScores.Size = new System.Drawing.Size(179, 20);
            this.allScores.TabIndex = 5;
            // 
            // addScore
            // 
            this.addScore.Location = new System.Drawing.Point(167, 44);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(75, 23);
            this.addScore.TabIndex = 6;
            this.addScore.Text = "Add Score";
            this.addScore.UseVisualStyleBackColor = true;
            this.addScore.Click += new System.EventHandler(this.addScore_Click);
            // 
            // clrScores
            // 
            this.clrScores.Location = new System.Drawing.Point(167, 108);
            this.clrScores.Name = "clrScores";
            this.clrScores.Size = new System.Drawing.Size(75, 23);
            this.clrScores.TabIndex = 7;
            this.clrScores.Text = "Clear Scores";
            this.clrScores.UseVisualStyleBackColor = true;
            this.clrScores.Click += new System.EventHandler(this.clrScores_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(167, 149);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(80, 149);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // AddNewStdt
            // 
            this.AcceptButton = this.addScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 181);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.clrScores);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.allScores);
            this.Controls.Add(this.score);
            this.Controls.Add(this.name);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.nameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewStdt";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoresLbl;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox allScores;
        private System.Windows.Forms.Button addScore;
        private System.Windows.Forms.Button clrScores;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
    }
}