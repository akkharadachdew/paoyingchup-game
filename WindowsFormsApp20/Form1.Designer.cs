namespace WindowsFormsApp20
{
    partial class Form1
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
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Comp = new System.Windows.Forms.PictureBox();
            this.Stone = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.lblComScore = new System.Windows.Forms.Label();
            this.lblYouScore = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            label4.Location = new System.Drawing.Point(313, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(233, 81);
            label4.TabIndex = 16;
            label4.Text = "fight";
            // 
            // Comp
            // 
            this.Comp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Comp.BackgroundImage")));
            this.Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Comp.Location = new System.Drawing.Point(218, 268);
            this.Comp.Name = "Comp";
            this.Comp.Size = new System.Drawing.Size(175, 144);
            this.Comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Comp.TabIndex = 0;
            this.Comp.TabStop = false;
            // 
            // Stone
            // 
            this.Stone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stone.BackgroundImage")));
            this.Stone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stone.Location = new System.Drawing.Point(559, 217);
            this.Stone.Name = "Stone";
            this.Stone.Size = new System.Drawing.Size(109, 87);
            this.Stone.TabIndex = 1;
            this.Stone.TabStop = false;
            this.Stone.Click += new System.EventHandler(this.MyMove);
            // 
            // Scissors
            // 
            this.Scissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Scissors.BackgroundImage")));
            this.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.Location = new System.Drawing.Point(559, 310);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(109, 87);
            this.Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scissors.TabIndex = 2;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.MyMove);
            // 
            // Paper
            // 
            this.Paper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paper.BackgroundImage")));
            this.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paper.Location = new System.Drawing.Point(559, 403);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(109, 87);
            this.Paper.TabIndex = 3;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.MyMove);
            // 
            // lblComScore
            // 
            this.lblComScore.AutoSize = true;
            this.lblComScore.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComScore.Location = new System.Drawing.Point(108, 80);
            this.lblComScore.Name = "lblComScore";
            this.lblComScore.Size = new System.Drawing.Size(32, 33);
            this.lblComScore.TabIndex = 6;
            this.lblComScore.Text = "0";
            // 
            // lblYouScore
            // 
            this.lblYouScore.AutoSize = true;
            this.lblYouScore.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouScore.Location = new System.Drawing.Point(125, 73);
            this.lblYouScore.Name = "lblYouScore";
            this.lblYouScore.Size = new System.Drawing.Size(32, 33);
            this.lblYouScore.TabIndex = 7;
            this.lblYouScore.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(335, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(194, 51);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "PLAY GAME";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "YouScore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Computer Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(677, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlueViolet;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "vs";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblComScore);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 130);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Red;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblYouScore);
            this.groupBox2.Location = new System.Drawing.Point(582, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 130);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(731, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = " Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(858, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Stone);
            this.Controls.Add(this.Comp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรเจคเทพ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MyMove);
            ((System.ComponentModel.ISupportInitialize)(this.Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Comp;
        private System.Windows.Forms.PictureBox Stone;
        private System.Windows.Forms.PictureBox Scissors;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.Label lblComScore;
        private System.Windows.Forms.Label lblYouScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

