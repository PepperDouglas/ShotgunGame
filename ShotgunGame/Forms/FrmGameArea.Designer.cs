namespace ShotgunGame
{
    partial class FrmGameArea
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
            groupBoxUser = new GroupBox();
            labelUserBulletsCounter = new Label();
            labelUserBullets = new Label();
            buttonShotgun = new Button();
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonReload = new Button();
            groupBoxAIUser = new GroupBox();
            labelAIUserBulletsCounter = new Label();
            labelAIUserBullets = new Label();
            groupBoxPreviousActions = new GroupBox();
            labelAIUserPreviousAction = new Label();
            labelUserPreviousAction = new Label();
            labelWinsLosses = new Label();
            labelWins = new Label();
            labelLosses = new Label();
            groupBoxUser.SuspendLayout();
            groupBoxAIUser.SuspendLayout();
            groupBoxPreviousActions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(labelUserBulletsCounter);
            groupBoxUser.Controls.Add(labelUserBullets);
            groupBoxUser.Controls.Add(buttonShotgun);
            groupBoxUser.Controls.Add(buttonShoot);
            groupBoxUser.Controls.Add(buttonBlock);
            groupBoxUser.Controls.Add(buttonReload);
            groupBoxUser.Location = new Point(49, 35);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(275, 263);
            groupBoxUser.TabIndex = 1;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "The Player, aka you";
            // 
            // labelUserBulletsCounter
            // 
            labelUserBulletsCounter.AutoSize = true;
            labelUserBulletsCounter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserBulletsCounter.Location = new Point(155, 52);
            labelUserBulletsCounter.Name = "labelUserBulletsCounter";
            labelUserBulletsCounter.Size = new Size(27, 32);
            labelUserBulletsCounter.TabIndex = 5;
            labelUserBulletsCounter.Text = "0";
            // 
            // labelUserBullets
            // 
            labelUserBullets.AutoSize = true;
            labelUserBullets.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserBullets.Location = new Point(61, 52);
            labelUserBullets.Name = "labelUserBullets";
            labelUserBullets.Size = new Size(90, 32);
            labelUserBullets.TabIndex = 4;
            labelUserBullets.Text = "Bullets:";
            // 
            // buttonShotgun
            // 
            buttonShotgun.Location = new Point(155, 194);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(91, 37);
            buttonShotgun.TabIndex = 3;
            buttonShotgun.Text = "SHOTGUN";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += ButtonClick;
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(27, 194);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(95, 37);
            buttonShoot.TabIndex = 2;
            buttonShoot.Text = "SHOOT";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += ButtonClick;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(155, 137);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(91, 37);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "BLOCK";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += ButtonClick;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(27, 137);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(93, 37);
            buttonReload.TabIndex = 0;
            buttonReload.Text = "RELOAD";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += ButtonClick;
            // 
            // groupBoxAIUser
            // 
            groupBoxAIUser.Controls.Add(labelAIUserBulletsCounter);
            groupBoxAIUser.Controls.Add(labelAIUserBullets);
            groupBoxAIUser.Location = new Point(480, 35);
            groupBoxAIUser.Name = "groupBoxAIUser";
            groupBoxAIUser.RightToLeft = RightToLeft.No;
            groupBoxAIUser.Size = new Size(275, 263);
            groupBoxAIUser.TabIndex = 2;
            groupBoxAIUser.TabStop = false;
            groupBoxAIUser.Text = "AI Player";
            // 
            // labelAIUserBulletsCounter
            // 
            labelAIUserBulletsCounter.AutoSize = true;
            labelAIUserBulletsCounter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAIUserBulletsCounter.Location = new Point(167, 70);
            labelAIUserBulletsCounter.Name = "labelAIUserBulletsCounter";
            labelAIUserBulletsCounter.Size = new Size(27, 32);
            labelAIUserBulletsCounter.TabIndex = 1;
            labelAIUserBulletsCounter.Text = "0";
            // 
            // labelAIUserBullets
            // 
            labelAIUserBullets.AutoSize = true;
            labelAIUserBullets.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAIUserBullets.Location = new Point(71, 70);
            labelAIUserBullets.Name = "labelAIUserBullets";
            labelAIUserBullets.Size = new Size(90, 32);
            labelAIUserBullets.TabIndex = 0;
            labelAIUserBullets.Text = "Bullets:";
            // 
            // groupBoxPreviousActions
            // 
            groupBoxPreviousActions.Controls.Add(labelAIUserPreviousAction);
            groupBoxPreviousActions.Controls.Add(labelUserPreviousAction);
            groupBoxPreviousActions.Location = new Point(204, 325);
            groupBoxPreviousActions.Name = "groupBoxPreviousActions";
            groupBoxPreviousActions.Size = new Size(400, 100);
            groupBoxPreviousActions.TabIndex = 3;
            groupBoxPreviousActions.TabStop = false;
            groupBoxPreviousActions.Text = "Previous Actions";
            // 
            // labelAIUserPreviousAction
            // 
            labelAIUserPreviousAction.AutoSize = true;
            labelAIUserPreviousAction.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAIUserPreviousAction.Location = new Point(254, 43);
            labelAIUserPreviousAction.Name = "labelAIUserPreviousAction";
            labelAIUserPreviousAction.Size = new Size(80, 32);
            labelAIUserPreviousAction.TabIndex = 1;
            labelAIUserPreviousAction.Text = "NONE";
            // 
            // labelUserPreviousAction
            // 
            labelUserPreviousAction.AutoSize = true;
            labelUserPreviousAction.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserPreviousAction.Location = new Point(68, 43);
            labelUserPreviousAction.Name = "labelUserPreviousAction";
            labelUserPreviousAction.Size = new Size(80, 32);
            labelUserPreviousAction.TabIndex = 0;
            labelUserPreviousAction.Text = "NONE";
            // 
            // labelWinsLosses
            // 
            labelWinsLosses.AutoSize = true;
            labelWinsLosses.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWinsLosses.Location = new Point(340, 59);
            labelWinsLosses.Name = "labelWinsLosses";
            labelWinsLosses.Size = new Size(125, 25);
            labelWinsLosses.TabIndex = 4;
            labelWinsLosses.Text = "Wins / Losses";
            // 
            // labelWins
            // 
            labelWins.AutoSize = true;
            labelWins.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWins.Location = new Point(359, 96);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(19, 21);
            labelWins.TabIndex = 5;
            labelWins.Text = "0";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLosses.Location = new Point(422, 96);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(19, 21);
            labelLosses.TabIndex = 6;
            labelLosses.Text = "0";
            // 
            // FrmGameArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLosses);
            Controls.Add(labelWins);
            Controls.Add(labelWinsLosses);
            Controls.Add(groupBoxPreviousActions);
            Controls.Add(groupBoxAIUser);
            Controls.Add(groupBoxUser);
            Name = "FrmGameArea";
            Text = "FrmGameArea";
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            groupBoxAIUser.ResumeLayout(false);
            groupBoxAIUser.PerformLayout();
            groupBoxPreviousActions.ResumeLayout(false);
            groupBoxPreviousActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUser;
        private GroupBox groupBoxAIUser;
        private Label labelUserBulletsCounter;
        private Label labelUserBullets;
        private Button buttonShotgun;
        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonReload;
        private Label labelAIUserBulletsCounter;
        private Label labelAIUserBullets;
        private GroupBox groupBoxPreviousActions;
        private Label labelAIUserPreviousAction;
        private Label labelUserPreviousAction;
        private Label labelWinsLosses;
        private Label labelWins;
        private Label labelLosses;
    }
}