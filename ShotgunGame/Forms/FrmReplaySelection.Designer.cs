namespace ShotgunGame.Forms
{
    partial class FrmReplaySelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelGameOverMessage = new Label();
            buttonPlayAgain = new Button();
            buttonQuitGame = new Button();
            SuspendLayout();
            // 
            // labelGameOverMessage
            // 
            labelGameOverMessage.AutoSize = true;
            labelGameOverMessage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelGameOverMessage.Location = new Point(92, 25);
            labelGameOverMessage.Name = "labelGameOverMessage";
            labelGameOverMessage.Size = new Size(138, 32);
            labelGameOverMessage.TabIndex = 0;
            labelGameOverMessage.Text = "Change ME";
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.Location = new Point(41, 91);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(92, 41);
            buttonPlayAgain.TabIndex = 1;
            buttonPlayAgain.Text = "Play Again!";
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // buttonQuitGame
            // 
            buttonQuitGame.Location = new Point(190, 91);
            buttonQuitGame.Name = "buttonQuitGame";
            buttonQuitGame.Size = new Size(85, 41);
            buttonQuitGame.TabIndex = 2;
            buttonQuitGame.Text = "Quit!";
            buttonQuitGame.UseVisualStyleBackColor = true;
            buttonQuitGame.Click += buttonQuitGame_Click;
            // 
            // FrmReplaySelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 171);
            Controls.Add(buttonQuitGame);
            Controls.Add(buttonPlayAgain);
            Controls.Add(labelGameOverMessage);
            Name = "FrmReplaySelection";
            Text = "Game Over";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameOverMessage;
        private Button buttonPlayAgain;
        private Button buttonQuitGame;
    }
}