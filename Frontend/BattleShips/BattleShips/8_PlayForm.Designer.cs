﻿namespace BattleShips
{
    partial class PlayForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            meProgress = new ProgressBar();
            playerProgress = new ProgressBar();
            bsLabel = new Label();
            playerPBox = new PictureBox();
            mePBox = new PictureBox();
            playerLabel = new Label();
            meLabel = new Label();
            mePBox1 = new PictureBox();
            playerPBox1 = new PictureBox();
            winlostPBox = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            afkTimer = new System.Windows.Forms.Timer(components);
            avtTimer = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            panel5 = new Panel();
            richTextBox1 = new RichTextBox();
            backBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerPBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mePBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mePBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winlostPBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(meProgress);
            panel1.Controls.Add(playerProgress);
            panel1.Controls.Add(bsLabel);
            panel1.Controls.Add(playerPBox);
            panel1.Controls.Add(mePBox);
            panel1.Controls.Add(playerLabel);
            panel1.Controls.Add(meLabel);
            panel1.Controls.Add(mePBox1);
            panel1.Controls.Add(playerPBox1);
            panel1.Controls.Add(winlostPBox);
            panel1.Location = new Point(0, 63);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 125);
            panel1.TabIndex = 1;
            // 
            // meProgress
            // 
            meProgress.Anchor = AnchorStyles.Bottom;
            meProgress.Location = new Point(0, 113);
            meProgress.Margin = new Padding(3, 4, 3, 4);
            meProgress.Maximum = 60;
            meProgress.Name = "meProgress";
            meProgress.Size = new Size(398, 12);
            meProgress.Step = 1;
            meProgress.TabIndex = 3;
            // 
            // playerProgress
            // 
            playerProgress.Anchor = AnchorStyles.Bottom;
            playerProgress.Location = new Point(398, 113);
            playerProgress.Margin = new Padding(3, 4, 3, 4);
            playerProgress.Maximum = 60;
            playerProgress.Name = "playerProgress";
            playerProgress.Size = new Size(398, 12);
            playerProgress.TabIndex = 5;
            // 
            // bsLabel
            // 
            bsLabel.AutoSize = true;
            bsLabel.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bsLabel.ForeColor = Color.FromArgb(192, 0, 0);
            bsLabel.Location = new Point(355, 12);
            bsLabel.Name = "bsLabel";
            bsLabel.Size = new Size(86, 54);
            bsLabel.TabIndex = 1;
            bsLabel.Text = "VS";
            // 
            // playerPBox
            // 
            playerPBox.BackColor = Color.Transparent;
            playerPBox.BackgroundImage = Properties.Resources.law1;
            playerPBox.BackgroundImageLayout = ImageLayout.Stretch;
            playerPBox.BorderStyle = BorderStyle.FixedSingle;
            playerPBox.Location = new Point(712, 10);
            playerPBox.Margin = new Padding(3, 4, 3, 4);
            playerPBox.Name = "playerPBox";
            playerPBox.Size = new Size(76, 94);
            playerPBox.TabIndex = 4;
            playerPBox.TabStop = false;
            // 
            // mePBox
            // 
            mePBox.BackColor = Color.Transparent;
            mePBox.BackgroundImage = Properties.Resources.luffy1;
            mePBox.BackgroundImageLayout = ImageLayout.Stretch;
            mePBox.BorderStyle = BorderStyle.FixedSingle;
            mePBox.Location = new Point(8, 10);
            mePBox.Margin = new Padding(3, 4, 3, 4);
            mePBox.Name = "mePBox";
            mePBox.Size = new Size(76, 94);
            mePBox.TabIndex = 3;
            mePBox.TabStop = false;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerLabel.ForeColor = Color.FromArgb(192, 64, 0);
            playerLabel.Location = new Point(602, 35);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(94, 32);
            playerLabel.TabIndex = 3;
            playerLabel.Text = "Name";
            playerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meLabel
            // 
            meLabel.AutoSize = true;
            meLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            meLabel.ForeColor = Color.FromArgb(192, 64, 0);
            meLabel.Location = new Point(91, 35);
            meLabel.Name = "meLabel";
            meLabel.Size = new Size(94, 32);
            meLabel.TabIndex = 2;
            meLabel.Text = "Name";
            meLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mePBox1
            // 
            mePBox1.BackColor = Color.Black;
            mePBox1.BorderStyle = BorderStyle.FixedSingle;
            mePBox1.Location = new Point(3, 4);
            mePBox1.Margin = new Padding(3, 4, 3, 4);
            mePBox1.Name = "mePBox1";
            mePBox1.Size = new Size(86, 107);
            mePBox1.TabIndex = 7;
            mePBox1.TabStop = false;
            // 
            // playerPBox1
            // 
            playerPBox1.BackColor = Color.Black;
            playerPBox1.BorderStyle = BorderStyle.FixedSingle;
            playerPBox1.Location = new Point(707, 4);
            playerPBox1.Margin = new Padding(3, 4, 3, 4);
            playerPBox1.Name = "playerPBox1";
            playerPBox1.Size = new Size(86, 107);
            playerPBox1.TabIndex = 8;
            playerPBox1.TabStop = false;
            // 
            // winlostPBox
            // 
            winlostPBox.Anchor = AnchorStyles.Bottom;
            winlostPBox.Location = new Point(0, 0);
            winlostPBox.Margin = new Padding(3, 4, 3, 4);
            winlostPBox.Name = "winlostPBox";
            winlostPBox.Size = new Size(796, 125);
            winlostPBox.SizeMode = PictureBoxSizeMode.Zoom;
            winlostPBox.TabIndex = 9;
            winlostPBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 190);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 398);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bg;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(398, 398);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += pictureBox2_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(397, 190);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 398);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // afkTimer
            // 
            afkTimer.Interval = 500;
            afkTimer.Tick += timer1_Tick;
            // 
            // avtTimer
            // 
            avtTimer.Interval = 500;
            avtTimer.Tick += avtTimer_Tick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(backBtn);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(971, 688);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(798, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 8;
            label1.Text = "Chat: ";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(798, 592);
            button1.Name = "button1";
            button1.Size = new Size(168, 45);
            button1.TabIndex = 7;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 592);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(792, 45);
            textBox1.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(richTextBox1);
            panel5.Location = new Point(798, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(170, 524);
            panel5.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(170, 524);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Silver;
            backBtn.BackgroundImage = Properties.Resources.exit;
            backBtn.BackgroundImageLayout = ImageLayout.Zoom;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(3, 7);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 50);
            backBtn.TabIndex = 0;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 688);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Beat your opponent!";
            FormClosing += PlayForm_FormClosing;
            Load += PlayForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerPBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mePBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mePBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)winlostPBox).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label bsLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label meLabel;
        private System.Windows.Forms.PictureBox playerPBox;
        private System.Windows.Forms.PictureBox mePBox;
        private System.Windows.Forms.ProgressBar playerProgress;
        private System.Windows.Forms.ProgressBar meProgress;
        private System.Windows.Forms.Timer afkTimer;
        private System.Windows.Forms.PictureBox mePBox1;
        private System.Windows.Forms.PictureBox playerPBox1;
        private System.Windows.Forms.Timer avtTimer;
        private System.Windows.Forms.PictureBox winlostPBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button backBtn;
        private Button button1;
        private TextBox textBox1;
        private Panel panel5;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}