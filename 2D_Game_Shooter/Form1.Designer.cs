namespace _2D_Game_Shooter
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
            this.components = new System.ComponentModel.Container();
            this.MoveBigTimer = new System.Windows.Forms.Timer(this.components);
            this.picBoxCowBoy = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblLevelText = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCowBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBigTimer
            // 
            this.MoveBigTimer.Enabled = true;
            this.MoveBigTimer.Interval = 10;
            this.MoveBigTimer.Tick += new System.EventHandler(this.MoveBigTimer_Tick);
            // 
            // picBoxCowBoy
            // 
            this.picBoxCowBoy.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCowBoy.Image = global::_2D_Game_Shooter.Properties.Resources.Cowboy_Run;
            this.picBoxCowBoy.Location = new System.Drawing.Point(535, 402);
            this.picBoxCowBoy.Name = "picBoxCowBoy";
            this.picBoxCowBoy.Size = new System.Drawing.Size(108, 113);
            this.picBoxCowBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCowBoy.TabIndex = 0;
            this.picBoxCowBoy.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 10;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 10;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 10;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 10;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveBulletsTimer
            // 
            this.MoveBulletsTimer.Enabled = true;
            this.MoveBulletsTimer.Interval = 10;
            this.MoveBulletsTimer.Tick += new System.EventHandler(this.MoveBulletsTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Interval = 10;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Gold;
            this.lblGameOver.Location = new System.Drawing.Point(526, 216);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(332, 135);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.Visible = false;
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblScoreText.ForeColor = System.Drawing.Color.Lime;
            this.lblScoreText.Location = new System.Drawing.Point(37, 33);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(104, 38);
            this.lblScoreText.TabIndex = 2;
            this.lblScoreText.Text = "Score:";
            // 
            // lblLevelText
            // 
            this.lblLevelText.AutoSize = true;
            this.lblLevelText.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelText.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblLevelText.ForeColor = System.Drawing.Color.Aqua;
            this.lblLevelText.Location = new System.Drawing.Point(37, 97);
            this.lblLevelText.Name = "lblLevelText";
            this.lblLevelText.Size = new System.Drawing.Size(94, 38);
            this.lblLevelText.TabIndex = 3;
            this.lblLevelText.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.Aqua;
            this.lblLevel.Location = new System.Drawing.Point(166, 97);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(49, 38);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "00";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(166, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 38);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2D_Game_Shooter.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblLevelText);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picBoxCowBoy);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "2D_Game_Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCowBoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBigTimer;
        private System.Windows.Forms.PictureBox picBoxCowBoy;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveBulletsTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblLevelText;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
    }
}

