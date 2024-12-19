namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imgPlayerChoice = new PictureBox();
            imgComputerChoice = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblTimer = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblRounds = new Label();
            btnRestart = new Button();
            countDownTimer = new System.Windows.Forms.Timer(components);
            lblPlayerScore = new Label();
            label3 = new Label();
            lblComputerScore = new Label();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)imgPlayerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgComputerChoice).BeginInit();
            SuspendLayout();
            // 
            // imgPlayerChoice
            // 
            imgPlayerChoice.Image = Properties.Resources.RPS;
            imgPlayerChoice.Location = new Point(200, 200);
            imgPlayerChoice.Name = "imgPlayerChoice";
            imgPlayerChoice.Size = new Size(232, 237);
            imgPlayerChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPlayerChoice.TabIndex = 0;
            imgPlayerChoice.TabStop = false;
            // 
            // imgComputerChoice
            // 
            imgComputerChoice.Image = Properties.Resources.RPS;
            imgComputerChoice.Location = new Point(902, 200);
            imgComputerChoice.Name = "imgComputerChoice";
            imgComputerChoice.Size = new Size(232, 237);
            imgComputerChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            imgComputerChoice.TabIndex = 1;
            imgComputerChoice.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(257, 112);
            label1.Name = "label1";
            label1.Size = new Size(130, 42);
            label1.TabIndex = 2;
            label1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(918, 112);
            label2.Name = "label2";
            label2.Size = new Size(194, 42);
            label2.TabIndex = 3;
            label2.Text = "Computer";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Moccasin;
            lblTimer.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(160, 35, 52);
            lblTimer.Location = new Point(651, 37);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 42);
            lblTimer.TabIndex = 5;
            // 
            // btnRock
            // 
            btnRock.BackColor = Color.DarkCyan;
            btnRock.Cursor = Cursors.IBeam;
            btnRock.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRock.ForeColor = SystemColors.ControlLight;
            btnRock.ImageAlign = ContentAlignment.TopLeft;
            btnRock.Location = new Point(32, 178);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(124, 59);
            btnRock.TabIndex = 6;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = false;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.BackColor = Color.DarkCyan;
            btnPaper.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaper.ForeColor = SystemColors.ControlLight;
            btnPaper.Location = new Point(32, 282);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(124, 59);
            btnPaper.TabIndex = 7;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = false;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.BackColor = Color.DarkCyan;
            btnScissors.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScissors.ForeColor = SystemColors.ControlLight;
            btnScissors.Location = new Point(32, 388);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(124, 59);
            btnScissors.TabIndex = 8;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = false;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblRounds
            // 
            lblRounds.AutoSize = true;
            lblRounds.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRounds.ForeColor = Color.LightCyan;
            lblRounds.Location = new Point(592, 488);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(134, 32);
            lblRounds.TabIndex = 9;
            lblRounds.Text = "Rounds: ";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(255, 173, 96);
            btnRestart.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.FromArgb(160, 35, 52);
            btnRestart.Location = new Point(592, 752);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(159, 70);
            btnRestart.TabIndex = 10;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // countDownTimer
            // 
            countDownTimer.Tick += countDownTimer_Tick;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerScore.ForeColor = Color.LightCyan;
            lblPlayerScore.Location = new Point(556, 224);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(23, 32);
            lblPlayerScore.TabIndex = 11;
            lblPlayerScore.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(638, 312);
            label3.Name = "label3";
            label3.Size = new Size(58, 42);
            label3.TabIndex = 12;
            label3.Text = "vs";
            // 
            // lblComputerScore
            // 
            lblComputerScore.AutoSize = true;
            lblComputerScore.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerScore.ForeColor = Color.LightCyan;
            lblComputerScore.Location = new Point(556, 395);
            lblComputerScore.Name = "lblComputerScore";
            lblComputerScore.Size = new Size(23, 32);
            lblComputerScore.TabIndex = 13;
            lblComputerScore.Text = ".";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Moccasin;
            lblMessage.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(160, 35, 52);
            lblMessage.Location = new Point(304, 604);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 28);
            lblMessage.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(1272, 850);
            Controls.Add(lblMessage);
            Controls.Add(lblComputerScore);
            Controls.Add(label3);
            Controls.Add(lblPlayerScore);
            Controls.Add(btnRestart);
            Controls.Add(lblRounds);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(lblTimer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgComputerChoice);
            Controls.Add(imgPlayerChoice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgPlayerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgComputerChoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgPlayerChoice;
        private PictureBox imgComputerChoice;
        private Label label1;
        private Label label2;
        private Label lblTimer;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblRounds;
        private Button btnRestart;
        private System.Windows.Forms.Timer countDownTimer;
        private Label lblPlayerScore;
        private Label label3;
        private Label lblComputerScore;
        private Label lblMessage;
    }
}
