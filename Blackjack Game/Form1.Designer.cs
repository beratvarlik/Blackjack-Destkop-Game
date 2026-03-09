namespace Blackjack_Game
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
            label1 = new Label();
            label2 = new Label();
            btn_startGame = new Button();
            lbl_dealerHand = new Label();
            lbl_playerHand = new Label();
            lbl_dealerValue = new Label();
            lbl_playerValue = new Label();
            btn_cardRequest = new Button();
            btn_tourEnd = new Button();
            btn_exit = new Button();
            lbl_Result = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_restartGame = new Button();
            lbl_dealerCardsinVisible = new Label();
            lbl_dealerValueinVisible = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 26);
            label1.Name = "label1";
            label1.Size = new Size(119, 35);
            label1.TabIndex = 0;
            label1.Text = "DEALER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(353, 382);
            label2.Name = "label2";
            label2.Size = new Size(74, 35);
            label2.TabIndex = 0;
            label2.Text = "YOU";
            // 
            // btn_startGame
            // 
            btn_startGame.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_startGame.Location = new Point(273, 186);
            btn_startGame.Name = "btn_startGame";
            btn_startGame.Size = new Size(242, 81);
            btn_startGame.TabIndex = 1;
            btn_startGame.Text = "START GAME";
            btn_startGame.UseVisualStyleBackColor = true;
            btn_startGame.Click += button1_Click;
            // 
            // lbl_dealerHand
            // 
            lbl_dealerHand.AutoSize = true;
            lbl_dealerHand.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_dealerHand.Location = new Point(310, 94);
            lbl_dealerHand.Name = "lbl_dealerHand";
            lbl_dealerHand.Size = new Size(0, 41);
            lbl_dealerHand.TabIndex = 2;
            // 
            // lbl_playerHand
            // 
            lbl_playerHand.AutoSize = true;
            lbl_playerHand.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_playerHand.Location = new Point(310, 327);
            lbl_playerHand.Name = "lbl_playerHand";
            lbl_playerHand.Size = new Size(0, 41);
            lbl_playerHand.TabIndex = 2;
            // 
            // lbl_dealerValue
            // 
            lbl_dealerValue.AutoSize = true;
            lbl_dealerValue.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_dealerValue.Location = new Point(498, 26);
            lbl_dealerValue.Name = "lbl_dealerValue";
            lbl_dealerValue.Size = new Size(0, 41);
            lbl_dealerValue.TabIndex = 2;
            // 
            // lbl_playerValue
            // 
            lbl_playerValue.AutoSize = true;
            lbl_playerValue.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_playerValue.Location = new Point(498, 378);
            lbl_playerValue.Name = "lbl_playerValue";
            lbl_playerValue.Size = new Size(0, 41);
            lbl_playerValue.TabIndex = 2;
            // 
            // btn_cardRequest
            // 
            btn_cardRequest.Location = new Point(224, 211);
            btn_cardRequest.Name = "btn_cardRequest";
            btn_cardRequest.Size = new Size(165, 39);
            btn_cardRequest.TabIndex = 3;
            btn_cardRequest.Text = "Kart Çek";
            btn_cardRequest.UseVisualStyleBackColor = true;
            btn_cardRequest.Click += btn_cardRequest_Click;
            // 
            // btn_tourEnd
            // 
            btn_tourEnd.Location = new Point(395, 211);
            btn_tourEnd.Name = "btn_tourEnd";
            btn_tourEnd.Size = new Size(163, 39);
            btn_tourEnd.TabIndex = 3;
            btn_tourEnd.Text = "Kal";
            btn_tourEnd.UseVisualStyleBackColor = true;
            btn_tourEnd.Click += btn_tourEnd_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(27, 385);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(132, 39);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Oyundan Çık";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.BackColor = Color.IndianRed;
            lbl_Result.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Result.ForeColor = Color.DarkOliveGreen;
            lbl_Result.Location = new Point(155, 169);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(101, 98);
            lbl_Result.TabIndex = 4;
            lbl_Result.Text = "X";
            // 
            // btn_restartGame
            // 
            btn_restartGame.Location = new Point(273, 186);
            btn_restartGame.Name = "btn_restartGame";
            btn_restartGame.Size = new Size(242, 81);
            btn_restartGame.TabIndex = 5;
            btn_restartGame.Text = "Yeniden Oyna";
            btn_restartGame.UseVisualStyleBackColor = true;
            btn_restartGame.Click += btn_restartGame_Click;
            // 
            // lbl_dealerCardsinVisible
            // 
            lbl_dealerCardsinVisible.AutoSize = true;
            lbl_dealerCardsinVisible.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_dealerCardsinVisible.Location = new Point(12, 9);
            lbl_dealerCardsinVisible.Name = "lbl_dealerCardsinVisible";
            lbl_dealerCardsinVisible.Size = new Size(0, 41);
            lbl_dealerCardsinVisible.TabIndex = 2;
            lbl_dealerCardsinVisible.Visible = false;
            // 
            // lbl_dealerValueinVisible
            // 
            lbl_dealerValueinVisible.AutoSize = true;
            lbl_dealerValueinVisible.Font = new Font("Arial Nova Cond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_dealerValueinVisible.Location = new Point(12, 50);
            lbl_dealerValueinVisible.Name = "lbl_dealerValueinVisible";
            lbl_dealerValueinVisible.Size = new Size(0, 41);
            lbl_dealerValueinVisible.TabIndex = 2;
            lbl_dealerValueinVisible.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 94);
            label3.Name = "label3";
            label3.Size = new Size(359, 50);
            label3.TabIndex = 0;
            label3.Text = "BLACKJACK GAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_restartGame);
            Controls.Add(lbl_Result);
            Controls.Add(btn_exit);
            Controls.Add(btn_tourEnd);
            Controls.Add(btn_cardRequest);
            Controls.Add(lbl_playerValue);
            Controls.Add(lbl_playerHand);
            Controls.Add(lbl_dealerValue);
            Controls.Add(lbl_dealerValueinVisible);
            Controls.Add(lbl_dealerCardsinVisible);
            Controls.Add(lbl_dealerHand);
            Controls.Add(btn_startGame);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_startGame;
        public Label lbl_playerHand;
        public Label lbl_dealerValue;
        public Label lbl_playerValue;
        private Label lbl_dealerHand;
        private Button btn_cardRequest;
        private Button btn_tourEnd;
        private Button btn_exit;
        private Label lbl_Result;
        private System.Windows.Forms.Timer timer1;
        private Button btn_restartGame;
        private Label lbl_dealerCardsinVisible;
        private Label lbl_dealerValueinVisible;
        private Label label3;
    }
}
