namespace ProjectVP
{
    partial class SlidingPuzzle
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPuzzle = new System.Windows.Forms.GroupBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPuzzle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 116);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Answer:";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(64, 81);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(161, 20);
            this.tbAnswer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Solve the puzzle.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbPuzzle
            // 
            this.gbPuzzle.Controls.Add(this.pbx9);
            this.gbPuzzle.Controls.Add(this.pbx8);
            this.gbPuzzle.Controls.Add(this.pbx7);
            this.gbPuzzle.Controls.Add(this.pbx6);
            this.gbPuzzle.Controls.Add(this.pbx5);
            this.gbPuzzle.Controls.Add(this.pbx4);
            this.gbPuzzle.Controls.Add(this.pbx3);
            this.gbPuzzle.Controls.Add(this.pbx2);
            this.gbPuzzle.Controls.Add(this.pbx1);
            this.gbPuzzle.Location = new System.Drawing.Point(298, 12);
            this.gbPuzzle.Name = "gbPuzzle";
            this.gbPuzzle.Size = new System.Drawing.Size(272, 288);
            this.gbPuzzle.TabIndex = 5;
            this.gbPuzzle.TabStop = false;
            this.gbPuzzle.Text = "Puzzle";
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(171, 185);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(71, 78);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 8;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(98, 185);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(71, 78);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 7;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(25, 185);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(71, 78);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 6;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(171, 105);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(71, 78);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 5;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(98, 105);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(71, 78);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 4;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(25, 105);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(71, 78);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 3;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(171, 25);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(71, 78);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(98, 25);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(71, 78);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(25, 25);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(71, 78);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "What is the name of the animal on the picture?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPuzzle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPuzzle;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label label3;
    }
}

