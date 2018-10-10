namespace Jadwin_Lab3
{
    partial class UpdateStdntScores
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
            this.name = new System.Windows.Forms.TextBox();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.scoresBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clrScores = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(56, 6);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(191, 20);
            this.name.TabIndex = 1;
            // 
            // scoresLbl
            // 
            this.scoresLbl.AutoSize = true;
            this.scoresLbl.Location = new System.Drawing.Point(7, 40);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(43, 13);
            this.scoresLbl.TabIndex = 2;
            this.scoresLbl.Text = "Scores:";
            // 
            // scoresBox
            // 
            this.scoresBox.FormattingEnabled = true;
            this.scoresBox.Location = new System.Drawing.Point(56, 40);
            this.scoresBox.Name = "scoresBox";
            this.scoresBox.Size = new System.Drawing.Size(99, 108);
            this.scoresBox.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(172, 38);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(172, 68);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(172, 98);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 6;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // clrScores
            // 
            this.clrScores.Location = new System.Drawing.Point(172, 128);
            this.clrScores.Name = "clrScores";
            this.clrScores.Size = new System.Drawing.Size(75, 23);
            this.clrScores.TabIndex = 7;
            this.clrScores.Text = "Clear Scores";
            this.clrScores.UseVisualStyleBackColor = true;
            this.clrScores.Click += new System.EventHandler(this.clrScores_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(172, 167);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(80, 167);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // UpdateStdntScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 200);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.clrScores);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.scoresBox);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStdntScores";
            this.Text = "updateStdntScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label scoresLbl;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clrScores;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        public System.Windows.Forms.ListBox scoresBox;
    }
}