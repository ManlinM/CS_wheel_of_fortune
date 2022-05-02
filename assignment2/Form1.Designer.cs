namespace assignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.targetWordRead = new System.Windows.Forms.TextBox();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.guessNewButton = new System.Windows.Forms.Button();
            this.targetWordDisplay = new System.Windows.Forms.Label();
            this.playerGuessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hints = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userGuessWord = new System.Windows.Forms.MaskedTextBox();
            this.instruction = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scores)).BeginInit();
            this.SuspendLayout();
            // 
            // targetWordRead
            // 
            this.targetWordRead.BackColor = System.Drawing.Color.PeachPuff;
            this.targetWordRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targetWordRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWordRead.ForeColor = System.Drawing.Color.White;
            this.targetWordRead.Location = new System.Drawing.Point(162, 172);
            this.targetWordRead.Name = "targetWordRead";
            this.targetWordRead.ReadOnly = true;
            this.targetWordRead.Size = new System.Drawing.Size(237, 40);
            this.targetWordRead.TabIndex = 0;
            this.targetWordRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerName1
            // 
            this.playerName1.Location = new System.Drawing.Point(338, 439);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(100, 20);
            this.playerName1.TabIndex = 2;
            // 
            // playerName2
            // 
            this.playerName2.Location = new System.Drawing.Point(338, 472);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(100, 20);
            this.playerName2.TabIndex = 3;
            // 
            // player1Score
            // 
            this.player1Score.BackColor = System.Drawing.Color.PeachPuff;
            this.player1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1Score.Location = new System.Drawing.Point(241, 250);
            this.player1Score.Name = "player1Score";
            this.player1Score.ReadOnly = true;
            this.player1Score.Size = new System.Drawing.Size(100, 13);
            this.player1Score.TabIndex = 4;
            // 
            // player2Score
            // 
            this.player2Score.BackColor = System.Drawing.Color.PeachPuff;
            this.player2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player2Score.Location = new System.Drawing.Point(244, 312);
            this.player2Score.Name = "player2Score";
            this.player2Score.ReadOnly = true;
            this.player2Score.Size = new System.Drawing.Size(100, 13);
            this.player2Score.TabIndex = 5;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Bisque;
            this.startGame.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(244, 505);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(120, 32);
            this.startGame.TabIndex = 6;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // guessNewButton
            // 
            this.guessNewButton.BackColor = System.Drawing.Color.Bisque;
            this.guessNewButton.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessNewButton.Location = new System.Drawing.Point(241, 388);
            this.guessNewButton.Name = "guessNewButton";
            this.guessNewButton.Size = new System.Drawing.Size(127, 32);
            this.guessNewButton.TabIndex = 7;
            this.guessNewButton.Text = "Enter";
            this.guessNewButton.UseVisualStyleBackColor = false;
            this.guessNewButton.Click += new System.EventHandler(this.guessNewButton_Click_1);
            // 
            // targetWordDisplay
            // 
            this.targetWordDisplay.AutoSize = true;
            this.targetWordDisplay.BackColor = System.Drawing.Color.Transparent;
            this.targetWordDisplay.Font = new System.Drawing.Font("Ravie", 18F);
            this.targetWordDisplay.ForeColor = System.Drawing.Color.Black;
            this.targetWordDisplay.Location = new System.Drawing.Point(130, 133);
            this.targetWordDisplay.Name = "targetWordDisplay";
            this.targetWordDisplay.Size = new System.Drawing.Size(308, 34);
            this.targetWordDisplay.TabIndex = 9;
            this.targetWordDisplay.Text = "Your Target Word";
            // 
            // playerGuessLabel
            // 
            this.playerGuessLabel.AutoSize = true;
            this.playerGuessLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerGuessLabel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerGuessLabel.Location = new System.Drawing.Point(168, 362);
            this.playerGuessLabel.Name = "playerGuessLabel";
            this.playerGuessLabel.Size = new System.Drawing.Size(138, 19);
            this.playerGuessLabel.TabIndex = 10;
            this.playerGuessLabel.Text = "Guess a letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.label2.Location = new System.Drawing.Point(172, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player One Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.label3.Location = new System.Drawing.Point(172, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player Two Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.label4.Location = new System.Drawing.Point(208, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player One Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 9.75F);
            this.label5.Location = new System.Drawing.Point(203, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Player Two Score:";
            // 
            // scores
            // 
            this.scores.BackColor = System.Drawing.Color.Transparent;
            this.scores.Image = global::assignment2.Properties.Resources.welcome_pic;
            this.scores.Location = new System.Drawing.Point(730, 184);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(401, 236);
            this.scores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scores.TabIndex = 8;
            this.scores.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(743, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Spin The Wheel*";
            // 
            // hints
            // 
            this.hints.BackColor = System.Drawing.Color.PeachPuff;
            this.hints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hints.Location = new System.Drawing.Point(459, 132);
            this.hints.Margin = new System.Windows.Forms.Padding(2);
            this.hints.Name = "hints";
            this.hints.ReadOnly = true;
            this.hints.Size = new System.Drawing.Size(134, 85);
            this.hints.TabIndex = 16;
            this.hints.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(455, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hints:";
            // 
            // userGuessWord
            // 
            this.userGuessWord.Location = new System.Drawing.Point(338, 362);
            this.userGuessWord.Margin = new System.Windows.Forms.Padding(2);
            this.userGuessWord.Mask = "L";
            this.userGuessWord.Name = "userGuessWord";
            this.userGuessWord.Size = new System.Drawing.Size(76, 20);
            this.userGuessWord.TabIndex = 18;
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.Color.PeachPuff;
            this.instruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(457, 267);
            this.instruction.Margin = new System.Windows.Forms.Padding(2);
            this.instruction.Name = "instruction";
            this.instruction.ReadOnly = true;
            this.instruction.Size = new System.Drawing.Size(255, 251);
            this.instruction.TabIndex = 19;
            this.instruction.Text = resources.GetString("instruction.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ravie", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(456, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "How to play:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::assignment2.Properties.Resources.backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 647);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.userGuessWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerGuessLabel);
            this.Controls.Add(this.targetWordDisplay);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.guessNewButton);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.playerName1);
            this.Controls.Add(this.targetWordRead);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetWordRead;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.TextBox playerName2;
        private System.Windows.Forms.TextBox player1Score;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button guessNewButton;
        private System.Windows.Forms.PictureBox scores;
        private System.Windows.Forms.Label targetWordDisplay;
        private System.Windows.Forms.Label playerGuessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox hints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox userGuessWord;
        private System.Windows.Forms.RichTextBox instruction;
        private System.Windows.Forms.Label label7;
    }
}

