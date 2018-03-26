namespace Rock_Paper_SicssorsAllisonC
{
    partial class frmRockPaperScissors
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.chkScissors = new System.Windows.Forms.CheckBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.chkPaper = new System.Windows.Forms.CheckBox();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblUserChoice = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(26, 40);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(74, 35);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // chkScissors
            // 
            this.chkScissors.AutoSize = true;
            this.chkScissors.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScissors.Location = new System.Drawing.Point(219, 112);
            this.chkScissors.Name = "chkScissors";
            this.chkScissors.Size = new System.Drawing.Size(79, 27);
            this.chkScissors.TabIndex = 1;
            this.chkScissors.Text = "Scissors";
            this.chkScissors.UseVisualStyleBackColor = true;
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRock.Location = new System.Drawing.Point(219, 66);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(60, 27);
            this.chkRock.TabIndex = 2;
            this.chkRock.Text = "Rock";
            this.chkRock.UseVisualStyleBackColor = true;
            // 
            // chkPaper
            // 
            this.chkPaper.AutoSize = true;
            this.chkPaper.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaper.Location = new System.Drawing.Point(219, 90);
            this.chkPaper.Name = "chkPaper";
            this.chkPaper.Size = new System.Drawing.Size(65, 27);
            this.chkPaper.TabIndex = 3;
            this.chkPaper.Text = "Paper";
            this.chkPaper.UseVisualStyleBackColor = true;
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerChoice.Location = new System.Drawing.Point(12, 94);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(152, 23);
            this.lblComputerChoice.TabIndex = 4;
            this.lblComputerChoice.Text = "Computer Choice was:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(148, 229);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(0, 23);
            this.lblOutcome.TabIndex = 5;
            // 
            // lblUserChoice
            // 
            this.lblUserChoice.AutoSize = true;
            this.lblUserChoice.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserChoice.Location = new System.Drawing.Point(215, 40);
            this.lblUserChoice.Name = "lblUserChoice";
            this.lblUserChoice.Size = new System.Drawing.Size(90, 23);
            this.lblUserChoice.TabIndex = 6;
            this.lblUserChoice.Text = "Your Choice:";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(349, 24);
            this.mnuMenu.TabIndex = 7;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(219, 145);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(104, 79);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 8;
            this.picUser.TabStop = false;
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(26, 145);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(104, 79);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer.TabIndex = 9;
            this.picComputer.TabStop = false;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(22, 119);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 23);
            this.lblComputer.TabIndex = 10;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.chkScissors);
            this.Controls.Add(this.chkRock);
            this.Controls.Add(this.chkPaper);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblUserChoice);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Allison C";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox chkScissors;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.CheckBox chkPaper;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblUserChoice;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.Label lblComputer;
    }
}

